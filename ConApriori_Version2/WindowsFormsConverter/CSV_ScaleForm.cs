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

namespace WindowsFormsConverter
{
    public partial class CSV_ScaleForm : Form
    {
        public CSV_ScaleForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// конвертирование исходной базы данных в результирующую 
        /// с возможной репликацией, но без сжатия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            DateTime start, finish;
            string from = "", to = "";        //path
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                from = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                to = saveFileDialog1.FileName;


            int fragment = 0;
            try
            {
                fragment = int.Parse(textBoxFragmentLength.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Попытка ввода не целого числа!");
                return;
            }
            string status;
            int replica;
            if (radioButtonNorma.Checked)
            {
                status = "Norma"; replica = 1;
            }
            else
            {
                status = "Replica";
                try
                {
                    replica = int.Parse(textBoxReplica.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Попытка ввода не целого числа!");
                    return;
                }
            }
            start = DateTime.Now;
            if (Converter.Convert(from, to, status, replica, fragment))
            {
                finish = DateTime.Now;
                textBoxTimeConvert.Text = ((finish - start).TotalMilliseconds).ToString();
                textBoxMessage.Text = "Конвертирование прошло успешно";
            }
            else
                textBoxMessage.Text = "В процессе конвертирования возникла ошибка"; 
        }
    }
}
