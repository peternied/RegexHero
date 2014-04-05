namespace RegexHero
{
    partial class Form1
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
            this.dataEntryPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.materialsBox = new System.Windows.Forms.RichTextBox();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maxScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoresTextBox = new System.Windows.Forms.RichTextBox();
            this.highScoresPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataEntryPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.highScoresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntryPanel
            // 
            this.dataEntryPanel.Controls.Add(this.textBox1);
            this.dataEntryPanel.Controls.Add(this.linkLabel1);
            this.dataEntryPanel.Controls.Add(this.label1);
            this.dataEntryPanel.Location = new System.Drawing.Point(17, 15);
            this.dataEntryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dataEntryPanel.Name = "dataEntryPanel";
            this.dataEntryPanel.Size = new System.Drawing.Size(879, 91);
            this.dataEntryPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(864, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.RegexSourceTextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(791, 5);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CheatSheet";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoCheating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Express your Expression";
            // 
            // previewPanel
            // 
            this.previewPanel.Controls.Add(this.materialsBox);
            this.previewPanel.Location = new System.Drawing.Point(17, 114);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(879, 304);
            this.previewPanel.TabIndex = 1;
            // 
            // materialsBox
            // 
            this.materialsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsBox.Location = new System.Drawing.Point(0, 0);
            this.materialsBox.Margin = new System.Windows.Forms.Padding(4);
            this.materialsBox.Name = "materialsBox";
            this.materialsBox.ReadOnly = true;
            this.materialsBox.Size = new System.Drawing.Size(879, 304);
            this.materialsBox.TabIndex = 0;
            this.materialsBox.Text = "";
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.checkBox1);
            this.resultsPanel.Controls.Add(this.maxScoreLabel);
            this.resultsPanel.Controls.Add(this.label3);
            this.resultsPanel.Controls.Add(this.scoreLabel);
            this.resultsPanel.Controls.Add(this.label2);
            this.resultsPanel.Location = new System.Drawing.Point(17, 426);
            this.resultsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(879, 44);
            this.resultsPanel.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(732, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show HighScores";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // maxScoreLabel
            // 
            this.maxScoreLabel.AutoSize = true;
            this.maxScoreLabel.Location = new System.Drawing.Point(269, 5);
            this.maxScoreLabel.Name = "maxScoreLabel";
            this.maxScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.maxScoreLabel.TabIndex = 3;
            this.maxScoreLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "High Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(117, 5);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(16, 17);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Score:";
            // 
            // highScoresTextBox
            // 
            this.highScoresTextBox.Location = new System.Drawing.Point(3, 26);
            this.highScoresTextBox.Name = "highScoresTextBox";
            this.highScoresTextBox.Size = new System.Drawing.Size(146, 426);
            this.highScoresTextBox.TabIndex = 3;
            this.highScoresTextBox.Text = "";
            // 
            // highScoresPanel
            // 
            this.highScoresPanel.Controls.Add(this.label4);
            this.highScoresPanel.Controls.Add(this.highScoresTextBox);
            this.highScoresPanel.Location = new System.Drawing.Point(904, 15);
            this.highScoresPanel.Name = "highScoresPanel";
            this.highScoresPanel.Size = new System.Drawing.Size(146, 455);
            this.highScoresPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Daily High Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 485);
            this.Controls.Add(this.highScoresPanel);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.dataEntryPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Regex Hero";
            this.dataEntryPanel.ResumeLayout(false);
            this.dataEntryPanel.PerformLayout();
            this.previewPanel.ResumeLayout(false);
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.highScoresPanel.ResumeLayout(false);
            this.highScoresPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataEntryPanel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox materialsBox;
        private System.Windows.Forms.RichTextBox highScoresTextBox;
        private System.Windows.Forms.Label maxScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel highScoresPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
    }
}

