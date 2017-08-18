namespace WindowsFormsConAprioriPar
{
    partial class FormShowRules
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
            this.textBoxNRules = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLift_min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowRules = new System.Windows.Forms.Button();
            this.buttonSaveRules = new System.Windows.Forms.Button();
            this.listBoxRules = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNRules
            // 
            this.textBoxNRules.Location = new System.Drawing.Point(745, 388);
            this.textBoxNRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNRules.Name = "textBoxNRules";
            this.textBoxNRules.Size = new System.Drawing.Size(87, 22);
            this.textBoxNRules.TabIndex = 52;
            this.textBoxNRules.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Число правил";
            // 
            // textBoxLift_min
            // 
            this.textBoxLift_min.Location = new System.Drawing.Point(745, 91);
            this.textBoxLift_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLift_min.Name = "textBoxLift_min";
            this.textBoxLift_min.Size = new System.Drawing.Size(87, 22);
            this.textBoxLift_min.TabIndex = 50;
            this.textBoxLift_min.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "lift_min ";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(745, 272);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(101, 70);
            this.buttonShowAll.TabIndex = 48;
            this.buttonShowAll.Text = "Показать все правила";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(181, 462);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(528, 40);
            this.textBoxMessage.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Сообщение";
            // 
            // buttonShowRules
            // 
            this.buttonShowRules.Location = new System.Drawing.Point(745, 165);
            this.buttonShowRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowRules.Name = "buttonShowRules";
            this.buttonShowRules.Size = new System.Drawing.Size(101, 70);
            this.buttonShowRules.TabIndex = 45;
            this.buttonShowRules.Text = "Показать правила";
            this.buttonShowRules.UseVisualStyleBackColor = true;
            this.buttonShowRules.Click += new System.EventHandler(this.buttonShowRules_Click);
            // 
            // buttonSaveRules
            // 
            this.buttonSaveRules.Location = new System.Drawing.Point(397, 383);
            this.buttonSaveRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveRules.Name = "buttonSaveRules";
            this.buttonSaveRules.Size = new System.Drawing.Size(173, 46);
            this.buttonSaveRules.TabIndex = 44;
            this.buttonSaveRules.Text = "Сохранить правила в файле";
            this.buttonSaveRules.UseVisualStyleBackColor = true;
            this.buttonSaveRules.Click += new System.EventHandler(this.buttonSaveRules_Click);
            // 
            // listBoxRules
            // 
            this.listBoxRules.FormattingEnabled = true;
            this.listBoxRules.ItemHeight = 16;
            this.listBoxRules.Location = new System.Drawing.Point(59, 122);
            this.listBoxRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRules.Name = "listBoxRules";
            this.listBoxRules.Size = new System.Drawing.Size(665, 244);
            this.listBoxRules.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Правила";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Показ правил";
            // 
            // FormShowRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 561);
            this.Controls.Add(this.textBoxNRules);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLift_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShowRules);
            this.Controls.Add(this.buttonSaveRules);
            this.Controls.Add(this.listBoxRules);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormShowRules";
            this.Text = "FormShowRules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNRules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLift_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowRules;
        private System.Windows.Forms.Button buttonSaveRules;
        private System.Windows.Forms.ListBox listBoxRules;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}