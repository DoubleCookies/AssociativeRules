namespace WindowsFormsConAprioriPar

{
    partial class FormWorkingWithRules
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewConclusion = new System.Windows.Forms.ListView();
            this.listViewPremise = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPremiseFilter = new System.Windows.Forms.Button();
            this.buttonCreateRule = new System.Windows.Forms.Button();
            this.buttonRule_con = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIndividRule = new System.Windows.Forms.TextBox();
            this.buttonGotoShowRules = new System.Windows.Forms.Button();
            this.buttonRuleIndivid = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listViewConclusion);
            this.groupBox1.Controls.Add(this.listViewPremise);
            this.groupBox1.Location = new System.Drawing.Point(73, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(862, 352);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать фильтр для правил";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заключение правила";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Посылка правила";
            // 
            // listViewConclusion
            // 
            this.listViewConclusion.Location = new System.Drawing.Point(439, 64);
            this.listViewConclusion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewConclusion.Name = "listViewConclusion";
            this.listViewConclusion.Size = new System.Drawing.Size(401, 261);
            this.listViewConclusion.TabIndex = 3;
            this.listViewConclusion.UseCompatibleStateImageBehavior = false;
            // 
            // listViewPremise
            // 
            this.listViewPremise.Location = new System.Drawing.Point(6, 64);
            this.listViewPremise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPremise.Name = "listViewPremise";
            this.listViewPremise.Size = new System.Drawing.Size(389, 261);
            this.listViewPremise.TabIndex = 2;
            this.listViewPremise.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(375, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Работаем с правилами";
            // 
            // buttonPremiseFilter
            // 
            this.buttonPremiseFilter.Location = new System.Drawing.Point(184, 444);
            this.buttonPremiseFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPremiseFilter.Name = "buttonPremiseFilter";
            this.buttonPremiseFilter.Size = new System.Drawing.Size(163, 49);
            this.buttonPremiseFilter.TabIndex = 21;
            this.buttonPremiseFilter.Text = "Задать посылку фильтра показа правил";
            this.buttonPremiseFilter.UseVisualStyleBackColor = true;
            this.buttonPremiseFilter.Click += new System.EventHandler(this.buttonPremiseFilter_Click);
            // 
            // buttonCreateRule
            // 
            this.buttonCreateRule.Location = new System.Drawing.Point(600, 518);
            this.buttonCreateRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateRule.Name = "buttonCreateRule";
            this.buttonCreateRule.Size = new System.Drawing.Size(133, 64);
            this.buttonCreateRule.TabIndex = 20;
            this.buttonCreateRule.Text = "Построить индивидуальное правило";
            this.buttonCreateRule.UseVisualStyleBackColor = true;
            this.buttonCreateRule.Click += new System.EventHandler(this.buttonCreateRule_Click);
            // 
            // buttonRule_con
            // 
            this.buttonRule_con.Location = new System.Drawing.Point(390, 518);
            this.buttonRule_con.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRule_con.Name = "buttonRule_con";
            this.buttonRule_con.Size = new System.Drawing.Size(163, 64);
            this.buttonRule_con.TabIndex = 19;
            this.buttonRule_con.Text = "Задать заключение индивидуального правила";
            this.buttonRule_con.UseVisualStyleBackColor = true;
            this.buttonRule_con.Click += new System.EventHandler(this.buttonRule_con_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "индивидуальное\r\n правило";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxIndividRule
            // 
            this.textBoxIndividRule.Location = new System.Drawing.Point(289, 604);
            this.textBoxIndividRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIndividRule.Multiline = true;
            this.textBoxIndividRule.Name = "textBoxIndividRule";
            this.textBoxIndividRule.Size = new System.Drawing.Size(519, 43);
            this.textBoxIndividRule.TabIndex = 17;
            // 
            // buttonGotoShowRules
            // 
            this.buttonGotoShowRules.Location = new System.Drawing.Point(608, 444);
            this.buttonGotoShowRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGotoShowRules.Name = "buttonGotoShowRules";
            this.buttonGotoShowRules.Size = new System.Drawing.Size(125, 49);
            this.buttonGotoShowRules.TabIndex = 16;
            this.buttonGotoShowRules.Text = "Перейти к показу правил";
            this.buttonGotoShowRules.UseVisualStyleBackColor = true;
            this.buttonGotoShowRules.Click += new System.EventHandler(this.buttonGotoShowRules_Click);
            // 
            // buttonRuleIndivid
            // 
            this.buttonRuleIndivid.Location = new System.Drawing.Point(184, 518);
            this.buttonRuleIndivid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRuleIndivid.Name = "buttonRuleIndivid";
            this.buttonRuleIndivid.Size = new System.Drawing.Size(163, 64);
            this.buttonRuleIndivid.TabIndex = 15;
            this.buttonRuleIndivid.Text = "Задать посылку индивидуального правила";
            this.buttonRuleIndivid.UseVisualStyleBackColor = true;
            this.buttonRuleIndivid.Click += new System.EventHandler(this.buttonRuleIndivid_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(390, 444);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(163, 49);
            this.buttonFilter.TabIndex = 14;
            this.buttonFilter.Text = "Задать заключение фильтра показа правил";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FormWorkingWithRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPremiseFilter);
            this.Controls.Add(this.buttonCreateRule);
            this.Controls.Add(this.buttonRule_con);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIndividRule);
            this.Controls.Add(this.buttonGotoShowRules);
            this.Controls.Add(this.buttonRuleIndivid);
            this.Controls.Add(this.buttonFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormWorkingWithRules";
            this.Text = "FormWorkingWithRules";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewConclusion;
        private System.Windows.Forms.ListView listViewPremise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPremiseFilter;
        private System.Windows.Forms.Button buttonCreateRule;
        private System.Windows.Forms.Button buttonRule_con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIndividRule;
        private System.Windows.Forms.Button buttonGotoShowRules;
        private System.Windows.Forms.Button buttonRuleIndivid;
        private System.Windows.Forms.Button buttonFilter;
    }
}