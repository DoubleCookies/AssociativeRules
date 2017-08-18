using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConAprioriLong
{
    /// <summary>
    /// набор (множество) бинарных свойств объекта
    /// Роль объекта может играть "пациент", "корзина покупателя"
    /// Свойствами могут быть: 
    /// результаты различных анализов,
    /// товары, положенные в корзину
    /// </summary>
    public class Set
    {
        LongEnumScale set_prop;     //свойства объекта
        double support;             //поддержка (частота) набора в базе данных
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bp">набор свойств объекта</param>
        public Set(LongEnumScale bp)
        {
            set_prop = bp;
        }
        /// <summary>
        /// Доступ к свойствам
        /// </summary>
        public LongEnumScale Set_prop { get { return set_prop; } }
        public double Sup { get { return support; } set { support = value; } }
        public override string ToString()
        {
            return set_prop.ToString() + " частота = " + support.ToString();
        }
        /// <summary>
        /// содержит ли множество текущий набор
        /// </summary>
        /// <param name="lset">множество наборов</param>
        /// <returns>true, если текущий набор содержится в множестве</returns>
        public bool ContainsIn(List<Set> lset)
        {

            foreach (Set item in lset)
                if (this.Set_prop == item.Set_prop) return true;
            return false;
        }

    }
}
