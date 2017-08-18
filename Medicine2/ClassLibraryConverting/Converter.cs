using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConverting
{
    public class Converter
    {
        double weight;
        double height;
        int infAboutPills;
        Random rnd = new Random();
        #region MainMethods
        public string SecondQuestionGroup(StreamReader reader, StreamWriter writer)
        {
            string current_record;
            string res = "";
            string result_record = "";
            string[] fields;
            double[] parameters;
            int n;
            while (!reader.EndOfStream)
            {
                current_record = reader.ReadLine();
                result_record = "";
                fields = current_record.Split(' ', ';');
                n = fields.Length;
                parameters = new double[n];
                string stigm = "";
                for (int i = 0; i < n; i++)
                {
                    if (i != 10)
                        parameters[i] = double.Parse(fields[i]);
                    else
                        stigm = fields[i];
                }
                ParseAge(parameters[0], ref result_record);
                ParseWeight(parameters[1], ref result_record);
                ParseHeight(parameters[2], ref result_record);
                ParseIMT(parameters[3], ref result_record);
                ParseWR(parameters[4], ref result_record);
                ParseCer(parameters[5], ref result_record);
                ParseYellowSind(parameters[6], ref result_record);
                ParseMilia(parameters[7], ref result_record);
                ParseToxEr(parameters[8], ref result_record);
                ParseKidWeight(parameters[9], ref result_record);
                ParseStigmSind(stigm, ref result_record);
                ParseKidRodWeight(parameters[11], ref result_record);
                ParseKidRodHeight(parameters[12], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string FirstQuestionGroup(StreamReader reader, StreamWriter writer)
        {
            string current_record;
            string res = "";
            string result_record = "";
            string[] fields;
            double[] parameters;
            int n;
            while (!reader.EndOfStream)
            {
                current_record = reader.ReadLine();
                result_record = "";
                fields = current_record.Split(';');
                n = fields.Length;
                parameters = new double[n];
                string otherSympt= "";
                string otherPills = "";
                for (int i = 0; i < n; i++)
                {
                    if (i != 22 && i != 31)
                        parameters[i] = double.Parse(fields[i]);
                    else
                    {
                        if (i == 22)
                            otherSympt = fields[i];
                        else
                            otherPills = fields[i];
                    }
                }
                ParseAge(parameters[0], ref result_record);
                ParseWeight(parameters[1], ref result_record);
                ParseHeight(parameters[2], ref result_record);
                ParseIMT(parameters[3], ref result_record);
                ParseWR(parameters[4], ref result_record);
                //
                ParseBerCount(parameters[5], ref result_record);
                ParseBigPrevKid(parameters[6], ref result_record);
                ParsePribavki(parameters[13], ref result_record);
                ParseMTox(parameters[14], ref result_record);
                ParseMOWB(parameters[15], ref result_record);
                ParseMAnem(parameters[16], ref result_record);
                ParseMAG(parameters[17], ref result_record);
                ParseMorwi(parameters[18], ref result_record);
                ParseMimws(parameters[19], ref result_record);
                ParseMUgr(parameters[20], ref result_record);
                ParseMPPMT(parameters[21], ref result_record);
                ParseMothersympt(otherSympt, ref result_record);
                ParseMData(parameters[23], ref result_record);
                ParseMPill1(parameters[24], ref result_record);
                ParseMPill2(parameters[25], ref result_record);
                ParseMPill3(parameters[26], ref result_record);
                ParseMPill4(parameters[27], ref result_record);
                ParseMPill5(parameters[28], ref result_record);
                ParseMPill6(parameters[29], ref result_record);
                ParseMPill7(parameters[30], ref result_record);
                ParseMotherpills(otherPills, ref result_record);
                ParseKidRodWeight(parameters[32], ref result_record);
                if (result_record[result_record.Length - 1] == ',')
                    result_record = result_record.Substring(0, result_record.Length - 1);
                //
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }
        #endregion

        #region ParseMethods
        /// <summary>
        /// Парсинг возраста матери
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseAge(double number, ref string rec)
        {
            string[] names = Common.Mother_shortnames.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(1, 4)];
            else
                if (number <= Common.MotherAge1)
                    name = names[0];
                else
                    if (number <= Common.MotherAge2)
                        name = names[1];
                    else
                        name = names[2];
            rec += name + ",";
        }

        /// <summary>
        /// Парсинг веса матери
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseWeight(double number, ref string rec)
        {
            string[] names = Common.Mother_shortnames.Split(' ', ',', ';');
            string name;
            weight = number;
            if (number == 0)
                name = names[rnd.Next(1, 4) + 2];
            else
                if (number <= Common.MotherWeight1)
                    name = names[3];
                else
                    if (number <= Common.MotherWeight2)
                        name = names[4];
                    else
                        name = names[5];
            rec += name + ",";
        }

        /// <summary>
        /// Парсинг роста матери
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseHeight(double number, ref string rec)
        {
            string[] names = Common.Mother_shortnames.Split(' ', ',', ';');
            string name;
            height = number;
            if (number == 0)
                name = names[rnd.Next(1, 4) + 5];
            else
                if (number <= Common.MotherHeight1)
                    name = names[6];
                else
                    if (number <= Common.MotherHeight2)
                        name = names[7];
                    else
                        name = names[8];
            rec += name + ",";
        }

        /// <summary>
        /// Парсинг ИМТ матери
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseIMT(double number, ref string rec)
        {
            Random rand = new Random();
            string[] names = Common.Mother_shortnames.Split(' ', ',', ';');
            string name;
            if (weight == 0)
                weight = rand.Next(50, 110);
            if (height == 0)
                height = rand.Next(140, 200);
            double result = (double)weight / Math.Pow((double)(height / 100), 2);
            if (result < Common.IMT1)
                name = names[9];
            else
                if (result < Common.IMT2)
                    name = names[10];
                else
                    name = names[11];
            rec += name + ",";
        }

        /// <summary>
        /// Парсинг наличия МВБ
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseWR(double number, ref string rec)
        {
            string[] names = Common.Mother_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 1)
            {
                name = names[12];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия цер. ишемии у ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseCer(double number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number != 0)
            {
                name = names[0];
                rec += name + ',';
            }
        }

        /// <summary>
        /// Парсинг наличия желтушного синдрома у ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseYellowSind(double number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number != 0)
            {
                name = names[1];
                rec += name + ',';
            }
        }

        /// <summary>
        /// Парсинг наличия Милиа у ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMilia(double number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[2];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия токсической эритемы у ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseToxEr(double number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[3];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг веса ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseKidWeight(double number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number > 0)
            {
                name = names[4];
                rec += name + ',';
            }
        }

        /// <summary>
        /// Парсинг наличия стигм. синдрома у ребёнка
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseStigmSind(string number, ref string rec)
        {
            string[] names = Common.Kid_Bol_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number != "0")
            {
                name = names[5];
            }
            if (name != "")
            {
                rec += name + ',';
            }
        }

        /// <summary>
        /// Парсинг веса ребёнка при рождении
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseKidRodWeight(double number, ref string rec)
        {
            string[] names = Common.Kid_Rod_shortnames.Split(' ', ',', ';');
            string name;
            if (number <= Common.KidWeight1)
                name = names[0];
            else
                if (number <= Common.KidWeight2)
                    name = names[1];
                else
                    name = names[2];
            rec += name + ",";
        }

        /// <summary>
        /// Парсинг веса ребёнка при рождении
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseKidRodHeight(double number, ref string rec)
        {
            string[] names = Common.Kid_Rod_shortnames.Split(' ', ',', ';');
            string name;
            if (number <= Common.KidHeight1)
                name = names[3];
            else
                if (number <= Common.KidHeight2)
                    name = names[4];
                else
                    name = names[5];
            rec += name;
        }

        /// <summary>
        /// Парсинг количества беременностей 
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseBerCount(double number, ref string rec)
        {
            string[] names = Common.Mother_Prev_Info_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 5);
            if (number <= 1)
            {
                name = names[0];
                rec += name + ',';
            }
            if (number == 2)
            {
                name = names[1];
                rec += name + ',';
            }
            if (number > 2)
            {
                name = names[2];
                rec += name + ',';
            }
        }

        /// <summary>
        /// Парсинг наличия крупновесных детей в предыдущих беременностях
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseBigPrevKid(double number, ref string rec)
        {
            string[] names = Common.Mother_Prev_Info_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[3];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг прибавок за беременность
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParsePribavki(double number, ref string rec)
        {
            string[] names = Common.Mother_Prev_Info_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 20);
            if (number <= 8)
            {
                name = names[4];
                rec += name + ",";
            }
            if (number <= 16)
            {
                name = names[5];
                rec += name + ",";
            }
            if (number > 16)
            {
                name = names[6];
                rec += name + ",";
            }
        }

        /* блок симптомов у матери */

        /// <summary>
        /// Парсинг наличия токсикоза
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMTox(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[0];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия ОВБ (гестоз)
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMOWB(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[1];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия анемии
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMAnem(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(0, 3);
            if (number > 0)
            {
                name = names[2];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия АГ
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMAG(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[3];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия ОРВИ
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMorwi(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[4];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия ИМВС
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMimws(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[5];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия угрозы прерывания
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMUgr(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[6];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия ППМТ
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPPMT(double number, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (number == 0)
                number = rnd.Next(1, 3);
            if (number == 2)
            {
                name = names[7];
                rec += name + ",";
            }
        }

        /// <summary>
        /// Парсинг наличия других симптомов
        /// </summary>
        /// <param name="inf">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMothersympt(string inf, ref string rec)
        {
            string[] names = Common.Mother_Sympt_shortnames.Split(' ', ',', ';');
            string name = "";
            if (inf != "0")
            {
                name = names[8];
                rec += name + ",";
            }
        }

        /* Блок принимаемых матерью лекарств */

        /// <summary>
        /// Парсинг наличия информации о принимаемых лекарствах
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMData(double number, ref string rec)
        {
            if (number == 0)
                number = rnd.Next(1, 3);
            infAboutPills = (int)number;
        }

        /// <summary>
        /// Метод парсинга первого препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill1(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[0];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[0];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсинга второго препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill2(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[1];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[1];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсинга третьего препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill3(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[2];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[2];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсингачетвёртого препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill4(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[3];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[3];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсинга пятого препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill5(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[4];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[4];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсинга шестого препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill6(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[5];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[5];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Метод парсинга седьмого препарата
        /// </summary>
        /// <param name="number">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMPill7(double number, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (infAboutPills == 1)
            {
                if (number == 0)
                    number = rnd.Next(1, 3);
                if (number == 2)
                {
                    name = names[6];
                    rec += name + ",";
                }
            }
            else
            {
                if (number == 2)
                {
                    name = names[6];
                    rec += name + ",";
                }
            }
        }

        /// <summary>
        /// Парсинг наличия других принимаемых препаратов
        /// </summary>
        /// <param name="inf">Параметр</param>
        /// <param name="rec">Обновляемая строка правил</param>
        void ParseMotherpills(string inf, ref string rec)
        {
            string[] names = Common.Mother_Pills_shortnames.Split(' ', ',', ';');
            string name = "";
            if (inf != "0")
            {
                name = names[7];
                rec += name + ",";
            }
        }
        #endregion
    }
}
