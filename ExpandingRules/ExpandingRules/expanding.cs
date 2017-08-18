using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandingRules
{
    public class expanding
    {
        /// <summary>
        /// Метод для замены сокарщений на полные аналоги
        /// </summary>
        /// <param name="rules">Обновляемая строка правил</param>
        /// <param name="shifr">Строка рашифровок</param>
        public void change(ref string rules, string shifr)
        {
            string[] eq = shifr.Split(new string[] { "=", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (eq.Length < 1 || eq.Length % 2 == 1)
                return;
            for (int i = 0; i < eq.Length; i=i+2)
                rules = rules.Replace(eq[i], eq[i + 1]);
        }
    }
}
