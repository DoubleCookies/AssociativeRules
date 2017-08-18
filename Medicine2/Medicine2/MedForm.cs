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

namespace Medicine2
{
    public partial class MedForm : Form
    {
        public MedForm()
        {
            InitializeComponent();
        }

        private void buttonSecondQ_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.Converter converter = new ClassLibraryConverting.Converter();
            string res = converter.SecondQuestionGroup(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonShifrGen_Click(object sender, EventArgs e)
        {
            string filename = " ";
            string result = ClassLibraryConverting.Common.shifr();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                filename = saveFileDialog1.FileName;
            StreamWriter writer = File.CreateText(filename + ".txt");
            writer.WriteLine(result);
            writer.Close();
        }

        private void buttonFirstQ_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.Converter converter = new ClassLibraryConverting.Converter();
            string res = converter.FirstQuestionGroup(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }
    }
}
