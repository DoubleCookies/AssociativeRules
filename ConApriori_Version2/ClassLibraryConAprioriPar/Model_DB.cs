using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConAprioriPar
{
    public  class Model_DB
    {
        int N_tr;      // число транзакций
        int group;      // число групп элементов
        int[] M_gr;      // M_gr[i]  - число элементов в  группе i
        int len_tr;     //  максимальная длина транзакции
        int[] pr;       //  pr[i] вероятность появления элементов группы i
        Random rnd = new Random();
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Model_DB()
        {
            N_tr = 100000;
            group = 4;
            M_gr = new int[group];
            M_gr[0] = 50; M_gr[1] = 25; M_gr[2] = 15; M_gr[3] = 10;

            len_tr = 10;
            pr = new int[group];
            pr[0] = 5; pr[1] = 10; pr[2] = 15; pr[3] = 70;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="N_tr"></param>
        /// <param name="group"></param>
        /// <param name="M_gr"></param>
        /// <param name="len_tr"></param>
        /// <param name="pr"></param>
        public Model_DB(int N_tr, int group, int[] M_gr, int len_tr, int[] pr)
        {
            this.N_tr = N_tr;
            this.group = group;
            this.M_gr = M_gr;
            this.len_tr = len_tr;
            this.pr = pr;
        }
        public void Model( string path)
        {
            StreamWriter writer = File.CreateText(path);
            int len;      // длина транзакции
            string transaction = "";    //текущая транзакция
            int n_gr = 0;                  //номер группы   элементов
            int n_item;              //номер элемента
            string item = "";
            for(int i =0; i < N_tr; i++)    //цикл по числу транзакций
            {
                len = rnd.Next(1, len_tr + 1);    //длина текущей транзакции
                transaction = "";
                for (int j = 0; j < len; j++)    //моделирование транзакции
                {
                    //выбор группы с учетом вероятности появления группы
                     int n = rnd.Next(0, 100);
                    for(int k = 0; k < group; k++)
                        if( n < pr[k]) { n_gr = k; break; }
                    //выбор элемента в группе
                    n_item = rnd.Next(0, M_gr[n_gr]);
                    for (int k = 0; k < n_gr; k++)
                        n_item += M_gr[k];
                    item = "item" + n_item;
                    if (transaction.IndexOf(item) < 0)
                        transaction += item + " "; 
                }
                transaction.Trim(' ');
                writer.WriteLine(transaction);
            }
            writer.Close();
            //преобразование базы данных в формат scale
            string path_scale = path + "_scale";
            Converter.Convert(path, path_scale, "no_replic", 1, 60);
        }

    }
}
