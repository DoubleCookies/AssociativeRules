using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExpandingRules
{
    public partial class ExpandingForm : Form
    {
        public ExpandingForm()
        {
            InitializeComponent();
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            string filename = "";
            string restext = "";
            string shifr = "";
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "Text Files|*.txt|All Files (*.*)|*.*";
            openF.FilterIndex = 1;
            openF.Title = "Открытие файла правил";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                filename = openF.FileName.ToString();
                restext = File.ReadAllText(filename);
                richTextBoxInput.Text = restext;
            }
            else
                return;
            openF.Title = "Открытие файла расшифровок";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                filename = openF.FileName.ToString();
                shifr = File.ReadAllText(filename);
                richTextBoxCodes.Text = shifr;
            }
            else
                return;
            expanding ex = new expanding();
            ex.change(ref restext, shifr);
            richTextBoxOutput.Text = restext;
            SaveFileDialog saveF = new SaveFileDialog();
            saveF.Filter = "TXT Files|*.txt|All Files (*.*)|*.*";
            saveF.FilterIndex = 1;
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                string name = saveF.FileName;
                File.WriteAllText(name, restext, Encoding.UTF8);
            }
        }
    }
}
