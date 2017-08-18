using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sheet = 0;
            try
            {
                sheet = int.Parse(textBoxSheet.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите номер листа!");
                return;
            }
            string filename="";
            OpenFileDialog openF = new OpenFileDialog();
            if (openF.ShowDialog() == DialogResult.OK)
                filename = openF.FileName.ToString();
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false; // Отвечает за то, будет ли видимо приложение
            excelApp.Workbooks.Open(filename);
            Excel.Workbook workbook = excelApp.Workbooks[1];
            Excel.Worksheet currentSheet = workbook.Worksheets.get_Item(sheet);
            int row = 0;
            int columnmax = 0;
            int column = 1;
            List<List<string>> maping = new List<List<string>>();
            Excel.Range startCell;
            startCell = currentSheet.get_Range(ColumnIndexToColumnLetter(1) + 1);
            bool cont = true;
            if(startCell.Text == "*")
                cont = false;
            bool colcount = true;
            while (colcount)
            {
                Excel.Range cell;
                cell = currentSheet.get_Range(ColumnIndexToColumnLetter(columnmax+1) + 1);
                if (cell.Text == "*")
                    colcount = false;
                columnmax++;
                if (columnmax > 1000)
                {
                    excelApp.Quit();
                    MessageBox.Show("Разбор файла не был произведен - не найдена граница");
                    richTextBoxRes.Text = "Разбор файла не был произведён - не найдена граница файла";
                    return;
                }
            }
            while (cont)
            {
                row++;
                Excel.Range cell;
                cell = currentSheet.get_Range(ColumnIndexToColumnLetter(1) + row);
                if (cell.Text == "*")
                    break;
                List<string> tempList = new List<string>();
                for (column = 1; column < columnmax; column++)
                {
                    cell = currentSheet.get_Range(ColumnIndexToColumnLetter(column) + row);
                    string a = cell.Text;
                    tempList.Add(a != "" ? a.ToString() : "0");
                    
                }
                maping.Add(tempList);
            }
            string ff="";
            excelApp.Quit();
            string add = "";
            for (int i = 0; i < maping.Count; i++)
            {
                for (int j = 0; j < maping[i].Count-1; j++)
                {
                    add = maping[i][j].ToString() + ";";
                    ff += add;
                }
                ff += maping[i][maping[i].Count - 1].ToString() + "\r\n";
            }
            richTextBoxoutput.Text = ff;
            saveFileDialog1.Filter = "CSV Files|*.csv|All Files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name,ff, Encoding.UTF8);
            richTextBoxRes.Text = "Трансформирование файла было успешно произведено и сохранено по адресу " + name;
        }

        /// <summary>
        /// Метод позволяет верно задавать буквы для поиска ячейки в таблице
        /// </summary>
        /// <param name="colIndex">Номер столбца</param>
        /// <returns>Возвращает буквенное представление номера столбца</returns>
        string ColumnIndexToColumnLetter(int colIndex)
        {
            int div = colIndex;
            string colLetter = String.Empty;
            int mod = 0;

            while (div > 0)
            {
                mod = (div - 1) % 26;
                colLetter = (char)(65 + mod) + colLetter;
                div = (int)((div - mod) / 26);
            }
            return colLetter;
        }
    }
}
