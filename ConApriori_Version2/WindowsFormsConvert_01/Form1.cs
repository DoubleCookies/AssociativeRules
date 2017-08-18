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

namespace WindowsFormsConvert_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path_source;
        string path_scale, path_csv;
        StreamReader reader;
        StreamWriter writer_scale;
        StreamWriter writer_csv;
        int len_fragment = 60;
        string properties = "TOKS UPB EZM OV PROFV NED XV RH KES SRD SR APGAR PPG POP RT RIV MS OZ";
        string[] props;
        private void buttonOpenDB_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                path_source = openFileDialog1.FileName;
            textBoxSourceDB.Text = path_source;
            

        }

        private void buttonShowProps_Click(object sender, EventArgs e)
        {
            props = properties.Split();
            int n = props.Length;
            listBoxProps.Items.Clear();

            for (int i = 0; i < n; i++)
                listBoxProps.Items.Add(props[i]);

        }

        private void buttonResultPathes_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                path_scale = saveFileDialog1.FileName;
            textBoxResultDB.Text = path_scale;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                path_csv = saveFileDialog1.FileName;
            textBoxResultDB.Text += " - " + path_csv;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string rec = "";
            
            long number = 0;
            
            reader = File.OpenText(path_source);
            writer_scale = File.CreateText(path_scale);
            writer_scale.WriteLine(properties);
            writer_scale.WriteLine(len_fragment.ToString());

            writer_csv = File.CreateText(path_csv);
            int n;
            listBoxDB.Items.Clear();
            while(!reader.EndOfStream)
            {
                rec = reader.ReadLine();
                number = 0;
                string item = "";
                string csv = "";
                n = rec.Length;               
                for(int k = 0; k < n ; k++)
                {
                    item = rec[k].ToString();
                    if (item == "1")
                    {
                        number += 1 << k;
                        csv += props[k] + " "; 
                    }
                }
                writer_scale.WriteLine(number.ToString());
                listBoxDB.Items.Add(number.ToString());
                writer_csv.WriteLine(csv); 
            }
            reader.Close();
            writer_scale.Close();
            writer_csv.Close();
        }
    }
}
