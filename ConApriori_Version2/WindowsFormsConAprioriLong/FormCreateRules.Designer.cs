namespace WindowsFormsConAprioriLong
{
    partial class FormCreateRules
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
            this.buttonGotoRules = new System.Windows.Forms.Button();
            this.buttonCreateRules = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSupport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowBD = new System.Windows.Forms.Button();
            this.buttonLinkDB = new System.Windows.Forms.Button();
            this.buttonParameters = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxDB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDB_Name = new System.Windows.Forms.TextBox();
            this.buttonChooseDB = new System.Windows.Forms.Button();
            this.listBoxFactors = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGotoRules
            // 
            this.buttonGotoRules.Location = new System.Drawing.Point(570, 311);
            this.buttonGotoRules.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGotoRules.Name = "buttonGotoRules";
            this.buttonGotoRules.Size = new System.Drawing.Size(193, 25);
            this.buttonGotoRules.TabIndex = 39;
            this.buttonGotoRules.Text = "Перейти к работе с правилами";
            this.buttonGotoRules.UseVisualStyleBackColor = true;
            this.buttonGotoRules.Click += new System.EventHandler(this.buttonGotoRules_Click);
            // 
            // buttonCreateRules
            // 
            this.buttonCreateRules.Location = new System.Drawing.Point(417, 304);
            this.buttonCreateRules.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateRules.Name = "buttonCreateRules";
            this.buttonCreateRules.Size = new System.Drawing.Size(72, 39);
            this.buttonCreateRules.TabIndex = 38;
            this.buttonCreateRules.Text = "Построить правила";
            this.buttonCreateRules.UseVisualStyleBackColor = true;
            this.buttonCreateRules.Click += new System.EventHandler(this.buttonCreateRules_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(178, 382);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(504, 48);
            this.textBoxMessage.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Сообщения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "База данных";
            // 
            // textBoxQuality
            // 
            this.textBoxQuality.Location = new System.Drawing.Point(160, 65);
            this.textBoxQuality.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuality.Name = "textBoxQuality";
            this.textBoxQuality.Size = new System.Drawing.Size(37, 20);
            this.textBoxQuality.TabIndex = 7;
            this.textBoxQuality.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Достоверность правила >=";
            // 
            // textBoxSupport
            // 
            this.textBoxSupport.Location = new System.Drawing.Point(123, 27);
            this.textBoxSupport.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSupport.Name = "textBoxSupport";
            this.textBoxSupport.Size = new System.Drawing.Size(56, 20);
            this.textBoxSupport.TabIndex = 5;
            this.textBoxSupport.Text = "0,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Частота правила >=";
            // 
            // buttonShowBD
            // 
            this.buttonShowBD.Location = new System.Drawing.Point(279, 304);
            this.buttonShowBD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowBD.Name = "buttonShowBD";
            this.buttonShowBD.Size = new System.Drawing.Size(76, 39);
            this.buttonShowBD.TabIndex = 37;
            this.buttonShowBD.Text = "Показать БД";
            this.buttonShowBD.UseVisualStyleBackColor = true;
            this.buttonShowBD.Click += new System.EventHandler(this.buttonShowBD_Click);
            // 
            // buttonLinkDB
            // 
            this.buttonLinkDB.Location = new System.Drawing.Point(101, 297);
            this.buttonLinkDB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLinkDB.Name = "buttonLinkDB";
            this.buttonLinkDB.Size = new System.Drawing.Size(82, 39);
            this.buttonLinkDB.TabIndex = 36;
            this.buttonLinkDB.Text = "Связаться с БД";
            this.buttonLinkDB.UseVisualStyleBackColor = true;
            this.buttonLinkDB.Click += new System.EventHandler(this.buttonLinkDB_Click);
            // 
            // buttonParameters
            // 
            this.buttonParameters.Location = new System.Drawing.Point(30, 99);
            this.buttonParameters.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParameters.Name = "buttonParameters";
            this.buttonParameters.Size = new System.Drawing.Size(99, 39);
            this.buttonParameters.TabIndex = 15;
            this.buttonParameters.Text = "Задать характеристики";
            this.buttonParameters.UseVisualStyleBackColor = true;
            this.buttonParameters.Click += new System.EventHandler(this.buttonParameters_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxQuality);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxSupport);
            this.groupBox2.Controls.Add(this.buttonParameters);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(279, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(210, 155);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики правил";
            // 
            // listBoxDB
            // 
            this.listBoxDB.FormattingEnabled = true;
            this.listBoxDB.Location = new System.Drawing.Point(178, 448);
            this.listBoxDB.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDB.Name = "listBoxDB";
            this.listBoxDB.Size = new System.Drawing.Size(504, 238);
            this.listBoxDB.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, -32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Факторы";
            // 
            // textBoxDB_Name
            // 
            this.textBoxDB_Name.Location = new System.Drawing.Point(22, 30);
            this.textBoxDB_Name.Multiline = true;
            this.textBoxDB_Name.Name = "textBoxDB_Name";
            this.textBoxDB_Name.Size = new System.Drawing.Size(160, 55);
            this.textBoxDB_Name.TabIndex = 0;
            // 
            // buttonChooseDB
            // 
            this.buttonChooseDB.Location = new System.Drawing.Point(35, 99);
            this.buttonChooseDB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseDB.Name = "buttonChooseDB";
            this.buttonChooseDB.Size = new System.Drawing.Size(87, 39);
            this.buttonChooseDB.TabIndex = 3;
            this.buttonChooseDB.Text = "Выбрать базу";
            this.buttonChooseDB.UseVisualStyleBackColor = true;
            this.buttonChooseDB.Click += new System.EventHandler(this.buttonChooseDB_Click);
            // 
            // listBoxFactors
            // 
            this.listBoxFactors.FormattingEnabled = true;
            this.listBoxFactors.Location = new System.Drawing.Point(523, 109);
            this.listBoxFactors.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFactors.Name = "listBoxFactors";
            this.listBoxFactors.Size = new System.Drawing.Size(240, 147);
            this.listBoxFactors.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDB_Name);
            this.groupBox1.Controls.Add(this.buttonChooseDB);
            this.groupBox1.Location = new System.Drawing.Point(61, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(187, 155);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " База данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, -73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Извлечение ассоциативных правил\r\n                 из базы данных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(276, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 34);
            this.label7.TabIndex = 40;
            this.label7.Text = "Извлечение ассоциативных правил\r\n                 из базы данных";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCreateRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 697);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGotoRules);
            this.Controls.Add(this.buttonCreateRules);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonShowBD);
            this.Controls.Add(this.buttonLinkDB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFactors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateRules";
            this.Text = "FormCreateRules";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGotoRules;
        private System.Windows.Forms.Button buttonCreateRules;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSupport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowBD;
        private System.Windows.Forms.Button buttonLinkDB;
        private System.Windows.Forms.Button buttonParameters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDB_Name;
        private System.Windows.Forms.Button buttonChooseDB;
        private System.Windows.Forms.ListBox listBoxFactors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

