namespace WindowsFormsConverter
{
    partial class CSV_ScaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSV_ScaleForm));
            this.textBoxDeclaration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTimeConvert = new System.Windows.Forms.TextBox();
            this.textBoxFragmentLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonNorma = new System.Windows.Forms.RadioButton();
            this.radioButtonReplica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReplica = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDeclaration
            // 
            this.textBoxDeclaration.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeclaration.Location = new System.Drawing.Point(73, 15);
            this.textBoxDeclaration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeclaration.Multiline = true;
            this.textBoxDeclaration.Name = "textBoxDeclaration";
            this.textBoxDeclaration.Size = new System.Drawing.Size(719, 222);
            this.textBoxDeclaration.TabIndex = 0;
            this.textBoxDeclaration.Text = resources.GetString("textBoxDeclaration.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время конвертирования";
            // 
            // textBoxTimeConvert
            // 
            this.textBoxTimeConvert.Location = new System.Drawing.Point(244, 277);
            this.textBoxTimeConvert.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimeConvert.Name = "textBoxTimeConvert";
            this.textBoxTimeConvert.Size = new System.Drawing.Size(192, 22);
            this.textBoxTimeConvert.TabIndex = 2;
            // 
            // textBoxFragmentLength
            // 
            this.textBoxFragmentLength.Location = new System.Drawing.Point(43, 368);
            this.textBoxFragmentLength.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFragmentLength.Name = "textBoxFragmentLength";
            this.textBoxFragmentLength.Size = new System.Drawing.Size(139, 22);
            this.textBoxFragmentLength.TabIndex = 6;
            this.textBoxFragmentLength.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина фрагмента";
            // 
            // radioButtonNorma
            // 
            this.radioButtonNorma.AutoSize = true;
            this.radioButtonNorma.Checked = true;
            this.radioButtonNorma.Location = new System.Drawing.Point(31, 26);
            this.radioButtonNorma.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNorma.Name = "radioButtonNorma";
            this.radioButtonNorma.Size = new System.Drawing.Size(71, 21);
            this.radioButtonNorma.TabIndex = 7;
            this.radioButtonNorma.TabStop = true;
            this.radioButtonNorma.Text = "Norma";
            this.radioButtonNorma.UseVisualStyleBackColor = true;
            // 
            // radioButtonReplica
            // 
            this.radioButtonReplica.AutoSize = true;
            this.radioButtonReplica.Location = new System.Drawing.Point(31, 54);
            this.radioButtonReplica.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonReplica.Name = "radioButtonReplica";
            this.radioButtonReplica.Size = new System.Drawing.Size(76, 21);
            this.radioButtonReplica.TabIndex = 8;
            this.radioButtonReplica.Text = "Replica";
            this.radioButtonReplica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReplica);
            this.groupBox1.Controls.Add(this.radioButtonReplica);
            this.groupBox1.Controls.Add(this.radioButtonNorma);
            this.groupBox1.Location = new System.Drawing.Point(252, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // textBoxReplica
            // 
            this.textBoxReplica.Location = new System.Drawing.Point(188, 38);
            this.textBoxReplica.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReplica.Name = "textBoxReplica";
            this.textBoxReplica.Size = new System.Drawing.Size(120, 22);
            this.textBoxReplica.TabIndex = 10;
            this.textBoxReplica.Text = "10";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(516, 265);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(203, 44);
            this.buttonConvert.TabIndex = 11;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(244, 464);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(475, 120);
            this.textBoxMessage.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сообщение";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CSV_ScaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 613);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFragmentLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDeclaration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CSV_ScaleForm";
            this.Text = "FormConvert_new";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeclaration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTimeConvert;
        private System.Windows.Forms.TextBox textBoxFragmentLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonNorma;
        private System.Windows.Forms.RadioButton radioButtonReplica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxReplica;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}