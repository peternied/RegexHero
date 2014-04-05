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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoresTextBox = new System.Windows.Forms.RichTextBox();
            this.dataEntryPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntryPanel
            // 
            this.dataEntryPanel.Controls.Add(this.textBox1);
            this.dataEntryPanel.Controls.Add(this.linkLabel1);
            this.dataEntryPanel.Controls.Add(this.label1);
            this.dataEntryPanel.Location = new System.Drawing.Point(17, 15);
            this.dataEntryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEntryPanel.Name = "dataEntryPanel";
            this.dataEntryPanel.Size = new System.Drawing.Size(879, 91);
            this.dataEntryPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(864, 22);
            this.textBox1.TabIndex = 2;
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
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(879, 304);
            this.previewPanel.TabIndex = 1;
            // 
            // materialsBox
            // 
            this.materialsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsBox.Location = new System.Drawing.Point(0, 0);
            this.materialsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialsBox.Name = "materialsBox";
            this.materialsBox.Size = new System.Drawing.Size(879, 304);
            this.materialsBox.TabIndex = 0;
            this.materialsBox.Text = "";
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.scoreLabel);
            this.resultsPanel.Controls.Add(this.label2);
            this.resultsPanel.Location = new System.Drawing.Point(17, 426);
            this.resultsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(879, 44);
            this.resultsPanel.TabIndex = 2;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(117, 5);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 17);
            this.scoreLabel.TabIndex = 1;
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
            this.highScoresTextBox.Location = new System.Drawing.Point(904, 118);
            this.highScoresTextBox.Name = "highScoresTextBox";
            this.highScoresTextBox.Size = new System.Drawing.Size(146, 352);
            this.highScoresTextBox.TabIndex = 3;
            this.highScoresTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 485);
            this.Controls.Add(this.highScoresTextBox);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.dataEntryPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Regex Hero";
            this.dataEntryPanel.ResumeLayout(false);
            this.dataEntryPanel.PerformLayout();
            this.previewPanel.ResumeLayout(false);
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
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
    }
}

