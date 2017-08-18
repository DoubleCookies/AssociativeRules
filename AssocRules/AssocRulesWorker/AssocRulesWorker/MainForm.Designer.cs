namespace AssocRulesWorker
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxHi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStep2 = new System.Windows.Forms.Button();
            this.buttonStep3 = new System.Windows.Forms.Button();
            this.buttonStep4 = new System.Windows.Forms.Button();
            this.buttonStep5 = new System.Windows.Forms.Button();
            this.buttonSecondBase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxHi
            // 
            this.richTextBoxHi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxHi.Location = new System.Drawing.Point(26, 21);
            this.richTextBoxHi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxHi.Name = "richTextBoxHi";
            this.richTextBoxHi.Size = new System.Drawing.Size(631, 149);
            this.richTextBoxHi.TabIndex = 1;
            this.richTextBoxHi.Text = resources.GetString("richTextBoxHi.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Преобразование свойств в csv-файле к бинарному виду";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Преобразование csv-файла с бинарными свойствами в шкалу (scale)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "4. Поиск ассоциативных правил в scale-файле";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "5. Расшифровка полученных результатов";
            // 
            // buttonStep2
            // 
            this.buttonStep2.Location = new System.Drawing.Point(481, 223);
            this.buttonStep2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStep2.Name = "buttonStep2";
            this.buttonStep2.Size = new System.Drawing.Size(142, 22);
            this.buttonStep2.TabIndex = 8;
            this.buttonStep2.Text = "Выполнить";
            this.buttonStep2.UseVisualStyleBackColor = true;
            this.buttonStep2.Click += new System.EventHandler(this.buttonStep2_Click);
            // 
            // buttonStep3
            // 
            this.buttonStep3.Location = new System.Drawing.Point(481, 278);
            this.buttonStep3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStep3.Name = "buttonStep3";
            this.buttonStep3.Size = new System.Drawing.Size(142, 22);
            this.buttonStep3.TabIndex = 9;
            this.buttonStep3.Text = "Выполнить";
            this.buttonStep3.UseVisualStyleBackColor = true;
            this.buttonStep3.Click += new System.EventHandler(this.buttonStep3_Click);
            // 
            // buttonStep4
            // 
            this.buttonStep4.Location = new System.Drawing.Point(481, 307);
            this.buttonStep4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStep4.Name = "buttonStep4";
            this.buttonStep4.Size = new System.Drawing.Size(142, 22);
            this.buttonStep4.TabIndex = 10;
            this.buttonStep4.Text = "Выполнить";
            this.buttonStep4.UseVisualStyleBackColor = true;
            this.buttonStep4.Click += new System.EventHandler(this.buttonStep4_Click);
            // 
            // buttonStep5
            // 
            this.buttonStep5.Location = new System.Drawing.Point(481, 337);
            this.buttonStep5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStep5.Name = "buttonStep5";
            this.buttonStep5.Size = new System.Drawing.Size(142, 22);
            this.buttonStep5.TabIndex = 11;
            this.buttonStep5.Text = "Выполнить";
            this.buttonStep5.UseVisualStyleBackColor = true;
            this.buttonStep5.Click += new System.EventHandler(this.buttonStep5_Click);
            // 
            // buttonSecondBase
            // 
            this.buttonSecondBase.Location = new System.Drawing.Point(481, 251);
            this.buttonSecondBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSecondBase.Name = "buttonSecondBase";
            this.buttonSecondBase.Size = new System.Drawing.Size(142, 21);
            this.buttonSecondBase.TabIndex = 12;
            this.buttonSecondBase.Text = "Выполнить";
            this.buttonSecondBase.UseVisualStyleBackColor = true;
            this.buttonSecondBase.Click += new System.EventHandler(this.buttonSecondBase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "2.2. Вторая база!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSecondBase);
            this.Controls.Add(this.buttonStep5);
            this.Controls.Add(this.buttonStep4);
            this.Controls.Add(this.buttonStep3);
            this.Controls.Add(this.buttonStep2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxHi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Анализ и преобразование базы данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStep2;
        private System.Windows.Forms.Button buttonStep3;
        private System.Windows.Forms.Button buttonStep4;
        private System.Windows.Forms.Button buttonStep5;
        private System.Windows.Forms.Button buttonSecondBase;
        private System.Windows.Forms.Label label6;
    }
}

