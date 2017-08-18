namespace Medicine2
{
    partial class SecondBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondBaseForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxReader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonFirstGroup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSecShifr = new System.Windows.Forms.Button();
            this.buttonQ1 = new System.Windows.Forms.Button();
            this.buttonQ4 = new System.Windows.Forms.Button();
            this.buttonQ6 = new System.Windows.Forms.Button();
            this.buttonQ7 = new System.Windows.Forms.Button();
            this.buttonQ8 = new System.Windows.Forms.Button();
            this.buttonQ9 = new System.Windows.Forms.Button();
            this.buttonFifthQuestion = new System.Windows.Forms.Button();
            this.buttonQ2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Выход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Вход";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(340, 63);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(274, 206);
            this.richTextBoxOutput.TabIndex = 23;
            this.richTextBoxOutput.Text = "";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(22, 63);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(272, 206);
            this.richTextBoxInput.TabIndex = 22;
            this.richTextBoxInput.Text = "";
            // 
            // textBoxReader
            // 
            this.textBoxReader.Location = new System.Drawing.Point(92, 9);
            this.textBoxReader.Name = "textBoxReader";
            this.textBoxReader.Size = new System.Drawing.Size(368, 20);
            this.textBoxReader.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Путь файла";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 389);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 101);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonFirstGroup
            // 
            this.buttonFirstGroup.Location = new System.Drawing.Point(27, 334);
            this.buttonFirstGroup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirstGroup.Name = "buttonFirstGroup";
            this.buttonFirstGroup.Size = new System.Drawing.Size(145, 23);
            this.buttonFirstGroup.TabIndex = 27;
            this.buttonFirstGroup.Text = "Группа №3";
            this.buttonFirstGroup.UseVisualStyleBackColor = true;
            this.buttonFirstGroup.Click += new System.EventHandler(this.buttonFirstGroup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSecShifr
            // 
            this.buttonSecShifr.Location = new System.Drawing.Point(489, 273);
            this.buttonSecShifr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSecShifr.Name = "buttonSecShifr";
            this.buttonSecShifr.Size = new System.Drawing.Size(124, 33);
            this.buttonSecShifr.TabIndex = 28;
            this.buttonSecShifr.Text = "Расшифровки";
            this.buttonSecShifr.UseVisualStyleBackColor = true;
            this.buttonSecShifr.Click += new System.EventHandler(this.ButtonSecShifr_Click);
            // 
            // buttonQ1
            // 
            this.buttonQ1.Location = new System.Drawing.Point(27, 278);
            this.buttonQ1.Name = "buttonQ1";
            this.buttonQ1.Size = new System.Drawing.Size(145, 23);
            this.buttonQ1.TabIndex = 29;
            this.buttonQ1.Text = " Группа №1";
            this.buttonQ1.UseVisualStyleBackColor = true;
            this.buttonQ1.Click += new System.EventHandler(this.buttonQ1_Click);
            // 
            // buttonQ4
            // 
            this.buttonQ4.Location = new System.Drawing.Point(189, 278);
            this.buttonQ4.Name = "buttonQ4";
            this.buttonQ4.Size = new System.Drawing.Size(145, 23);
            this.buttonQ4.TabIndex = 30;
            this.buttonQ4.Text = " Группа №4";
            this.buttonQ4.UseVisualStyleBackColor = true;
            this.buttonQ4.Click += new System.EventHandler(this.buttonQ4_Click);
            // 
            // buttonQ6
            // 
            this.buttonQ6.Location = new System.Drawing.Point(189, 334);
            this.buttonQ6.Name = "buttonQ6";
            this.buttonQ6.Size = new System.Drawing.Size(145, 23);
            this.buttonQ6.TabIndex = 31;
            this.buttonQ6.Text = " Группа №6";
            this.buttonQ6.UseVisualStyleBackColor = true;
            this.buttonQ6.Click += new System.EventHandler(this.buttonQ6_Click);
            // 
            // buttonQ7
            // 
            this.buttonQ7.Location = new System.Drawing.Point(340, 278);
            this.buttonQ7.Name = "buttonQ7";
            this.buttonQ7.Size = new System.Drawing.Size(145, 23);
            this.buttonQ7.TabIndex = 32;
            this.buttonQ7.Text = " Группа №7";
            this.buttonQ7.UseVisualStyleBackColor = true;
            this.buttonQ7.Click += new System.EventHandler(this.buttonQ7_Click);
            // 
            // buttonQ8
            // 
            this.buttonQ8.Location = new System.Drawing.Point(339, 307);
            this.buttonQ8.Name = "buttonQ8";
            this.buttonQ8.Size = new System.Drawing.Size(145, 23);
            this.buttonQ8.TabIndex = 33;
            this.buttonQ8.Text = " Группа №8";
            this.buttonQ8.UseVisualStyleBackColor = true;
            this.buttonQ8.Click += new System.EventHandler(this.buttonQ8_Click);
            // 
            // buttonQ9
            // 
            this.buttonQ9.Location = new System.Drawing.Point(340, 334);
            this.buttonQ9.Name = "buttonQ9";
            this.buttonQ9.Size = new System.Drawing.Size(145, 23);
            this.buttonQ9.TabIndex = 34;
            this.buttonQ9.Text = " Группа №9";
            this.buttonQ9.UseVisualStyleBackColor = true;
            this.buttonQ9.Click += new System.EventHandler(this.buttonQ9_Click);
            // 
            // buttonFifthQuestion
            // 
            this.buttonFifthQuestion.Location = new System.Drawing.Point(189, 307);
            this.buttonFifthQuestion.Name = "buttonFifthQuestion";
            this.buttonFifthQuestion.Size = new System.Drawing.Size(145, 23);
            this.buttonFifthQuestion.TabIndex = 35;
            this.buttonFifthQuestion.Text = " Группа №5";
            this.buttonFifthQuestion.UseVisualStyleBackColor = true;
            this.buttonFifthQuestion.Click += new System.EventHandler(this.buttonFifthQuestion_Click);
            // 
            // buttonQ2
            // 
            this.buttonQ2.Location = new System.Drawing.Point(27, 307);
            this.buttonQ2.Name = "buttonQ2";
            this.buttonQ2.Size = new System.Drawing.Size(145, 23);
            this.buttonQ2.TabIndex = 36;
            this.buttonQ2.Text = " Группа №2";
            this.buttonQ2.UseVisualStyleBackColor = true;
            this.buttonQ2.Click += new System.EventHandler(this.buttonQ2_Click);
            // 
            // SecondBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 488);
            this.Controls.Add(this.buttonQ2);
            this.Controls.Add(this.buttonFifthQuestion);
            this.Controls.Add(this.buttonQ9);
            this.Controls.Add(this.buttonQ8);
            this.Controls.Add(this.buttonQ7);
            this.Controls.Add(this.buttonQ6);
            this.Controls.Add(this.buttonQ4);
            this.Controls.Add(this.buttonQ1);
            this.Controls.Add(this.buttonSecShifr);
            this.Controls.Add(this.buttonFirstGroup);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.textBoxReader);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SecondBaseForm";
            this.Text = "SecondBaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.TextBox textBoxReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonFirstGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSecShifr;
        private System.Windows.Forms.Button buttonQ1;
        private System.Windows.Forms.Button buttonQ4;
        private System.Windows.Forms.Button buttonQ6;
        private System.Windows.Forms.Button buttonQ7;
        private System.Windows.Forms.Button buttonQ8;
        private System.Windows.Forms.Button buttonQ9;
        private System.Windows.Forms.Button buttonFifthQuestion;
        private System.Windows.Forms.Button buttonQ2;
    }
}