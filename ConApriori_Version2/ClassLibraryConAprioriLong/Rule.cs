using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConAprioriLong
{
    /// <summary>
    /// ассоциативное правило X => Y
    /// X, Y - наборы свойств - объекты класса Set
    /// </summary>
    public class Rule
    {
        public LongEnumScale X;      //посылка правила
        public LongEnumScale Y;      //заключение правила
        double support;     // частота правила 
        double confidence;     //достоверность правила
        double supX;        //частота посылки
        double supY;        //частота заключения
        double lift;        //лифт правила

        /// <summary>
        /// конструктор правила X => Y
        /// </summary>
        /// <param name="X">посылка</param>
        /// <param name="Y">заключение</param>
        public Rule(LongEnumScale X, LongEnumScale Y)
        {
            this.X = X;
            this.Y = Y;
        }
        /// <summary>
        /// доступ к свойствам
        /// </summary>
        public double Сonfidence { get { return confidence; } set { confidence = value; } }
        public double Support { get { return support; } set { support = value; } }
        public double SupX { get { return supX; } set { supX = value; } }
        public double SupY { get { return supY; } set { supY = value; } }
        public double Lift { get { return lift; } set { lift = value; } }

        public override string ToString()
        {
            string result = X.ToString() + " => " +
                Y.ToString() +
            " частота =  " + Support.ToString("F2") +
            " достоверность = " + confidence.ToString("F2") +
            " лифт = " + Lift.ToString("F2");
            return result;
        }
        public static bool operator ==(Rule r1, Rule r2)
        {
            return r1.X == r2.X &&
                r1.Y == r2.Y;
        }
        public static bool operator !=(Rule r1, Rule r2)
        {
            return !(r1 == r2);
        }
        public override bool Equals(object obj)
        {
            Rule r;
            r = obj as Rule;
            return r != null && r == this;
        }
        public override int GetHashCode()
        {
            return (int)(this.Support * 1000);
        }
        /// <summary>
        /// содержит ли множество текущее правило
        /// </summary>
        /// <param name="rset">множество правил</param>
        /// <returns>true, если текущее правило содержится в множестве</returns>
        public bool ContainsIn(List<Rule> rset)
        {

            foreach (Rule item in rset)
                if (this == item) return true;
            return false;
        }
    }
/*
/// <summary>
/// ассоциативное правило X => Y
/// X, Y - наборы свойств - объекты класса Set
/// </summary>
public class Rule_old
{
    public Set X;      //посылка правила
    public Set Y;      //заключение правила
    double support;     // частота правила 
    double confidence;     //достоверность правила
    double supX;        //частота посылки
    double supY;        //частота заключения
    double lift;        //лифт правила

    /// <summary>
    /// конструктор правила X => Y
    /// </summary>
    /// <param name="X">посылка</param>
    /// <param name="Y">заключение</param>
    public Rule(Set X, Set Y)
    {
        this.X = X;
        this.Y = Y;
    }
    /// <summary>
    /// доступ к свойствам
    /// </summary>
    public double Сonfidence { get { return confidence; } set { confidence = value; } }
    public double Support { get { return support; } set { support = value; } }
    public double SupX { get { return supX; } set { supX = value; } }
    public double SupY { get { return supY; } set { supY = value; } }
    public double Lift { get { return lift; } set { lift = value; } }

    public override string ToString()
    {
        string result = X.Set_prop.ToString() + " => " +
            Y.Set_prop.ToString() +
        " частота =  " + Support.ToString("F2") +
        " достоверность = " + confidence.ToString("F2") +
        " лифт = " + Lift.ToString("F2");
        return result;
    }
    public static bool operator ==(Rule r1, Rule r2)
    {
        return r1.X.Set_prop == r2.X.Set_prop &&
            r1.Y.Set_prop == r2.Y.Set_prop;
    }
    public static bool operator !=(Rule r1, Rule r2)
    {
        return !(r1 == r2);
    }
    public override bool Equals(object obj)
    {
        Rule r;
        r = obj as Rule;
        return r != null && r == this;
    }
    public override int GetHashCode()
    {
        return (int)(this.Support * 1000);
    }
    /// <summary>
    /// содержит ли множество текущее правило
    /// </summary>
    /// <param name="rset">множество правил</param>
    /// <returns>true, если текущее правило содержится в множестве</returns>
    public bool ContainsIn(List<Rule> rset)
    {

        foreach (Rule item in rset)
            if (this == item) return true;
        return false;
    }*/
}
