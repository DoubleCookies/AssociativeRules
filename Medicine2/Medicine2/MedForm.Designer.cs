namespace Medicine2
{
    partial class MedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedForm));
            this.buttonShifrGen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonSecondQ = new System.Windows.Forms.Button();
            this.textBoxReader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFirstQ = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonShifrGen
            // 
            this.buttonShifrGen.Location = new System.Drawing.Point(632, 373);
            this.buttonShifrGen.Name = "buttonShifrGen";
            this.buttonShifrGen.Size = new System.Drawing.Size(230, 39);
            this.buttonShifrGen.TabIndex = 20;
            this.buttonShifrGen.Text = "Создание файла расшифровок";
            this.buttonShifrGen.UseVisualStyleBackColor = true;
            this.buttonShifrGen.Click += new System.EventHandler(this.buttonShifrGen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вход";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(498, 105);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(364, 253);
            this.richTextBoxOutput.TabIndex = 17;
            this.richTextBoxOutput.Text = "";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(48, 105);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(362, 253);
            this.richTextBoxInput.TabIndex = 16;
            this.richTextBoxInput.Text = "";
            // 
            // buttonSecondQ
            // 
            this.buttonSecondQ.Location = new System.Drawing.Point(337, 373);
            this.buttonSecondQ.Name = "buttonSecondQ";
            this.buttonSecondQ.Size = new System.Drawing.Size(269, 39);
            this.buttonSecondQ.TabIndex = 15;
            this.buttonSecondQ.Text = "Преобразование БД  второго вопроса";
            this.buttonSecondQ.UseVisualStyleBackColor = true;
            this.buttonSecondQ.Click += new System.EventHandler(this.buttonSecondQ_Click);
            // 
            // textBoxReader
            // 
            this.textBoxReader.Location = new System.Drawing.Point(167, 39);
            this.textBoxReader.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReader.Name = "textBoxReader";
            this.textBoxReader.Size = new System.Drawing.Size(490, 22);
            this.textBoxReader.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь файла";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonFirstQ
            // 
            this.buttonFirstQ.Location = new System.Drawing.Point(48, 373);
            this.buttonFirstQ.Name = "buttonFirstQ";
            this.buttonFirstQ.Size = new System.Drawing.Size(272, 39);
            this.buttonFirstQ.TabIndex = 21;
            this.buttonFirstQ.Text = "Преобразование БД первого вопроса";
            this.buttonFirstQ.UseVisualStyleBackColor = true;
            this.buttonFirstQ.Click += new System.EventHandler(this.buttonFirstQ_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(48, 441);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(814, 123);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonFirstQ);
            this.Controls.Add(this.buttonShifrGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonSecondQ);
            this.Controls.Add(this.textBoxReader);
            this.Controls.Add(this.label1);
            this.Name = "MedForm";
            this.Text = "BinaryTransform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShifrGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonSecondQ;
        private System.Windows.Forms.TextBox textBoxReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFirstQ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

