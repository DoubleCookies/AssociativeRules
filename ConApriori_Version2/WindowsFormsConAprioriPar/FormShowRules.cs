using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryConAprioriPar;
using System.IO;

namespace WindowsFormsConAprioriPar
{
    public partial class FormShowRules : Form
    {
        public FormShowRules()
        {
            InitializeComponent();
        }
        LongEnumScale pre_prop, con_prop;
        ConAprioriLongRules rules;
        int N_rules;
        public void SetProperties(LongEnumScale pre_prop, LongEnumScale con_prop)
        {
            this.pre_prop = pre_prop;
            this.con_prop = con_prop;
        }
        public void SetRules(ConAprioriLongRules rules)
        {
            this.rules = rules;
        }
        private void buttonShowRules_Click(object sender, EventArgs e)
        {
            listBoxRules.Items.Clear();
            bool pre, con;
            double lift_min = 0;
            try
            { lift_min = double.Parse(textBoxLift_min.Text); }
            catch (Exception)
            {
                MessageBox.Show("Введите корректное значение параметра!");
                return;
            }
            N_rules = 0;
            foreach (ClassLibraryConAprioriPar.Rule item in rules.Rules)
            {
                pre = rules.Equal_Arrs((item.X & pre_prop),
                    item.X.dig_enum);
                con = rules.Equal_Arrs((item.Y & con_prop),
                    item.Y.dig_enum);

                if (pre && con && item.Lift >= lift_min)
                {
                    listBoxRules.Items.Add(item.ToString());
                    N_rules++;
                }
            }
            textBoxNRules.Text = N_rules.ToString();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxRules.Items.Clear();
            double lift_min = double.Parse(textBoxLift_min.Text);
            N_rules = 0;
            foreach (ClassLibraryConAprioriPar.Rule item in rules.Rules)
            {
                if (item.Lift >= lift_min)
                {
                    listBoxRules.Items.Add(item.ToString());
                    N_rules++;
                }
            }
            textBoxNRules.Text = N_rules.ToString();

        }

        /// <summary>
        /// Сохранение файла правил
        /// </summary>
        private void SaveRules()
        {
            string restext = "";
            string name = "";
            for (int i = 0; i < listBoxRules.Items.Count; i++)
            {
                restext += (listBoxRules.Items[i].ToString()) + "\r\n";
            }
            SaveFileDialog saveF = new SaveFileDialog();
            saveF.Filter = "TXT Files|*.txt|All Files (*.*)|*.*";
            saveF.FilterIndex = 1;
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                name = saveF.FileName;
                File.WriteAllText(name, restext, Encoding.UTF8);
            }
            string path = Path.GetFullPath(name);
            textBoxMessage.Text = "Правила успешно сохранены в файле " + path;
        }
        private void buttonSaveRules_Click(object sender, EventArgs e)
        {
            SaveRules();
        }
        
    }
}
