using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConverting
{
    public static class Common
    {
        public const string Mother_shortnames =
             "МВоз1,МВоз2,МВоз3,МВес1,МВес2,МВес3," +
             "МР1,МР2,МР3,МИмт1,МИмт2,МИмт3,МВБ";
        public const string Mother_fullnames =
            "Юная мать,Молодая мать,Зрелая мать," +
            "Малый вес матери,Средний вес матери,Большой вес матери," +
            "Малый рост матери,Средний рост матери,Большой рост матери," +
            "ИМТ матери ниже нормы,ИМТ матери в норме,ИМТ матери выше нормы," +
            "Вес матери при рождении выше нормы";
        public const int MotherAge1 = 22;
        public const int MotherAge2 = 28;
        public const int MotherWeight1 = 60;
        public const int MotherWeight2 = 70;
        public const int MotherHeight1 = 160;
        public const int MotherHeight2 = 170;
        public const int IMT1 = 25;
        public const int IMT2 = 30;
        public const string Kid_Bol_shortnames =
            "ЦИ,ЖС,МИЛ,ТЭ,ПМ,СТ";
        public const string Kid_Bol_fullnames =
            "Церебральная ишемия,Желтушный синдром,Милиа,Токсическая Эритема,Потеря массы,Стигмы дизэмбриогенеза";

        public const int KidWeight1 = 3200;
        public const int KidWeight2 = 4000;
        public const int KidHeight1 = 52;
        public const int KidHeight2 = 55;
        public const string Kid_Rod_shortnames =
            "РВес1,РВес2,РВес3,РДл1,РДл2,РДл3";
        public const string Kid_Rod_fullnames = "Маленький вес ребёнка,Средний вес ребёнка,Большой вес ребёнка,Маленький рост ребёнка,Средний рост ребёнка,Большой рост ребёнка";
        public const string Mother_Prev_Info_shortnames = "Бер1,Бер2,Бер3,КрПл,Приб1,Приб2,Приб3";
        public const string Mother_Prev_Info_fullnames = "0-1 беременность,2 беременности,больше 2 беременностей, крупный плод в предыдущих беременностях,"+
            "Незначительные прибавки за беременность,Средние прибавки за беременность,Значительные прибавки за беременность";
        public const string Mother_Sympt_shortnames = "Токс,ОВБ,Ан,АГ,ОРВИ,ИМВС,УгрПрев,ППМТ,ДругСимпт";
        public const string Mother_Sympt_fullnames = 
            "Токсикоз,ОВБ (гестоз),Анемия,АГ,ОРВИ,ИМВС,Угроза прерывания,ППМТ,Другие симптомы";
        public const string Mother_Pills_shortnames = "Гест,Трент,ВитЕ,ФолКисл,MgB6,ВитЦел,Садз,ДругВит";
        public const string Mother_Pills_fullnames = 
            "Гестагены,Трентал;курантил;автовегин,Витамин Е,Фолиевая кислота,MgB6,Витамины,Садз,Другие препараты";
        
        /// <summary>
        /// Метод генерации строки с расшифровками
        /// </summary>
        /// <returns>Возвращает строку с расшифровками</returns>
        public static string shifr()
        {
            string res = "";
            string[] min = Mother_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] max = Mother_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Kid_Bol_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Kid_Bol_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Kid_Rod_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Kid_Rod_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Mother_Prev_Info_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Mother_Prev_Info_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Mother_Sympt_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Mother_Sympt_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Kid_Rod_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Kid_Rod_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            min = Mother_Pills_shortnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            max = Mother_Pills_fullnames.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < min.Length; i++)
            {
                res += min[i] + "=" + max[i] + "\r\n";
            }
            return res;
        }
    }
}
