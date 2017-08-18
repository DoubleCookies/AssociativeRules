using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConverting
{
    public static class SecondBaseCommon
    {
        public const string GlikGem =
                     "ГлГемНач1,ГлГемНач2,ГлГемНач3,ГлГемОбс1,ГлГемОбс2,ГлГемОбс3,Гипогл";
        public const string GlikGemFull =
             "Низкое содержание гликированного гемоглобина в начале заболевания,Среднее содержание гликированного гемоглобина в начале заболевания,Высокое содержание гликированного гемоглобина в начале заболевания," +
             "Низкое содержание гликированного гемоглобина при обследовании,Среднее содержание гликированного гемоглобина при обследовании,Высокое содержание гликированного гемоглобина при обследовании," +
             "Наличие гипогликемии";

        //Первый вопрос
        public const string C_D_E_AN_CT = "Муж,Жен,Возр1,Возр2,Возр3,Бол5,Мен5,Инс1,Инс2,Инс3,Вар1,Вар2,Вар3";
        public const string C_D_E_AN_CT_Full = "Мужчина,Женщина,Возраст меньше 6 лет,Возраст 6-12 лет,Возраст больше 12 лет,Заболевание больше пяти лет,Заболевание меньше пяти лет,Инсулин ниже 0.5,Инсулин 0.5-1,Инсулин выше 1,Вариабельность гликемии в пределах нормы,Вариабельность гликемии выше нормы,Вариабельность гликемии значительно выше нормы";

        //Общая строка для гликемии для последних вопросов
        public const string WarGlick = "Вар1,Вар2,Вар3";
        public const string WarGlickFull = "Вариабельность гликемии в пределах нормы,Вариабельность гликемии выше нормы,Вариабельность гликемии значительно выше нормы";

        public const string WarGlick1Y = "Варг11,Варг12,Варг13";
        public const string WarGlick1YFull = "Вариабельность гликемии в первый год в пределах нормы,Вариабельность гликемии в первый год выше нормы,Вариабельность гликемии в первый год значительно выше нормы";

        public const string WarGlick3Y = "Варг31,Варг32,Варг33";
        public const string WarGlick3YFull = "Вариабельность гликемии в третий год в пределах нормы,Вариабельность гликемии в третий год выше нормы,Вариабельность гликемии в третий год значительно выше нормы";

        public const string WarGlick5Y = "Варг51,Варг52,Варг53";
        public const string WarGlick5YFull = "Вариабельность гликемии в пятый год в пределах нормы,Вариабельность гликемии в пятый год выше нормы,Вариабельность гликемии в пятый год значительно выше нормы";

        public const string WarGlick10Y = "Варг101,Варг102,Варг103";
        public const string WarGlick10YFull = "Вариабельность гликемии в десятый год в пределах нормы,Вариабельность гликемии в десятый год выше нормы,Вариабельность гликемии в десятый год значительно выше нормы";

        //Влияние ВГ на тахикардию и аритмию
        public const string CT_DF_DG = "Аритм,Тах";
        public const string CT_DF_DG_Full = "Аритмия,Тахикардия";

        //ВГ и дисперсия QT и коррегированного QT - не совсем понятно!
        public const string CT_DQ_DS = "ДиспИ1,ДиспИ2,ДиспКИ1,ДиспКИ2";
        public const string CT_DQ_DS_Full = "Дисперсия интервала QT равну нулю,Дисперсия интервала QT больше нуля,Дисперсия коррегированного интервала QT равну нулю,Дисперсия коррегированного интервала QT больше нуля";

        //ВГ и гиперсим и сим
        public const string CT_DY_DZ = "ИвтСим,ИвтГип";
        public const string CT_DY_DZ_Full = "Симпатикотония,Гиперсимпатикотония";

        //ВГ и ВР гиперсим и асим
        public const string CT_EC_ED = "ВрГип,ВрАсим";
        public const string CT_EC_ED_Full = "Гиперсимпатикотоническая вегетативная реактивность,Асимпатикотоническая вегетативная реактивность";

        //Предпоследний вопрос - ВГ и помпа
        public const string CT_ER = "ПИТ,НеП";
        public const string CT_ER_Full = "Помповая инсулинотерапия,Отсутствие помповой инсулинотерапии";

        //Последний вопрос - ВГ и кардиоваскулярные тесты
        public const string CT_EO_EQ = "Ewing,Нач,Отч";
        public const string CT_EO_EQ_Full = "Ewing норма,Начальные изменения,Отчётливое вовлечение";


        public static string shifr()
        {
            string res = "";
            string[] min = GlikGem.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] max = GlikGemFull.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = WarGlick1Y.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = WarGlick1YFull.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = WarGlick3Y.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = WarGlick3YFull.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = WarGlick5Y.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = WarGlick5YFull.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = WarGlick10Y.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = WarGlick10YFull.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = C_D_E_AN_CT.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = C_D_E_AN_CT_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_DF_DG.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_DF_DG_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_DQ_DS.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_DQ_DS_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_DY_DZ.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_DY_DZ_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_ER.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_ER_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_EC_ED.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_EC_ED_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = CT_EO_EQ.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = CT_EO_EQ_Full.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            return res;
        }
    }
}
