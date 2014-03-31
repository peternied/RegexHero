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
            this.previewPanel = new System.Windows.Forms.Panel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.materialsBox = new System.Windows.Forms.RichTextBox();
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
            this.dataEntryPanel.Location = new System.Drawing.Point(13, 12);
            this.dataEntryPanel.Name = "dataEntryPanel";
            this.dataEntryPanel.Size = new System.Drawing.Size(659, 74);
            this.dataEntryPanel.TabIndex = 0;
            // 
            // previewPanel
            // 
            this.previewPanel.Controls.Add(this.materialsBox);
            this.previewPanel.Location = new System.Drawing.Point(13, 93);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(659, 247);
            this.previewPanel.TabIndex = 1;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.scoreLabel);
            this.resultsPanel.Controls.Add(this.label2);
            this.resultsPanel.Location = new System.Drawing.Point(13, 346);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(659, 36);
            this.resultsPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Express your Expression";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(593, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CheatSheet";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoCheating);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.RegexSourceTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(88, 4);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label3";
            // 
            // materialsBox
            // 
            this.materialsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsBox.Location = new System.Drawing.Point(0, 0);
            this.materialsBox.Name = "materialsBox";
            this.materialsBox.Size = new System.Drawing.Size(659, 247);
            this.materialsBox.TabIndex = 0;
            this.materialsBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 394);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.dataEntryPanel);
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
    }
}

