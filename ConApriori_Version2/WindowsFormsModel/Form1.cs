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

namespace WindowsFormsModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonModelDB_test_Click(object sender, EventArgs e)
        {
            Model_DB model = new Model_DB();
            string path_to = textBoxPath.Text;
            model.Model(path_to);
            textBoxMessage.Text = "База данных создана!";
        }

        private void buttonModelDB_Click(object sender, EventArgs e)
        {
            int N_tr;      // число транзакций
            int group;      // число групп элементов
            int[] M_gr;      //  число элементов в  группе 
            int len_tr;     //  максимальная длина транзакции
            int[] pr;       //  pr[i] вероятность появления элементов группы i

            string[] str_items;
            int n;
            N_tr = int.Parse(textBoxN_tr.Text);
            group = int.Parse(textBoxGroup.Text);
            str_items = textBoxM_gr.Text.Split(' ', ',');
            n = str_items.Length;
            M_gr = new int[n];
            for (int i = 0; i < n; i++)
                M_gr[i] = int.Parse(str_items[i]);
            
            len_tr = int.Parse(textBoxMaxLen.Text);
            str_items = textBoxPR.Text.Split(' ', ',');
            n = str_items.Length;
            pr = new int[n];
            for (int i = 0; i < n; i++)
                pr[i] = int.Parse(str_items[i]);

            Model_DB model = new Model_DB(N_tr, group, M_gr, len_tr, pr);
            string path_to = textBoxPath.Text;
            model.Model(path_to);
            textBoxMessage.Text = "База данных создана!";
        }
    }
}
