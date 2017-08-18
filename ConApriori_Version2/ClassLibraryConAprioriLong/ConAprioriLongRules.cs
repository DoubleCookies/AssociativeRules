using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConAprioriLong
{
    public class ConAprioriLongRules
    {

        //поля класса
        int n;          //размер базы данных
        int m;          //число свойств в перечислении Properties
        string properties; //название свойств (элементов, факторов) 
        List<LongEnumScale> db;  //база данных
        List<Rule> rules;   //все правила
        List<Rule> rules_current;   //правила предыдущего шага
        List<Rule> current; // правила текущего шага
        Random rnd = new Random();
        List<LongEnumScale> often_set_one;     //множество частых примеров длины 1 
        List<LongEnumScale> often_sets_current;     //множество текущих частых примеров 
        List<LongEnumScale> often_basks;     //множество частых примеров                             
        List<LongEnumScale> candX; //список  посылок правил
        double support_min;
        double confidence_min;
        string db_name;
        int nos1;        //число единичных частых наборов
       
        public List<double> list_obc1 = new List<double>(), list_obck = new List<double>(),
            list_rule1 = new List<double>(), list_rulek = new List<double>(),
            list_suppl = new List<double>(), list_support = new List<double>();

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
        public ConAprioriLongRules(int n, int m, List<LongEnumScale> db)
        {
            this.n = n;
            this.m = m;
            this.db = db;
        }
        public ConAprioriLongRules(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public ConAprioriLongRules(double support, double Сonfidence,
            string db_name, int m)
        {
            Support_min = support;
            Confidence_min = Сonfidence;
            this.db_name = db_name;
            this.m = m;
        }

        //Доступ к закрытым полям
        public List<Rule> Rules { get { return rules; } }
        public List<LongEnumScale> DB { get { return db; } }
        public string DB_name { set { db_name = value; } }
        public int N_records { set { n = value; } }
        public int M_properties { set { m = value; } }
        public string Properties { get { return properties; } }


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
        public void Read_DB_Scale()
        {
            string rec = "";
            StreamReader reader = File.OpenText(db_name);
            properties = reader.ReadLine();
            string[] props = properties.Split(',', ' ');
            m = props.Length;       //число свойств
            int len_part = int.Parse(reader.ReadLine());
            LongEnumScale.Init(properties, len_part);
            LongEnumScale res;

            db = new List<LongEnumScale>();
            int count = 0;
            long[] l_enum;
            string[] str_enum;
            while (!reader.EndOfStream)
            {
                rec = reader.ReadLine();
                str_enum = rec.Split(',', ' ');
                int N_rec = str_enum.Length;

                l_enum = new long[LongEnumScale.N];
                if (N_rec != LongEnumScale.N) throw
                        new FileLoadException("число чисел в записи файла не соответствует числу отрезков разбиения свойств! ");
                for (int i = 0; i < N_rec; i++)
                    l_enum[i] = long.Parse(str_enum[i]);

                res = new LongEnumScale(l_enum);

                db.Add(res);
                count++;
            }
            reader.Close();
            n = count;      //число записей
        }

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


        public bool Equal_Arrs(long[] ar, long[] ar2)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != ar2[i]) return false;
            return true;
        }
        public bool Zero_Arr(long[] ar)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != 0) return false;
            return true;
        }
        /// <summary>
        /// Поддержка объекта в базе данных
        /// </summary>
        /// <param name="set">объект, для набора свойств которого
        /// вычисляется поддержка(частота появления в базе данных)  </param>
        /// <returns>частота появления набора </returns>
        public double Support(LongEnumScale set)
        {
            
            DateTime start, finish;
            start = DateTime.Now;
            double count = 0;
            foreach (LongEnumScale item in db)
            {
                if (Equal_Arrs(set & item,
                    set.dig_enum))
                    count++;
            }
            finish = DateTime.Now;
            list_support.Add((finish - start).TotalMilliseconds);
            return count / n;
           
            }
       
        /// <summary>
        /// Множество частых примеров длины  
        /// </summary>
        public void Create_OBC_1()
        {
            //time profile
            DateTime start, finish;
            start = DateTime.Now;
            LongEnumScale ls;
            often_set_one = new List<LongEnumScale>();
            often_sets_current = new List<LongEnumScale>();
            often_basks = new List<LongEnumScale>();
            nos1 = 0;
            double sup = 0;
            foreach (string name in LongEnumScale.names)
            {
                ls = new LongEnumScale(name);
                sup = Support(ls);
                ls.Sup = sup; 
                if (sup > Support_min)
                {
                    often_set_one.Add(ls);
                    often_sets_current.Add(ls);
                    often_basks.Add(ls);
                    nos1++;
                }
            }
            //time profile
            finish = DateTime.Now;
            list_obc1.Add((finish - start).TotalMilliseconds);
        }
        
        /// <summary>
        /// Множество частых примеров длины K
        /// На основе множества частых примеров длины K -1,
        /// представленном множеством often_sets_current
        /// </summary>
        public void Create_OBC_K()
        {
            //time profile
               DateTime start, finish;
              start = DateTime.Now;

            List<LongEnumScale> obc = new List<LongEnumScale>();   //множество примеров длины K
            LongEnumScale cand;
            LongEnumScale cand_bask;
            foreach (LongEnumScale bask in often_sets_current)
                foreach (LongEnumScale item in often_set_one)
                {
                    if (item.Max_number > bask.Max_number)
                    //избегаем повторов в формировании множества                       
                    {
                        cand = item;
                        //свойство, заданное кодом, не содержится в bask
                        if (Zero_Arr(bask & cand))
                        {
                            //создать к-элементное множество
                            //cand = cand | bask.Bask_prop;
                            cand_bask = new LongEnumScale(cand | bask);
                            double sup = Support(cand_bask);
                            cand_bask.Sup = sup;
                            if (sup > Support_min)
                            {
                                obc.Add(cand_bask);
                            }
                        }
                    }
                }
            often_sets_current = obc;

            //time profile
              finish = DateTime.Now;
              list_obck.Add((finish - start).TotalMilliseconds);
        }
  



