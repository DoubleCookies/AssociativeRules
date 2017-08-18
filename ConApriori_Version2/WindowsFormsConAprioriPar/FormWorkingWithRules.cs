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

namespace WindowsFormsConAprioriPar
{
    public partial class FormWorkingWithRules : Form
    {
        string factors;
        public FormWorkingWithRules(string factors)
        {
            InitializeComponent();
            this.factors = factors;
            Init_PreAndCon(factors);

        }

        string pre, con;
        LongEnumScale pre_prop, con_prop;
        ConAprioriLongRules rules;
        ClassLibraryConAprioriPar.Rule rule;
        LongEnumScale set1, set2, set;

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            textBoxIndividRule.Text = "";
            try
            {
                ListView.SelectedListViewItemCollection items = listViewConclusion.SelectedItems;
                con = "";
                foreach (ListViewItem item in items)
                {
                    con = con + item.Text + ",";
                }
                con = con.Remove(con.Length - 1);
                con_prop = new LongEnumScale(con);
            }
            catch (Exception)
            {
                textBoxIndividRule.Text = "Вначале  в окне элементов выберите один или несколько элементов," +
                    " а потом нажмите кнопку";
            }

        }

        private void buttonRuleIndivid_Click(object sender, EventArgs e)
        {
            textBoxIndividRule.Text = "";
            try
            {
                ListView.SelectedListViewItemCollection items = listViewPremise.SelectedItems;

                pre = "";
                foreach (ListViewItem item in items)
                {
                    pre = pre + item.Text + ",";
                }
                pre = pre.Remove(pre.Length - 1);
                pre_prop = new LongEnumScale(pre);
                
            }
            catch (Exception)
            {
                textBoxIndividRule.Text = "Вначале  в окне элементов выберите один или несколько элементов," +
                    " а потом нажмите кнопку";
            }
        }

        private void buttonCreateRule_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxIndividRule.Text = "";
                set = new LongEnumScale(pre_prop | con_prop);
                double sup = Apriori_DB.Support(set.dig_enum);
                double sup1 = Apriori_DB.Support(pre_prop.dig_enum),
                    sup2 = Apriori_DB.Support(con_prop.dig_enum);
                rule = new ClassLibraryConAprioriPar.Rule(pre_prop, con_prop);
                rule.Support = sup;
                rule.Сonfidence = sup / sup1;
                rule.SupX = sup1;
                rule.SupY = sup2;
                rule.Lift = rule.Сonfidence / rule.SupY;
                textBoxIndividRule.Text = rule.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка при построении индивидуального правила.");
            }
        }

        private void buttonRule_con_Click(object sender, EventArgs e)
        {
            textBoxIndividRule.Text = "";
            try
            {
                ListView.SelectedListViewItemCollection items = listViewConclusion.SelectedItems;

                con = "";
                foreach (ListViewItem item in items)
                {
                    con = con + item.Text + ",";
                }
                con = con.Remove(con.Length - 1);
                con_prop = new LongEnumScale(con);
                
            }
            catch (Exception)
            {
                textBoxIndividRule.Text = "Вначале  в окне элементов выберите один или несколько элементов," +
                    " а потом нажмите кнопку";
            }
        }

        private void buttonGotoShowRules_Click(object sender, EventArgs e)
        {
            FSR.SetProperties(pre_prop, con_prop);
            FSR.SetRules(rules);
            FSR.Show();
        }

        FormShowRules FSR = new FormShowRules();

        /// <summary>
        /// Инициализация окон, содержащих элементы для задания
        /// посылки и заключения правил
        /// </summary>
        void Init_PreAndCon(string items)
        {

            string[] ar_items = items.Split(',', ' ');
            textBoxIndividRule.Text = "";
            listViewPremise.Items.Clear();
            listViewConclusion.Items.Clear();
            foreach (string item in ar_items)
            {
                listViewPremise.Items.Add(item);
                listViewConclusion.Items.Add(item);
            }

        }
        public void SetRules(ConAprioriLongRules rules)
        {
            this.rules = rules;
        }
        private void buttonPremiseFilter_Click(object sender, EventArgs e)
        {
            textBoxIndividRule.Text = "";
            try
            {
                ListView.SelectedListViewItemCollection items = 
                    listViewPremise.SelectedItems;
                pre = "";
                foreach (ListViewItem item in items)
                {
                    pre = pre + item.Text + ",";
                }
                pre = pre.Remove(pre.Length - 1);
                pre_prop = new LongEnumScale(pre);
            }
            catch (Exception)
            {
                textBoxIndividRule.Text = "Вначале  в окне элементов выберите один или несколько элементов," +
                    " а потом нажмите кнопку";
            }
        }
    }
}
