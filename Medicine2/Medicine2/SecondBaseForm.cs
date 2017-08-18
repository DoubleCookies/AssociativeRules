using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Medicine2
{
    public partial class SecondBaseForm : Form
    {
        public SecondBaseForm()
        {
            InitializeComponent();
        }

        private void buttonFirstGroup_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseThirdQestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void ButtonSecShifr_Click(object sender, EventArgs e)
        {
            string filename = " ";
            string result = ClassLibraryConverting.SecondBaseCommon.shifr();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                filename = saveFileDialog1.FileName;
            StreamWriter writer = File.CreateText(filename + ".txt");
            writer.WriteLine(result);
            writer.Close();
        }

        private void buttonQ1_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseFirstQestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ4_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseFourthQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ6_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseSixthQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ7_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseSeventhQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ8_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseEighthQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ9_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseNinethQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonFifthQuestion_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseFifthQuestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }

        private void buttonQ2_Click(object sender, EventArgs e)
        {
            string db_name = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                db_name = openFileDialog1.FileName;
            textBoxReader.Text = db_name;
            StreamReader reader = File.OpenText(db_name);
            StreamWriter writer = File.CreateText(db_name + "_csv");

            ClassLibraryConverting.SecondBaseConverter converter = new ClassLibraryConverting.SecondBaseConverter();
            string res = converter.SecondBaseSecondQestion(reader, writer);
            StreamReader reader2 = File.OpenText(db_name);
            richTextBoxInput.Text = reader2.ReadToEnd();
            richTextBoxOutput.Text = res;
        }
    }
}
