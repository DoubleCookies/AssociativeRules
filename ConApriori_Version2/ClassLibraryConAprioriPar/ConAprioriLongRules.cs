using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConAprioriPar
{
    public class ConAprioriLongRules
    {
        //поля класса

        List<Rule> rules;   //все правила
        List<Rule> rules_current;   //правила предыдущего шага
        List<Rule> current; // правила текущего шага
        Random rnd = new Random();
        List<LongEnumScale> often_set_one;     //множество частых примеров длины 1 
        List<LongEnumScale> often_set_current;     //множество текущих частых примеров 
        List<LongEnumScale> often_set;     //множество частых примеров                             
                                           //  List<LongEnumScale> candX; //список  посылок правил
        double support_min;
        double confidence_min;
        int iteration;      //число итераций при построении правил длины k 
        int nos1;        //число единичных частых наборов
                         
        //Конструкторы класса
        public ConAprioriLongRules()
        {

        }
        public double Support_min
        {
            get { return support_min; }
            set { support_min = value; }
        }
        public double Confidence_min
        {
            get { return confidence_min; }
            set { confidence_min = value; }
        }

        //Доступ к закрытым полям
        public List<Rule> Rules { get { return rules; } }

        /// <summary>
        /// Сохранение правил в файле
        /// </summary>
        /// <param name="name">имя файла</param>
        public void SaveRulesToFile(string name)
        {
            StreamWriter writer = File.CreateText(name);
            foreach (Rule item in Rules)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
        }

        /// <summary>
        /// Равенство массивов
        /// Массивы равны, если равны их элементы 
        /// </summary>
        /// <param name="ar">первый массив</param>
        /// <param name="ar2">второй массив</param>
        /// <returns>true, если ar = ar2</returns>
        public bool Equal_Arrs(long[] ar, long[] ar2)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != ar2[i]) return false;
            return true;
        }
        /// <summary>
        /// массив, у которого все элементы равны нулю
        /// </summary>
        /// <param name="ar">массив</param>
        /// <returns>true, если все элементы равны нулю</returns>
        public bool Zero_Arr(long[] ar)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != 0) return false;
            return true;
        }

        /// <summary>
        /// Множество частых примеров длины 1 
        /// </summary>
        public void Create_OBC_1()
        {
            LongEnumScale ls;
            often_set_one = new List<LongEnumScale>();
            often_set_current = new List<LongEnumScale>();
            often_set = new List<LongEnumScale>();
            nos1 = 0;
            double sup = 0;
            foreach (string name in LongEnumScale.names)
            {
                ls = new LongEnumScale(name);
                sup = Apriori_DB.Support(ls.dig_enum);
                ls.Sup = sup;
                if (sup > Support_min)
                {
                    often_set_one.Add(ls);
                    often_set_current.Add(ls);
                    often_set.Add(ls);
                }
            }
            nos1 = often_set_one.Count;
        }
        /// <summary>
        /// Множество частых примеров длины 2
        /// На основе множества частых примеров длины 1,
        /// представленном множеством often_set_one
        /// </summary>
        public void Create_OBC_2()
        {
            List<LongEnumScale> obc = new List<LongEnumScale>();   //множество примеров длины 2
            LongEnumScale cand;
            LongEnumScale cand_set;
            LongEnumScale item;
            double sup;
           
            for (int i = 0; i < nos1; i++)
            {
                cand = often_set_one[i];
                for (int j = i + 1; j < nos1; j++)
                {
                    item = often_set_one[j];
                    //создать 2-элементное множество
                    cand_set = new LongEnumScale(cand | item);
                    sup = Apriori_DB.Support(cand_set.dig_enum);
                    cand_set.Sup = sup;
                    if (sup > Support_min) obc.Add(cand_set);
                }
            }
            often_set_current = obc;
        }

        /// <summary>
        /// проверка свойства Apriori
        /// все k-1 подмножества объединенного множества set и cand
        /// частые и содержатся в множестве often_set_current
        /// </summary>
        /// <param name="set">частое множество</param>
        /// <param name="cand">единичное частое множество</param>
        /// <returns>true, если cand подходящий кандидат на расширение</returns>
        bool CheckApriori(LongEnumScale set, LongEnumScale cand)
        {
            if (!Zero_Arr(set & cand)) return false;
            bool result = true;
            string set_str, cand_str;
            set_str = set.item_enum;
            cand_str = cand.item_enum;
            string[] set_ar = set_str.Split(',', ' ');
            int n = set_ar.Length;
            string item = "", temp = "";
            LongEnumScale l_item;
            for (int i = 0; i < n; i++)
            {
                temp = set_ar[i];
                set_ar[i] = cand_str;
                item = string.Join(",", set_ar);
                l_item = new LongEnumScale(item);
                if (!Contains(ref l_item, often_set_current)) return false;
                set_ar[i] = temp;
            }
            return result;
        }
        /// <summary>
        /// Множество частых примеров длины K
        /// На основе множества частых примеров длины K -1,
        /// представленном множеством often_set_current
        /// </summary>
        public void Create_OBC_K()
        {
            List<LongEnumScale> obc = new List<LongEnumScale>();   //множество примеров длины K
            LongEnumScale cand;
            LongEnumScale cand_set;
            double sup;
            foreach (LongEnumScale set in often_set_current)
                foreach (LongEnumScale item in often_set_one)
                {
                    if (item.Max_number > set.Max_number)
                    //избегаем повторов в формировании множества                       
                    {
                        cand = item;
                        //свойство, заданное кодом, не содержится в set
                        //создать к-элементное множество
                        cand_set = new LongEnumScale(cand | set);
                        //если новый набор и выполняется свойство Apriori
                        if (!cand_set.ContainsIn(obc) && CheckApriori(set, cand))
                        {
                            sup = Apriori_DB.Support(cand_set.dig_enum);
                            cand_set.Sup = sup;
                            if (sup > Support_min) obc.Add(cand_set);
                        }
                    }
                }

            often_set_current = obc;
        }




        /// <summary>
        /// создание правил одиночной длины
        /// x => y, где x и y - свойства
        /// </summary>
        public void Create_Rules_1()
        {
            LongEnumScale set, set1, set2;
            double sup;
            rules = new List<Rule>();
            current = new List<Rule>();
            Create_OBC_1();

            for (int i = 0; i < nos1; i++)
            {
                set1 = often_set_one[i];

                for (int j = i + 1; j < nos1; j++)
                {
                    set2 = often_set_one[j];
                    set = new LongEnumScale(set1 | set2);
                    sup = Apriori_DB.Support(set.dig_enum);
                    set.Sup = sup;
                    if (sup > Support_min)
                    {
                        CreateRule(set, set1, set2);
                        CreateRule(set, set2, set1);
                    }
                }
            }
        }

        /// <summary>
        /// создание правила
        /// достоверные правила включаются в список правил
        /// </summary>
        /// <param name="set">набор, объединяющий посылку и заключение</param>
        /// <param name="set1">посылка правила</param>
        /// <param name="set2">заключение правила</param>
        void CreateRule(LongEnumScale set, LongEnumScale set1,
            LongEnumScale set2)
        {
            Rule rule = new Rule(set1, set2);
            double sup = set.Sup,
                sup1 = set1.Sup, sup2 = set2.Sup;
            rule.Support = sup;
            rule.Сonfidence = sup / sup1;
            rule.SupX = sup1;
            rule.SupY = sup2;
            rule.Lift = rule.Сonfidence / rule.SupY;
            if (rule.Support > Support_min &&
                rule.Сonfidence > Confidence_min &&
                !rule.ContainsIn(rules))
            {
                current.Add(rule);
                rules.Add(rule);
            }
        }


        /// <summary>
        /// создание правил  длины K
        /// X => Y, 
        /// </summary>
        public bool Create_Rules_K()
        {
            LongEnumScale X, Y;
            LongEnumScale set, seti, cand_set;
            double sup;
            List<LongEnumScale> rule_set = new List<LongEnumScale>();
            rules_current = new List<Rule>();
            // candX = new List<LongEnumScale>();
            foreach (Rule rule in current)
                rules_current.Add(rule);
            current = new List<Rule>();
            if (iteration == 2)
                Create_OBC_2();
            else Create_OBC_K();
            //Create_OBC_K();
            foreach (Rule rule in rules_current)
            {//цикл по правилам, построенным на предыдущем шаге
                X = rule.X;
                Y = rule.Y;
                set = new LongEnumScale(X | Y);

                //Расширение  правила
                foreach (LongEnumScale item in often_set_one)
                {//цикл по единичным частым наборам для расширения правил
                 //формируем  set(X, Y, item)

                    if (CheckApriori(set, item))
                    {
                        seti = new LongEnumScale(set | item);    //расширенный набор
                        sup = Apriori_DB.Support(seti.dig_enum); // sup - поддержка 4-х новых правил
                        seti.Sup = sup;
                        if (sup > Support_min)  //если частый набор
                        {
                            //формируем правило X + cand => Y
                            cand_set = new LongEnumScale(X | item);
                            // candX.Add(cand_set);
                            if (cand_set.IsSubset(often_set_current))
                            {//если посылка - частый набор
                                sup = Apriori_DB.Support(cand_set.dig_enum);
                                cand_set.Sup = sup;
                                CreateRule(seti, cand_set, Y);
                                //формирование правила Y => X + cand
                                CreateRule(seti, Y, cand_set);
                            }
                            //формирование правила X => Y + cand
                            cand_set = new LongEnumScale(Y | item);
                            //   candX.Add(cand_set);
                            if (cand_set.IsSubset(often_set_current))
                            {
                                sup = Apriori_DB.Support(cand_set.dig_enum);
                                cand_set.Sup = sup;
                                CreateRule(seti, X, cand_set);
                                //формирование правила Y + cand => X
                                CreateRule(seti, cand_set, X);
                            }
                            //формируем правило X + Y => cand
                                sup = rule.Support;
                                set.Sup = sup;
                                CreateRule(seti, set, item);
                                //формирование правила  cand => X + Y
                                CreateRule(seti, item, set);
                        }
                    }
                }
            }

            SupplementRules(); //Добавление правил в rules_current
                               
            if (current.Count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Построение дополнительных правил,
        /// которые не генерируются на основе уже созданных правил
        /// Это правила с посылкой длины K и единичным заключением.
        /// Правила строятся на основе построенного множества 
        /// частых примеров длины k
        /// </summary>
        void SupplementRules()
        {
            int len = often_set_current.Count;
            LongEnumScale cand;     //посылка правила
            LongEnumScale set;
            for (int i = 0; i < len; i++)
            {
                cand = often_set_current[i];
                //пытаемся строить правила с заданной посылкой 
                //и единичным заключением
                foreach (LongEnumScale item in often_set_one)
                {
                    //единичный набор не содержится в посылке
                    if (CheckApriori(cand, item) && NewRule(cand, item))
                    // if (CheckApriori(cand, item) )
                    {
                        set = new LongEnumScale(cand | item);
                        set.Sup = Apriori_DB.Support(set.dig_enum);
                        CreateRule(set, cand, item);
                    }
                }
            }
        }
        bool NewRule(LongEnumScale set, LongEnumScale cand)
        {
            Rule rule = new Rule(set, cand);
            return !rule.ContainsIn(rules);
        }

        /// <summary>
        /// Содержит ли  set - множество объектов set  - элемент с заданными свойствами
        /// </summary>
        /// <param name="cand">свойства</param>
        /// <param name="set">множество</param>
        /// <returns>true, если в множестве set есть элемент с указанными свойствами</returns>
        bool Contains(ref LongEnumScale cand_set, List<LongEnumScale> set)
        {
            foreach (LongEnumScale item in set)
                if (Equal_Arrs(item.dig_enum,
                    cand_set.dig_enum))
                { cand_set = item; return true; }
            return false;
        }
        /// <summary>
        /// Содержит ли list - множество правил - заданное правило rule 
        /// </summary>
        /// <param name="rule"> правило</param>
        /// <param name="list">множество правил</param>
        /// <returns>true, если правило уже есть в list</returns>
        bool Exist(Rule rule, List<Rule> list)
        {
            foreach (Rule item in list)
                if (Equal_Arrs(rule.X.dig_enum, item.X.dig_enum) &&
                   Equal_Arrs(rule.Y.dig_enum, item.Y.dig_enum))
                    return true;
            return false;
        }


        /// <summary>
        /// Создание списка правил 
        /// Основной метод
        /// </summary>
        public void Create_Rules()
        {
            iteration = 1;
            Create_Rules_1();
            bool exist_new_rules = true;
            while (exist_new_rules)
            {
                iteration++;
                exist_new_rules = Create_Rules_K();
            }
        }
    }
}
