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
            this.SuspendLayout();
            // 
            // dataEntryPanel
            // 
            this.dataEntryPanel.Location = new System.Drawing.Point(13, 12);
            this.dataEntryPanel.Name = "dataEntryPanel";
            this.dataEntryPanel.Size = new System.Drawing.Size(659, 74);
            this.dataEntryPanel.TabIndex = 0;
            // 
            // previewPanel
            // 
            this.previewPanel.Location = new System.Drawing.Point(13, 93);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(659, 247);
            this.previewPanel.TabIndex = 1;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Location = new System.Drawing.Point(13, 346);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(659, 36);
            this.resultsPanel.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataEntryPanel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Panel resultsPanel;
    }
}

