namespace WindowsFormsModel
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
            this.textBoxN_tr = new System.Windows.Forms.TextBox();
            this.textBoxM_gr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxLen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonModelDB = new System.Windows.Forms.Button();
            this.buttonModelDB_test = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(224, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание модельной базы данных \r\nЭксперименты  с частыми наборами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N - число транзакций";
            // 
            // textBoxN_tr
            // 
            this.textBoxN_tr.Location = new System.Drawing.Point(200, 30);
            this.textBoxN_tr.Name = "textBoxN_tr";
            this.textBoxN_tr.Size = new System.Drawing.Size(100, 20);
            this.textBoxN_tr.TabIndex = 2;
            this.textBoxN_tr.Text = "100000";
            // 
            // textBoxM_gr
            // 
            this.textBoxM_gr.Location = new System.Drawing.Point(200, 86);
            this.textBoxM_gr.Name = "textBoxM_gr";
            this.textBoxM_gr.Size = new System.Drawing.Size(100, 20);
            this.textBoxM_gr.TabIndex = 4;
            this.textBoxM_gr.Text = "50 25 15 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "M- число элементов в группе";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(200, 136);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroup.TabIndex = 6;
            this.textBoxGroup.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "N - число групп";
            // 
            // textBoxMaxLen
            // 
            this.textBoxMaxLen.Location = new System.Drawing.Point(200, 183);
            this.textBoxMaxLen.Name = "textBoxMaxLen";
            this.textBoxMaxLen.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxLen.TabIndex = 8;
            this.textBoxMaxLen.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max_len - макс длина транзакции";
            // 
            // textBoxPR
            // 
            this.textBoxPR.Location = new System.Drawing.Point(200, 234);
            this.textBoxPR.Name = "textBoxPR";
            this.textBoxPR.Size = new System.Drawing.Size(100, 20);
            this.textBoxPR.TabIndex = 10;
            this.textBoxPR.Text = "5 10 15 70";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pr - вероятности групп в процентах";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(116, 275);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(184, 20);
            this.textBoxPath.TabIndex = 12;
            this.textBoxPath.Text = "E:\\Apriori_DataBase\\Model_DB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "путь к базе данных";
            // 
            // buttonModelDB
            // 
            this.buttonModelDB.Location = new System.Drawing.Point(18, 321);
            this.buttonModelDB.Name = "buttonModelDB";
            this.buttonModelDB.Size = new System.Drawing.Size(102, 49);
            this.buttonModelDB.TabIndex = 13;
            this.buttonModelDB.Text = "Create Model DB";
            this.buttonModelDB.UseVisualStyleBackColor = true;
            this.buttonModelDB.Click += new System.EventHandler(this.buttonModelDB_Click);
            // 
            // buttonModelDB_test
            // 
            this.buttonModelDB_test.Location = new System.Drawing.Point(175, 321);
            this.buttonModelDB_test.Name = "buttonModelDB_test";
            this.buttonModelDB_test.Size = new System.Drawing.Size(102, 49);
            this.buttonModelDB_test.TabIndex = 14;
            this.buttonModelDB_test.Text = "Create Model DB Test";
            this.buttonModelDB_test.UseVisualStyleBackColor = true;
            this.buttonModelDB_test.Click += new System.EventHandler(this.buttonModelDB_test_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMessage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonModelDB_test);
            this.groupBox1.Controls.Add(this.buttonModelDB);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMaxLen);
            this.groupBox1.Controls.Add(this.textBoxGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxM_gr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxN_tr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 435);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model DB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Len -макс. длина транзакции";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Сообщение";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(89, 400);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(211, 20);
            this.textBoxMessage.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxN_tr;
        private System.Windows.Forms.TextBox textBoxM_gr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxLen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonModelDB;
        private System.Windows.Forms.Button buttonModelDB_test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