/// <summary>
/// создание правил одиночной длины
/// x => y, где x и y - свойства
/// </summary>
public void Create_Rules_1()
        {
            //time profile
            DateTime start, finish;
            start = DateTime.Now;
            LongEnumScale set, set1, set2;
            double sup;
            rules = new List<Rule>();
            current = new List<Rule>();
            //long code1, code2;
            Create_OBC_1();
          
                for (int i = 0; i < nos1; i++)
                {
                    set1 = often_set_one[i];

                    for (int j = i + 1; j < nos1; j++)
                    {
                        set2 = often_set_one[j];
                        set = new  LongEnumScale(set1 | set2);
                        sup = Support(set);
                        set.Sup = sup;
                        if (sup > Support_min)
                        {
                            CreateRule(set, set1, set2);
                            CreateRule(set, set2, set1);
                        }
                    }
                }
                
                //time profile
                finish = DateTime.Now;
            list_rule1.Add((finish - start).TotalMilliseconds);
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
            if (rule.Сonfidence > Confidence_min &&
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
            //time profile
            DateTime start, finish;
            start = DateTime.Now;
            LongEnumScale X, Y;
            LongEnumScale set, cand_set;
            double sup;
            List<LongEnumScale> rule_set = new List<LongEnumScale>();
            rules_current = new List<Rule>();
            candX = new List<LongEnumScale>();
            foreach (Rule rule in current)
                rules_current.Add(rule);
            current = new List<Rule>();
            Create_OBC_K();
            foreach (Rule rule in rules_current)
            {//цикл по правилам, построенным на предыдущем шаге
                X = rule.X;
                Y = rule.Y;
                set = new LongEnumScale(X | Y);
                if (!set.ContainsIn(rule_set))  //если набор правила уникален
                {
                    rule_set.Add(set);
                    //Расширение  правила
                    foreach (LongEnumScale item in often_set_one)
                    {//цикл по единичным частым наборам для расширения правил
                        //формируем  set(X, Y, item)
                        if (!Equal_Arrs(item & X, item.dig_enum) &&
                    !Equal_Arrs(item & Y, item.dig_enum))   //item не содержится ни в X, ни в Y
                        {
                            set = new LongEnumScale(set | item);    //расширенный набор
                            sup = Support(set); // sup - поддержка 4-х новых правил
                            set.Sup = sup;
                            if (sup > Support_min)  //если частый набор
                            {
                                //формируем правило X + cand => Y
                                cand_set = new LongEnumScale(X | item);
                                candX.Add(cand_set);
                                if (cand_set.ContainsIn(often_sets_current))
                                {//если посылка - частый набор
                                    CreateRule(set, cand_set, Y);
                                    //формирование правила Y => X + cand
                                    CreateRule(set, Y, cand_set);
                                }
                                //формирование правила X => Y + cand
                                cand_set = new LongEnumScale(Y | item);
                                candX.Add(cand_set);
                                if (cand_set.ContainsIn(often_sets_current))
                                {
                                    CreateRule(set, X, cand_set);
                                    //формирование правила Y + cand => X
                                    CreateRule(set, cand_set, X);
                                }
                            }
                        }
                    }
                }
            }
            SupplementRules(); //Добавление правил в rules_current
            //time profile
            finish = DateTime.Now;
            list_rulek.Add((finish - start).TotalMilliseconds);
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
            //time profile
            DateTime start, finish;
            start = DateTime.Now;

            int len = often_sets_current.Count;
            
            LongEnumScale cand;     //посылка правила

            LongEnumScale set;
           // double sup;
            for (int i = 0; i < len; i++)
            {
                cand = often_sets_current[i];
                //если новая посылка
                if (!cand.ContainsIn(candX))
                {
                    //пытаемся строить правила с заданной посылкой 
                    //и единичным заключением
                    foreach (LongEnumScale item in often_set_one)
                    {
                        //единичный набор не содержится в посылке
                        if (Zero_Arr(item & cand))
                        {
                            set = new LongEnumScale(cand | item);
                            set.Sup = Support(set);
                            CreateRule(set, cand, item);
                           
                        }
                    }
                }
            }
            //time profile
            finish = DateTime.Now;
            list_suppl.Add((finish - start).TotalMilliseconds);
        }

        /// <summary>
        /// Построение дополнительных правил,
        /// которые не генерируются на основе уже созданных правил
        /// Это правила с посылкой длины K и единичным заключением.        
        /// </summary>
        /// <param name = "X"> посылка правила</param> 
        void SupplementRules_old(LongEnumScale X)
        {
            //time profile
            DateTime start, finish;
            start = DateTime.Now;
            LongEnumScale set;
            double sup;
            //пытаемся строить правила с заданной посылкой 
            //и единичным заключением
            foreach (LongEnumScale item in often_set_one)
            {
                if (!Equal_Arrs(item & X, item.dig_enum))
                {
                    set = new LongEnumScale(X | item);
                    sup = Support(set);
                    set.Sup = sup; 
                    CreateRule(set, X, item);
                }
            }
            //time profile
            finish = DateTime.Now;
            list_suppl.Add((finish - start).TotalMilliseconds);
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
            Create_Rules_1();
            bool exist_new_rules = true;
            while (exist_new_rules)
            {
                exist_new_rules = Create_Rules_K();
            }
        }


      
    }
    /*
    public class ConAprioriLongRules_old
    {

        //поля класса
        int n;          //размер базы данных
        int m;          //число свойств в перечислении Properties
        string properties; //название свойств (элементов, факторов) 
        List<Set> db;  //база данных
        List<Rule> rules;   //все правила
        List<Rule> rules_current;   //правила предыдущего шага
        List<Rule> current; // правила текущего шага
        Random rnd = new Random();
        List<Set> often_set_one;     //множество частых примеров длины 1 

        List<Set> candX; //список  посылок правил
        double support_min;
        double confidence_min;
        string db_name;
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
        public ConAprioriLongRules(int n, int m, List<Set> db)
        {
            this.n = n;
            this.m = m;
            this.db = db;
        }
        public ConAprioriLongRules(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public ConAprioriLongRules(double support, double Сonfidence,
            string db_name, int m)
        {
            Support_min = support;
            Confidence_min = Сonfidence;
            this.db_name = db_name;
            this.m = m;
        }

        //Доступ к закрытым полям
        public List<Rule> Rules { get { return rules; } }
        public List<Set> DB { get { return db; } }
        public string DB_name { set { db_name = value; } }
        public int N_records { set { n = value; } }
        public int M_properties { set { m = value; } }
        public string Properties { get { return properties; } }


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
        public void Read_DB_Scale()
        {
            string rec = "";
            StreamReader reader = File.OpenText(db_name);
            properties = reader.ReadLine();
            string[] props = properties.Split(',', ' ');
            m = props.Length;       //число свойств
            int len_part = int.Parse(reader.ReadLine());
            LongEnumScale.Init(properties, len_part);
            LongEnumScale res;
            Set set;
            db = new List<Set>();
            int count = 0;
            long[] l_enum;
            string[] str_enum;
            while (!reader.EndOfStream)
            {
                rec = reader.ReadLine();
                str_enum = rec.Split(',', ' ');
                int N_rec = str_enum.Length;

                l_enum = new long[LongEnumScale.N];
                if (N_rec != LongEnumScale.N) throw
                        new FileLoadException("число чисел в записи файла не соответствует числу отрезков разбиения свойств! ");
                for (int i = 0; i < N_rec; i++)
                    l_enum[i] = long.Parse(str_enum[i]);

                res = new LongEnumScale(l_enum);
                set = new Set(res);
                db.Add(set);
                count++;
            }
            reader.Close();
            n = count;      //число записей
        }

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


        public bool Equal_Arrs(long[] ar, long[] ar2)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != ar2[i]) return false;
            return true;
        }
        public bool Zero_Arr(long[] ar)
        {
            int n = ar.Length;
            for (int i = 0; i < n; i++)
                if (ar[i] != 0) return false;
            return true;
        }
        /// <summary>
        /// Поддержка объекта в базе данных
        /// </summary>
        /// <param name="set">объект, для набора свойств которого
        /// вычисляется поддержка(частота появления в базе данных)  </param>
        /// <returns>частота появления набора </returns>
        public double Support(Set set)
        {
            double count = 0;
            foreach (Set item in db)
            {
                if (Equal_Arrs(set.Set_prop & item.Set_prop,
                    set.Set_prop.dig_enum))
                    count++;
            }
            return count / n;
        }

        /// <summary>
        /// Множество частых примеров длины  
        /// </summary>
        public void Create_OBC_1()
        {
            Set x_set;
            LongEnumScale ls;
            often_set_one = new List<Set>();
            nos1 = 0;
            foreach (string name in LongEnumScale.names)
            {
                ls = new LongEnumScale(name);
                x_set = new Set(ls);

                x_set.Sup = Support(x_set);
                if (x_set.Sup > Support_min)
                {
                    often_set_one.Add(x_set);
                    nos1++;
                }
            }
        }

        /// <summary>
        /// создание правил одиночной длины
        /// x => y, где x и y - свойства
        /// </summary>
        public void Create_Rules_1()
        {
            Set set, set1, set2;
            rules = new List<Rule>();
            current = new List<Rule>();
            Create_OBC_1();
            for (int i = 0; i < nos1; i++)
            {
                set1 = often_set_one[i];
                for (int j = i + 1; j < nos1; j++)
                {
                    set2 = often_set_one[j];
                    set = new Set(new LongEnumScale(set1.Set_prop | set2.Set_prop));

                    set.Sup = Support(set);
                    if (set.Sup > Support_min)
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
        void CreateRule(Set set, Set set1, Set set2)
        {
            Rule rule = new Rule(set1, set2);
            rule.Support = set.Sup;
            rule.Сonfidence = set.Sup / set1.Sup;
            rule.SupX = set1.Sup;
            rule.SupY = set2.Sup;
            rule.Lift = rule.Сonfidence / rule.SupY;
            if (rule.Сonfidence > Confidence_min &&
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
            Set X, Y;
            Set set, cand_set;

            List<Set> rule_set = new List<Set>();
            rules_current = new List<Rule>();
            candX = new List<Set>();
            foreach (Rule rule in current)
                rules_current.Add(rule);
            current = new List<Rule>();
            foreach (Rule rule in rules_current)
            {
                X = rule.X;
                Y = rule.Y;
                //Расширение  правила
                foreach (Set item in often_set_one)
                {
                    //формируем  set(X, Y, item)
                    if (!Equal_Arrs(item.Set_prop & X.Set_prop, item.Set_prop.dig_enum) &&
                !Equal_Arrs(item.Set_prop & Y.Set_prop, item.Set_prop.dig_enum))
                    {
                        //item не содержится ни в X, ни в Y
                        set = new Set(new LongEnumScale(X.Set_prop | Y.Set_prop));
                        set = new Set(new LongEnumScale(set.Set_prop | item.Set_prop));
                        set.Sup = Support(set); // sup - поддержка 4-х правил
                        if (set.Sup > Support_min)
                        {
                            //формируем правило X + cand => Y
                            cand_set = new Set(new LongEnumScale(X.Set_prop | item.Set_prop));
                            cand_set.Sup = Support(cand_set);
                            CreateRule(set, cand_set, Y);
                            //формирование правила Y => X + cand
                            CreateRule(set, Y, cand_set);
                            //добавление правил с заданной посылкой и единичным заключением
                            SupplementRules(cand_set);
                            //формирование правила X => Y + cand
                            cand_set = new Set(new LongEnumScale(Y.Set_prop | item.Set_prop));
                            cand_set.Sup = Support(cand_set);
                            CreateRule(set, X, cand_set);
                            //формирование правила Y + cand => X
                            CreateRule(set, cand_set, X);
                            SupplementRules(cand_set);
                        }
                    }
                }
            }
            if (current.Count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Построение дополнительных правил,
        /// которые не генерируются на основе уже созданных правил
        /// Это правила с посылкой длины K и единичным заключением.        
        /// </summary>
        /// <param name = "X"> посылка правила</param> 
        void SupplementRules(Set X)
        {
            Set set;
            //пытаемся строить правила с заданной посылкой 
            //и единичным заключением
            foreach (Set item in often_set_one)
            {
                if (!Equal_Arrs(item.Set_prop & X.Set_prop, item.Set_prop.dig_enum))
                {
                    set = new Set(new LongEnumScale(X.Set_prop | item.Set_prop));
                    set.Sup = Support(set);
                    CreateRule(set, X, item);
                }
            }
        }



        /// <summary>
        /// Содержит ли  set - множество объектов set  - элемент с заданными свойствами
        /// </summary>
        /// <param name="cand">свойства</param>
        /// <param name="set">множество</param>
        /// <returns>true, если в множестве set есть элемент с указанными свойствами</returns>
        bool Contains(ref Set cand_set, List<Set> set)
        {
            foreach (Set item in set)
                if (Equal_Arrs(item.Set_prop.dig_enum,
                    cand_set.Set_prop.dig_enum))
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
                if (Equal_Arrs(rule.X.Set_prop.dig_enum, item.X.Set_prop.dig_enum) &&
                   Equal_Arrs(rule.Y.Set_prop.dig_enum, item.Y.Set_prop.dig_enum))
                    return true;
            return false;
        }
        /// <summary>
        /// Создание списка правил 
        /// Основной метод
        /// </summary>
        public void Create_Rules()
        {
            Create_Rules_1();
            bool exist_new_rules = true;
            while (exist_new_rules)
            {
                exist_new_rules = Create_Rules_K();
            }
        }



    }
    */
}
