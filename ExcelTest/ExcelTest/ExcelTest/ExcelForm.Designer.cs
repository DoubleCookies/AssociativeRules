namespace ExcelTest
{
    partial class ExcelForm
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxoutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxRes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSheet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(373, 260);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(332, 52);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть *.xls";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBoxoutput
            // 
            this.richTextBoxoutput.Location = new System.Drawing.Point(12, 75);
            this.richTextBoxoutput.Name = "richTextBoxoutput";
            this.richTextBoxoutput.ReadOnly = true;
            this.richTextBoxoutput.Size = new System.Drawing.Size(332, 279);
            this.richTextBoxoutput.TabIndex = 2;
            this.richTextBoxoutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Содержимое файла";
            // 
            // richTextBoxRes
            // 
            this.richTextBoxRes.Location = new System.Drawing.Point(387, 75);
            this.richTextBoxRes.Name = "richTextBoxRes";
            this.richTextBoxRes.Size = new System.Drawing.Size(254, 87);
            this.richTextBoxRes.TabIndex = 4;
            this.richTextBoxRes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат выполнения";
            // 
            // textBoxSheet
            // 
            this.textBoxSheet.Location = new System.Drawing.Point(525, 208);
            this.textBoxSheet.Name = "textBoxSheet";
            this.textBoxSheet.Size = new System.Drawing.Size(131, 22);
            this.textBoxSheet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер листа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxoutput);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "ExcelTranfrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSheet;
        private System.Windows.Forms.Label label3;
    }
}

