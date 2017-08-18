using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryConverting
{
    public class SecondBaseConverter
    {
        Random rnd = new Random();
        public string SecondBaseFirstQestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 1; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseGender(fields[0], ref result_record);
                ParseAge(parameters[1], ref result_record);
                ParseDiseaseAge(parameters[2], ref result_record);
                ParseInsulin(parameters[3], ref result_record);
                ParseWarGlickFQ(parameters[4], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseSecondQestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick1Y(parameters[0], ref result_record);
                ParseWarGlick3Y(parameters[1], ref result_record);
                ParseWarGlick5Y(parameters[2], ref result_record);
                ParseWarGlick10Y(parameters[3], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseThirdQestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseHbA1c(parameters[0], ref result_record);
                ParseHbA1cSecond(parameters[1], ref result_record);
                ParseGipoglickemia(parameters[2], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseFourthQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParseAritmia(parameters[1], ref result_record);
                ParseTahikardia(parameters[2], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseFifthQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParseDispQT(parameters[1], ref result_record);
                ParseDispCorrQT(parameters[2], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseSixthQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParseIwtSimpt(parameters[1], ref result_record);
                ParseIwtHyperSimpt(parameters[2], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseSeventhQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParseWrHyperSimpt(parameters[1], ref result_record);
                ParseWrAsimpt(parameters[2], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseEighthQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParsePomp(parameters[1], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        public string SecondBaseNinethQuestion(StreamReader reader, StreamWriter writer)
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
                for (int i = 0; i < n; i++)
                    parameters[i] = double.Parse(fields[i]);
                ParseWarGlick(parameters[0], ref result_record);
                ParseEwing(parameters[1], ref result_record);
                ParseBegin(parameters[2], ref result_record);
                ParseWowl(parameters[3], ref result_record);
                writer.WriteLine(result_record);
                res += result_record + "\r\n";
            }
            reader.Close();
            writer.Close();
            return res;
        }

        void ParseGender(string gender, ref string rec)
        {
            string[] names = SecondBaseCommon.C_D_E_AN_CT.Split(' ', ',', ';');
            if (gender == "м")
                rec += names[0] + ",";
            else
                rec += names[1] + ",";
        }

        void ParseAge(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.C_D_E_AN_CT.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(2, 5)];
            else
                if (number <= 6)
                    name = names[2];
                else
                    if (number <= 12)
                        name = names[3];
                    else
                        name = names[4];
            rec += name + ",";
        }

        void ParseDiseaseAge(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.C_D_E_AN_CT.Split(' ', ',', ';');
            if (number < 5)
                rec += names[6] + ",";
            else
                rec += names[5] + ",";
        }

        void ParseInsulin(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.C_D_E_AN_CT.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(7, 10)];
            else
                if (number <= 0.5)
                    name = names[7];
                else
                    if (number <= 1)
                        name = names[8];
                    else
                        name = names[9];
            rec += name + ",";
        }

        void ParseWarGlickFQ(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.C_D_E_AN_CT.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(10, 13)];
            else
                if (number <= 5)
                    name = names[10];
                else
                    if (number <= 10)
                        name = names[11];
                    else
                        name = names[12];
            rec += name;
        }

        /// <summary>
        /// Парсинг гликированного гемоглобина
        /// </summary>
        /// <param name="number"></param>
        /// <param name="rec"></param>
        void ParseHbA1c(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.GlikGem.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(0, 3)];
            else
                if (number <= 7.5)
                    name = names[0];
                else
                    if (number <= 10)
                        name = names[1];
                    else
                        name = names[2];
            rec += name + ",";
        }

        void ParseHbA1cSecond(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.GlikGem.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(3, 6)];
            else
                if (number <= 7.5)
                    name = names[3];
                else
                    if (number <= 10)
                        name = names[4];
                    else
                        name = names[5];
            rec += name + ",";
        }


        /// <summary>
        /// Парсинг наличия гипогликемии
        /// </summary>
        /// <param name="number"></param>
        /// <param name="rec"></param>
        void ParseGipoglickemia(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.GlikGem.Split(' ', ',', ';');
            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                rec += names[6];
        }

        void ParseWarGlick(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.WarGlick.Split(' ', ',', ';');
            string name;

            if (number == 0)
                name = names[rnd.Next(0, 3)];
            else
                if (number <= 5)
                    name = names[0];
                else
                    if (number <= 10)
                        name = names[1];
                    else
                        name = names[2];
            rec += name + ",";
        }

        void ParseWarGlick1Y(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.WarGlick1Y.Split(' ', ',', ';');
            string name;

            if (number == 0)
                return;
            else
                if (number <= 5)
                name = names[0];
            else
                    if (number <= 10)
                name = names[1];
            else
                name = names[2];
            rec += name + ",";
        }

        void ParseWarGlick3Y(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.WarGlick3Y.Split(' ', ',', ';');
            string name;

            if (number == 0)
                return;
            else
                if (number <= 5)
                name = names[0];
            else
                    if (number <= 10)
                name = names[1];
            else
                name = names[2];
            rec += name + ",";
        }

        void ParseWarGlick5Y(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.WarGlick5Y.Split(' ', ',', ';');
            string name;

            if (number == 0)
                return;
            else
                if (number <= 5)
                name = names[0];
            else
                    if (number <= 10)
                name = names[1];
            else
                name = names[2];
            rec += name + ",";
        }

        void ParseWarGlick10Y(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.WarGlick10Y.Split(' ', ',', ';');
            string name= "";

            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                if (number <= 5)
                name = names[0];
            else
                    if (number <= 10)
                name = names[1];
            else
                name = names[2];
            rec += name;
        }

        //
        void ParseAritmia(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DF_DG.Split(' ', ',', ';');
            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                rec += names[0];
        }

        void ParseDispQT(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DQ_DS.Split(' ', ',', ';');
            if (number == 0)
                rec += names[0];
            else
                rec += names[1];
            rec += ",";
        }

        void ParseDispCorrQT(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DQ_DS.Split(' ', ',', ';');
            if (number == 0)
                rec += names[2];
            else
                rec += names[3];
        }

        void ParseTahikardia(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DF_DG.Split(' ', ',', ';');
            if (number == 0)
		{if(rec[rec.Length-1] == ',')rec = rec.Remove(rec.Length - 1);}
            else
            { if (rec[rec.Length - 1] == ',')rec += names[1]; else rec += "," + names[1]; }
        }

        //
        void ParseIwtSimpt(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DY_DZ.Split(' ', ',', ';');
            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                rec += names[0];
        }

        void ParseIwtHyperSimpt(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_DY_DZ.Split(' ', ',', ';');
            if (number == 0)
		{if(rec[rec.Length-1] == ',')rec = rec.Remove(rec.Length - 1);}
            else
            { if (rec[rec.Length - 1] == ',')rec += names[1]; else rec += "," + names[1]; }
        }

        //
        void ParseWrHyperSimpt(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_EC_ED.Split(' ', ',', ';');
            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                rec += names[0];
        }

        void ParseWrAsimpt(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_EC_ED.Split(' ', ',', ';');
            if (number == 0)
		{if(rec[rec.Length-1] == ',')rec = rec.Remove(rec.Length - 1);}
            else
            { if (rec[rec.Length - 1] == ',')rec += names[1]; else rec += "," + names[1]; }
        }

        //
        void ParsePomp(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_ER.Split(' ', ',', ';');
            if (number == 0)
                rec += names[1];
            else
                rec += names[0];
        }

        //
        void ParseEwing(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_EO_EQ.Split(' ', ',', ';');
            if (number == 0)
                rec = rec.Remove(rec.Length - 1);
            else
                rec += names[0];
        }

        void ParseBegin(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_EO_EQ.Split(' ', ',', ';');
            if (number == 0)
		{if(rec[rec.Length-1] == ',') rec = rec.Remove(rec.Length - 1);}
            else
            { if (rec[rec.Length - 1] == ',') rec += names[1]; else rec += "," + names[1]; }
        }

        void ParseWowl(double number, ref string rec)
        {
            string[] names = SecondBaseCommon.CT_EO_EQ.Split(' ', ',', ';');
            if (number == 0)
		{if(rec[rec.Length-1] == ',') rec = rec.Remove(rec.Length - 1);}
            else
            { if (rec[rec.Length - 1] == ',') rec += names[2]; else rec += "," + names[2]; }
        }
	
    }
}
