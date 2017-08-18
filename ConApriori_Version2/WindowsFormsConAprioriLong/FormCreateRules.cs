using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryConAprioriLong;
namespace WindowsFormsConAprioriLong
{
    public partial class FormCreateRules : Form
    {
        public FormCreateRules()
        {
            InitializeComponent();
        }
        string db_name;
        double support_min;
        double confidence_min;
        public ConAprioriLongRules rules = new ConAprioriLongRules();
            
        
        FormWorkingWithRules WWR;
        // List<string> factors_db;
        string factors;
        
        int m;      //число факторов в перечислении



        private void buttonChooseDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    db_name = openFileDialog1.FileName;
                textBoxDB_Name.Text = db_name;
                rules.DB_name = db_name;

            }
            catch (Exception)
            {
                textBoxMessage.Text = "Выберите из списка имя базы данных," +
                    " после чего нажмите кнопку <Выбрать базу> ";
            }
        }

        private void buttonLinkDB_Click(object sender, EventArgs e)
        {
            rules.Read_DB_Scale();
            factors = rules.Properties;
            string[] facts = factors.Split(',', ' ');
            m = facts.Length;
            listBoxFactors.Items.Clear();
            foreach (string item in facts)
                listBoxFactors.Items.Add(item);
            textBoxMessage.Text = "База данных открыта";
        }

        private void buttonParameters_Click(object sender, EventArgs e)
        {
            //Чтение параметров частоты и качества правил
            try
            {
                support_min = double.Parse(textBoxSupport.Text);
                confidence_min = double.Parse(textBoxQuality.Text);
                if ((support_min >= 0) && (support_min <= 0.99) &&
                    (confidence_min >= 0) && (confidence_min <= 0.99))
                {
                    rules.Confidence_min = confidence_min;
                    rules.Support_min = support_min;
                    textBoxMessage.Text = "Поддержка правила (частота) больше или равна " +
                          support_min +
                      "  Качество правила (достоверность) больше или равна" +
                      confidence_min;
                }
                else throw new ConAprioriLongException(
                    " Минимальная частота и качество должны быть в диапазоне 0 - 0,99");
                double eps = 1e-5;
                support_min -= eps; confidence_min -= eps;
            }
            catch (ConAprioriLongException except)
            {
                textBoxMessage.Text = except.Message +
                " Разделителем целой и дробной части должна быть запятая";
            }
        }

        private void buttonShowBD_Click(object sender, EventArgs e)
        {
            listBoxDB.Items.Clear();
            foreach (LongEnumScale set in rules.DB)
                listBoxDB.Items.Add(set.ToString());
            textBoxMessage.Text = "База данных показана";
        }

        private void buttonCreateRules_Click(object sender, EventArgs e)
        {
            DateTime start, finish;
            start = DateTime.Now;
            rules.Create_Rules();
            finish = DateTime.Now;

            textBoxMessage.Text = "Правила построены" + "   Время(мск) = " +
                (finish - start).TotalMilliseconds;
            /*
            string time_report = "";

            time_report += "\r\n" + "obc1: ";
            foreach (double item in rules.list_obc1)
                time_report += item.ToString() + "; -  ";
            time_report += "\r\n" + "obck: ";
            foreach (double item in rules.list_obck)
                time_report += item.ToString() + "; -  ";
            time_report += "\r\n" + "rule1: ";
            foreach (double item in rules.list_rule1)
                time_report += item.ToString() + "; -  ";
            time_report += "\r\n" + "rulek: ";
            foreach (double item in rules.list_rulek)
                time_report += item.ToString() + "; -  ";
            time_report += "\r\n" + "suppl: ";
            foreach (double item in rules.list_suppl)
                time_report += item.ToString() + "; -  ";
            time_report += "\r\n" + "support: ";
            foreach (double item in rules.list_support)
                time_report += item.ToString() + "; -  ";
            MessageBox.Show(time_report);
            */
        }

        private void buttonGotoRules_Click(object sender, EventArgs e)
        {
            WWR = new FormWorkingWithRules(factors);
            WWR.SetRules(rules);
            WWR.Show();
        }
    }
    public class ConAprioriLongException : Exception
    {
        public ConAprioriLongException() { }
        public ConAprioriLongException(string message) :
            base(message)
        { }
        public ConAprioriLongException(string message,
            Exception e)
            : base(message, e) { }

    }
}
