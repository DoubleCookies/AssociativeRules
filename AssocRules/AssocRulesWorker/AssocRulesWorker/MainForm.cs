using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicine2;
using WindowsFormsConverter;
using WindowsFormsConAprioriPar;
using ExpandingRules;

namespace AssocRulesWorker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStep1_Click(object sender, EventArgs e)
        {
        }

        private void buttonStep2_Click(object sender, EventArgs e)
        {
            MedForm form = new MedForm();
            form.Show();
        }

        private void buttonStep3_Click(object sender, EventArgs e)
        {
            CSV_ScaleForm form = new CSV_ScaleForm();
            form.Show();
        }

        private void buttonStep4_Click(object sender, EventArgs e)
        {
            FormCreateRules form = new FormCreateRules();
            form.Show();
        }

        private void buttonStep5_Click(object sender, EventArgs e)
        {
            ExpandingForm form = new ExpandingForm();
            form.Show();
        }

        private void buttonSecondBase_Click(object sender, EventArgs e)
        {
            SecondBaseForm form = new SecondBaseForm();
            form.Show();
        }
    }
}
