using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConAprioriPar
{
    public static class Apriori_DB
    {
        public static List<long[]> db;  //база данных
        public static string db_name;   //путь к базе
        public static bool press;       //true, если база данных сжата 
        public static List<int> repeats;    //список частот записей базы данных
        public static int n;          //размер базы данных
        public static int press_n;      //число сжатых записей
        public static int group_count = 8; //число групп при распараллеливании базы данных
        public static int m_group;    //число элементов в группе, за исключением последней
        public static int[] counts; //массив для хранения временных сумм для Support
        public static int m;          //число свойств в перечислении Properties
        public static string properties; //название свойств (элементов, факторов)
        /// <summary>
        /// Чтение записей файла
        /// Первые две строки файла задают:
        /// описание всех свойств, 
        /// длину фрагмента свойств.
        /// Каждая последующая запись файла 
        /// представляет строку из N чисел в формате csv,
        /// где N - статическая переменная класса LongEnumScale,
        /// задающая число фрагментов, на которые разбивается строка свойств.
        /// Каждое число в строке задает шкалу в соответствующем фрагменте свойств.
        /// Пример. Пусть свойства разбиты на два фрагмента - две категории свойств
        /// тогда запись файла, представленная двумя числами:
        /// 6 (110 в двоичной записи), 11 (1011 в двоичной записи)
        /// означает, что 
        /// запись включает второе и третье свойство первой категории и 
        /// первое, второе и четвертое свойство во второй категории.
        /// Записи файла преобразуются в записи списка List <Set>
        /// </summary>       
        public static void Read_DB_Scale()
        {
            string rec = "";
            StreamReader reader = File.OpenText(db_name);
            properties = reader.ReadLine();
            string[] props = properties.Split(',', ' ');
            m = props.Length;       //число свойств
            int len_part = int.Parse(reader.ReadLine());
            LongEnumScale.Init(properties, len_part);            
            repeats = new List<int>();
            db = new List<long[]>();
            int count = 0;
            long[] l_enum;
            string[] str_enum;
            int item = 0;
            while (!reader.EndOfStream)
            {
                if (press)
                { //читаем частоту записи
                    rec = reader.ReadLine();
                    item = int.Parse(rec);
                    repeats.Add(item);
                }
                //читаем запись
                rec = reader.ReadLine();
                str_enum = rec.Split(',', ' ');
                int N_rec = str_enum.Length;
                l_enum = new long[LongEnumScale.N];
               
                for (int i = 0; i < N_rec; i++)
                    l_enum[i] = long.Parse(str_enum[i]);

                db.Add(l_enum);
                if (press)
                    n += item;   //общее число записей
                else
                    n++;
                count++;    //число сжатых записей
            }
            reader.Close();
            press_n = count;
            m_group = count / group_count;
        }
       
        /// <summary>
        /// Поддержка объекта в базе данных
        /// </summary>
        /// <param name="set">объект, для набора свойств которого
        /// вычисляется поддержка(частота появления в базе данных)  </param>
        /// <returns>частота появления набора </returns>
        public static double Support(long[] set)
        {
            double count = 0;
            counts = new int[group_count];
            Parallel.For(0, group_count, (i) => Body(i, set));
            for (int i = 0; i < group_count; i++)
                count += counts[i];
            return count / n;
        }

      static  void  Body(int i, long[] set)
        {
            long[] item;
            int rep = 0;
            int start_group = i * m_group;
            int finish_group = i < group_count - 1 ? start_group + m_group : press_n;

            for (int j = start_group; j < finish_group; j++)
            {
                item = db[j];
                rep = press? repeats[j] : 1;
                bool equal = true;
                for (int k = 0; k < LongEnumScale.N; k++)
                    if ((set[k] & item[k]) != set[k])
                    {
                        equal = false; break;
                    }
                if (equal)
                    counts[i] += rep;

            }
        }
    }
}
