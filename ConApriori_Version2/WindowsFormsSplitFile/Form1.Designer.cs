namespace WindowsFormsSplitFile
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSplitFile = new System.Windows.Forms.Button();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourcePath = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxCategorylength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateGategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расщепление файла на подфайлы длины n\r\nСоздание файла категорий";
            // 
            // buttonSplitFile
            // 
            this.buttonSplitFile.Location = new System.Drawing.Point(482, 183);
            this.buttonSplitFile.Name = "buttonSplitFile";
            this.buttonSplitFile.Size = new System.Drawing.Size(96, 43);
            this.buttonSplitFile.TabIndex = 1;
            this.buttonSplitFile.Text = "Split File";
            this.buttonSplitFile.UseVisualStyleBackColor = true;
            this.buttonSplitFile.Click += new System.EventHandler(this.buttonSplitFile_Click);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(45, 72);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(96, 43);
            this.buttonChooseFile.TabIndex = 2;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к файлу";
            // 
            // textBoxSourcePath
            // 
            this.textBoxSourcePath.Location = new System.Drawing.Point(19, 169);
            this.textBoxSourcePath.Multiline = true;
            this.textBoxSourcePath.Name = "textBoxSourcePath";
            this.textBoxSourcePath.Size = new System.Drawing.Size(207, 57);
            this.textBoxSourcePath.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(167, 290);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(251, 57);
            this.textBoxMessage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат операции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число записей подфайла";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(470, 139);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(108, 20);
            this.textBoxN.TabIndex = 8;
            this.textBoxN.Text = "10000";
            // 
            // textBoxCategorylength
            // 
            this.textBoxCategorylength.Location = new System.Drawing.Point(266, 139);
            this.textBoxCategorylength.Name = "textBoxCategorylength";
            this.textBoxCategorylength.Size = new System.Drawing.Size(137, 20);
            this.textBoxCategorylength.TabIndex = 11;
            this.textBoxCategorylength.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длина кода категории";
            // 
            // buttonCreateGategory
            // 
            this.buttonCreateGategory.Location = new System.Drawing.Point(278, 183);
            this.buttonCreateGategory.Name = "buttonCreateGategory";
            this.buttonCreateGategory.Size = new System.Drawing.Size(125, 43);
            this.buttonCreateGategory.TabIndex = 9;
            this.buttonCreateGategory.Text = "Create Category File";
            this.buttonCreateGategory.UseVisualStyleBackColor = true;
            this.buttonCreateGategory.Click += new System.EventHandler(this.buttonCreateGategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 371);
            this.Controls.Add(this.textBoxCategorylength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreateGategory);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSourcePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.buttonSplitFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSplitFile;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSourcePath;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxCategorylength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateGategory;
    }
}

