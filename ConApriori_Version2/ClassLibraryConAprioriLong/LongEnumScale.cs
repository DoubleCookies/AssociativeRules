using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConAprioriLong
{
    /// <summary>
    /// Длинное перечисление, представленное шкалой
    /// Перечисление задается строкой в формате csv,
    /// задающей M возможных свойств объектов. 
    /// Свойства разбиваются на фрагменты заданной длины len
    /// Число фрагментов - N 
    /// Длина последнего фрагмента может быть меньше или равна len
    /// В каждом j-м фрагменте элемент перечисления с номером k
    /// отображается (как в шкалах) в целое число 2 в степени k - 1
    /// Внешнее представление объектов перечисления - строка текста,
    /// перечисляющая свойства данного объекта.
    /// Внутреннее представление объекта - N целых чисел 
    /// по числу фрагментов перечисления.
    /// </summary>
    public class LongEnumScale
    {
        //Статическая часть перечисления
        //Вычисляется один раз при запуске метода Init,
        //который должен быть вызван до начала работы с объектами перечисления
        static string long_enum;       //перечисление всех свойств объектов
        public static string[] names;  //массив имен свойств, входящих в long_enum
        public static int len;         //длина сегмента свойств 
        public static Dictionary<string, int> dict;
        public static int N;              //число фрагментов размер массива dig_enum
        public static int M;            //число свойств

        /// <summary>
        /// Инициализация перечисления
        /// Метод должен быть вызван до создания объектов перечисления
        /// </summary>
        /// <param name="longenum">csv строка, задающая перечисление</param>
        /// <param name="len_part">длина фрагмента, должна быть меньше 64</param>
        public static void Init(string longenum, int len_part)
        {
            long_enum = longenum;
            len = len_part;
            names = long_enum.Split(',', ' ');
            M = names.Length;
            int m, k;

            m = M / len;
            k = M % len;
            N = k == 0 ? m : m + 1;

            dict = new Dictionary<string, int>();

            for (int i = 0; i < M; i++)
                dict.Add(names[i], i);
        }
        //свойства объекта перечисления
        protected string item_enum;   //свойства объекта- внешнее представление
        public long[] dig_enum;   //внутреннее представление свойств, заданное шкалой
        int max_number;         //номер максимального свойства объекта
        double support;             //поддержка (частота) набора в базе данных 

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public LongEnumScale() { }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="item_enum">
        /// перечисление свойств объекта
        /// </param>
        public LongEnumScale(string item_enum)
        {
            this.item_enum = item_enum;
            dig_enum = new long[N];
            string[] item_names = item_enum.Split(',', ' ');
            int row, column;
            int k;
            max_number = 0;
            foreach (string item in item_names)
            {
                k = dict[item];
                row = k / len;
                column = k % len;
                dig_enum[row] += 1L << column;
                if (k > max_number)
                    max_number = k;
            }
        }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="dig_enum">
        /// внутреннее представление свойств объекта
        /// набором чисел
        /// </param>
        public LongEnumScale(long[] dig_enum)
        {
            this.dig_enum = dig_enum;
            item_enum = this.ToString();
        }
        /// <summary>
        /// доступ к внешнему представлению
        /// </summary>
        public string Item_enum
        {
            get { return item_enum; }
        }
        /// <summary>
        /// доступ к максимальному номеру
        /// </summary>
        public int Max_number
        {
            get { return max_number; }
        }
        /// <summary>
        /// доступ к частоте набора
        /// </summary>
        public double Sup { get { return support; } set { support = value; } }
        /// <summary>
        /// переопределение метода ToString
        /// </summary>
        /// <returns>внешнее представление свойств объекта</returns>
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < N; i++)
                result += GetString(i);
          //  if (result.Length > 2)
                result = result.Remove(result.Length - 1);
           
            return result;
        }
        /// <summary>
        /// возвращает имена свойств i-го фрагмента,
        /// по внутреннему представлению
        /// </summary>
        /// <param name="i">номер фрагмента</param>
        /// <returns>имена свойств фрагмента</returns>
        string GetString(int i)
        {
            string res = "";
            long num = dig_enum[i];
            int k = 0;
            int ind = i * len;
            while (num != 0 && ind + k < M)
            {
                if (num % 2 != 0)
                    res += names[ind + k] + ",";
                num = num >> 1;
                k++;
            }
            return res;
        }
        /// <summary>
        /// побитовая операция ИЛИ (объединение множеств)
        /// для длинного перечисления
        /// </summary>
        /// <param name="num1">свойства первого объекта</param>
        /// <param name="num2">свойства второго объекта</param>
        /// <returns>объединение свойств</returns>
        public static long[] operator |(LongEnumScale num1,
             LongEnumScale num2)
        {

            int n = N;
            long[] dig_enum = new long[n];
            for (int i = 0; i < n; i++)
            {
                dig_enum[i] = num1.dig_enum[i] | num2.dig_enum[i];
            }

            return (dig_enum);
        }
        /// <summary>
        /// побитовая операция И (пересечение множеств)
        /// для длинного перечисления
        /// </summary>
        /// <param name="num1">свойства первого объекта</param>
        /// <param name="num2">свойства второго объекта</param>
        /// <returns>пересечение свойств</returns>
        public static long[] operator &(LongEnumScale num1, LongEnumScale num2)
        {
            int n = N;
            long[] dig_enum = new long[n];
            for (int i = 0; i < n; i++)
            {
                dig_enum[i] = num1.dig_enum[i] & num2.dig_enum[i];
            }
            return (dig_enum);
        }
        public static long[] operator ~(LongEnumScale num)
        {
            int n = N;
            long[] dig_enum = new long[n];
            for (int i = 0; i < n; i++)
            {
                dig_enum[i] = ~num.dig_enum[i];
            }
            return (dig_enum);
        }


        public static bool operator ==(LongEnumScale s1, LongEnumScale s2)
        {
            bool res = true;
            for (int i = 0; i < N; i++)
                res &= (s1.dig_enum[i] == s2.dig_enum[i]);
            return res;
        }
        public static bool operator !=(LongEnumScale s1, LongEnumScale s2)
        {

            return !(s1 == s2);
        }
        public override bool Equals(object obj)
        {
            LongEnumScale ls;
            ls = obj as LongEnumScale;
            return ls != null && ls == this;
        }
        public override int GetHashCode()
        {
            return (int)(dig_enum[0] % 100);
        }
        /// <summary>
        /// содержит ли множество текущее правило
        /// </summary>
        /// <param name="rset">множество правил</param>
        /// <returns>true, если текущее правило содержится в множестве</returns>
        public bool ContainsIn(List<LongEnumScale> rset)
        {

            foreach (LongEnumScale item in rset)
                if (this == item)
                {
                    this.Sup = item.Sup;
                    return true;
                }
            return false;
        }
    }
}
