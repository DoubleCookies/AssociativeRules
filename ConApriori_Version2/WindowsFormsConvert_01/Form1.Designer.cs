namespace WindowsFormsConvert_01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourceDB = new System.Windows.Forms.TextBox();
            this.textBoxResultDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxProps = new System.Windows.Forms.ListBox();
            this.listBoxDB = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonShowProps = new System.Windows.Forms.Button();
            this.buttonResultPathes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Конвертирование базы данных в бинарном формате 0 -1\r\n в формат scale и csv\r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "путь к исходной базе";
            // 
            // textBoxSourceDB
            // 
            this.textBoxSourceDB.Location = new System.Drawing.Point(209, 115);
            this.textBoxSourceDB.Name = "textBoxSourceDB";
            this.textBoxSourceDB.Size = new System.Drawing.Size(193, 20);
            this.textBoxSourceDB.TabIndex = 2;
            // 
            // textBoxResultDB
            // 
            this.textBoxResultDB.Location = new System.Drawing.Point(209, 156);
            this.textBoxResultDB.Name = "textBoxResultDB";
            this.textBoxResultDB.Size = new System.Drawing.Size(193, 20);
            this.textBoxResultDB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "путь к результирующей базе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Свойства";
            // 
            // listBoxProps
            // 
            this.listBoxProps.FormattingEnabled = true;
            this.listBoxProps.Location = new System.Drawing.Point(533, 139);
            this.listBoxProps.Name = "listBoxProps";
            this.listBoxProps.Size = new System.Drawing.Size(162, 251);
            this.listBoxProps.TabIndex = 6;
            // 
            // listBoxDB
            // 
            this.listBoxDB.FormattingEnabled = true;
            this.listBoxDB.Location = new System.Drawing.Point(32, 302);
            this.listBoxDB.Name = "listBoxDB";
            this.listBoxDB.Size = new System.Drawing.Size(431, 199);
            this.listBoxDB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "База данных";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(549, 469);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(117, 32);
            this.buttonConvert.TabIndex = 9;
            this.buttonConvert.Text = "Convert DB";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.Location = new System.Drawing.Point(53, 200);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(101, 41);
            this.buttonOpenDB.TabIndex = 10;
            this.buttonOpenDB.Text = "Enter Source_Path";
            this.buttonOpenDB.UseVisualStyleBackColor = true;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonShowProps
            // 
            this.buttonShowProps.Location = new System.Drawing.Point(549, 408);
            this.buttonShowProps.Name = "buttonShowProps";
            this.buttonShowProps.Size = new System.Drawing.Size(117, 32);
            this.buttonShowProps.TabIndex = 11;
            this.buttonShowProps.Text = "Show Properties";
            this.buttonShowProps.UseVisualStyleBackColor = true;
            this.buttonShowProps.Click += new System.EventHandler(this.buttonShowProps_Click);
            // 
            // buttonResultPathes
            // 
            this.buttonResultPathes.Location = new System.Drawing.Point(284, 200);
            this.buttonResultPathes.Name = "buttonResultPathes";
            this.buttonResultPathes.Size = new System.Drawing.Size(101, 41);
            this.buttonResultPathes.TabIndex = 12;
            this.buttonResultPathes.Text = "Enter Result_Pathes";
            this.buttonResultPathes.UseVisualStyleBackColor = true;
            this.buttonResultPathes.Click += new System.EventHandler(this.buttonResultPathes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 547);
            this.Controls.Add(this.buttonResultPathes);
            this.Controls.Add(this.buttonShowProps);
            this.Controls.Add(this.buttonOpenDB);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.listBoxDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxProps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResultDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSourceDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSourceDB;
        private System.Windows.Forms.TextBox textBoxResultDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxProps;
        private System.Windows.Forms.ListBox listBoxDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonShowProps;
        private System.Windows.Forms.Button buttonResultPathes;
    }
}

