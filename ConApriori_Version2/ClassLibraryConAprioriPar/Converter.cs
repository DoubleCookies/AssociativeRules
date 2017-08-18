using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ClassLibraryConAprioriPar
{
    /// <summary>
    /// Конвертирует базу данных в формате csv
    /// в базу данных в формате scale    
    /// </summary>
    static public class Converter
    {
        static Dig_ar[] sort_mas;
        static int[] counts;
        static int Limit = 50000;
        static StreamReader reader;
        static StreamWriter writer;
        //static int db_len = 0;

        /// <summary>
        /// конвертирует исходную базу данных
        /// из формата csv в формат scale
        /// Добавляет в начало результирующего файла 
        /// две записи
        /// Первая строка в формате csv 
        /// с перечислением всех свойств - элементов базы данных
        /// Вторая строка задает длину фрагмента 
        /// при разбиении строки свойств на фрагменты.
        /// При формировании результирующего файла база расширяется за счет
        /// создания реплик исходного файла.
        /// </summary>
        /// <param name="from">путь к файлу исходной базы данных  </param>
        /// <param name="to">путь к файлу результирующей базы данных </param>
        /// <param name="count_replic">число реплик</param>
        /// <param name="len_fragment">длина фрагмента</param>
        public static bool Convert(string from, string to, string status,
            int count_replic, int len_fragment )
        {
            bool result = false;
            reader = File.OpenText(from);
            writer = File.CreateText(to);
            try
            {
                string properties;
                //form properties
                properties = FormProperties(from);

                //init long enumeration
                LongEnumScale.Init(properties, len_fragment);

                //converting data base
               
                //first two records
                writer.WriteLine(properties);
                writer.WriteLine(len_fragment);

                //read Source records and write destination
                reader = File.OpenText(from);
                string rec_source;
                LongEnumScale rec_dest;
                int n;
                string item;
                int k;
                if (status != "Replica") k = 1; else k = count_replic;
                while (!reader.EndOfStream)
                {
                    rec_source = reader.ReadLine();
                    rec_source = rec_source.TrimEnd(',', ' ');
                    rec_dest = new LongEnumScale(rec_source);
                    n = rec_dest.dig_enum.Length;
                    item = "";
                    for (int i = 0; i < n - 1; i++)
                    {
                        item += rec_dest.dig_enum[i].ToString() + ",";
                    }
                    item += rec_dest.dig_enum[n - 1].ToString();

                    for (int j = 0; j < k; j++)
                    {
                        writer.WriteLine(item);
                       // db_len++;
                    }

                }
                result = true;
            }
            finally 
            {
                reader.Close();
                writer.Close();
            }
            return result;
           
        }
     
        /// <summary>
        /// Быстрая параллельная сортировка
        /// лучший метод сортировки больших массивов,
        /// сочетая ограниченный параллелизм и
        /// быструю сортировку
        /// Вызов рекурсивной версии
        /// </summary>
        static void Quick_Par(Dig_ar[] ar)
        {
            sort_mas = ar;
            int N = ar.Length;
            SortQuickPar(0, N - 1);
        }
        /// <summary>
        /// Быстрая параллельная сортировка
        /// Рекурсивная версия
        /// </summary>
        /// <param name="start">индекс начала сортируемого массива</param>
        /// <param name="finish">индекс конца сортируемого массива</param>
        static void SortQuickPar(int start, int finish)
        {

            if (finish - start > 0)
            {
                int m = finish - start + 1;
                Dig_ar cand, temp;
                int l = start, r = finish;
                cand = sort_mas[(r + l) / 2];
                while (l <= r)
                {
                    while (sort_mas[l].CompareTo(cand) == -1) l++;
                    while (sort_mas[r].CompareTo(cand) == 1) r--;
                    if (l <= r)
                    {
                        temp = sort_mas[l];
                        sort_mas[l] = sort_mas[r];
                        sort_mas[r] = temp;
                        l++; r--;
                    }
                }
                if (m > Limit)
                {   //сортировка двух частей массива в разных потоках
                    Thread t1 = new Thread(() => SortQuickPar(start, r));
                    Thread t2 = new Thread(() => SortQuickPar(l, finish));
                    t1.Start();
                    t2.Start();
                    t1.Join();
                    t2.Join();

                }
                else
                {   //сортировка массива в одном потоке
                    SortQuickSeq(start, r);
                    SortQuickSeq(l, finish);
                }
            }
        }
       
        /// <summary>
        /// Последовательный рекурсивный алгоритм быстрой сортировки
        /// используется для массивов размера меньше Limit
        /// </summary>
        /// <param name="start">индекс начала сортируемого массива</param>
        /// <param name="finish">индекс конца сортируемого массива</param>
        static void SortQuickSeq(int start, int finish)
        {
            if (finish - start > 0)
            {
                Dig_ar cand, temp;
                int l = start, r = finish;
                cand = sort_mas[(r + l) / 2];
                while (l <= r)
                {
                    while (sort_mas[l].CompareTo(cand) == -1) l++;
                    while (sort_mas[r].CompareTo(cand) == 1) r--;
                    if (l <= r)
                    {
                        temp = sort_mas[l];
                        sort_mas[l] = sort_mas[r];
                        sort_mas[r] = temp;
                        l++; r--;
                    }
                }
                SortQuickSeq(start, r);
                SortQuickSeq(l, finish);
            }
        }

        static string FormProperties(string from)
        {
            string props = "";
            List<string> properties = new List<string>();
            StreamReader reader = File.OpenText(from);
            string rec;
            string[] items;
            int n;
            while (!reader.EndOfStream)
            {
                rec = reader.ReadLine();
                rec = rec.TrimEnd(',', ' ');
                items = rec.Split(',', ' ');
                n = items.Length;
                for (int i = 0; i < n; i++)
                    if (!properties.Contains(items[i]))
                        properties.Add(items[i]);
            }
            reader.Close();
            n = properties.Count;
            for (int i = 0; i < n - 1; i++)
                props += properties[i] + ",";
            props += properties[n - 1];
            return props;
        }
   
        struct Dig_ar : IComparable
        {
            long[] ar;
            
            public Dig_ar(long[] ar)
            {
                int n = ar.Length;
                this.ar = new long[n];
                for (int i = 0; i < n; i++)
                    this.ar[i] = ar[i];
            }
            public override string ToString()
            {
                int n = ar.Length;
                string res = "";
                for (int i = 0; i < n - 1; i++)
                   res += ar[i].ToString() + ",";
                res += ar[n - 1].ToString();
                return res;
            }
            public long[] Get_ar()
            { return ar; }

            public int CompareTo(object oitem)
            {
                int result = 0;
                Dig_ar dig_item = (Dig_ar)oitem;
                long[] item = dig_item.Get_ar();
                int i = 0;
                int n = ar.Length;
                while (i < n && this.ar[i] == item[i]) i++;
                if (i == n) result = 0;
                else
                    if (this.ar[i] < item[i]) result = -1;
                else result = 1;
                return result;
            }
        }
    }
}
    
    
