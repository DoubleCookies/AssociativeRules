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

namespace WindowsFormsSplitFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        string path = "";
        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                path = openFileDialog1.FileName;
            textBoxSourcePath.Text = path;
            
            int index1 = path.LastIndexOf('\\');
            int index2 = path.IndexOf('.');
            int length = index2 - index1 - 1;
            name = path.Substring(index1 + 1, length);

        }

        private void buttonSplitFile_Click(object sender, EventArgs e)
        {
            int m;
            
            int n = int.Parse(textBoxN.Text);
            Converter.SplitFile(path, n, out m);
            string message = "Создано подфайлов: " + m + " с именами " +
                name + "1" + " ... " + name + m;
            textBoxMessage.Text = message;

        }

        private void buttonCreateGategory_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxCategorylength.Text);
            Converter.CreateCategory(path, n);
            string message = "Создан файл категорий с именем " +
                name + "_cat";
            textBoxMessage.Text = message;

        }
    }
}
