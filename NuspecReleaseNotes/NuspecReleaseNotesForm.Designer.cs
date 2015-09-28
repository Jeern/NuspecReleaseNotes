namespace NuspecReleaseNotes
{
    partial class NuspecReleaseNotesForm
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
            this.Line = new System.Windows.Forms.Panel();
            this.headerView1 = new NuspecReleaseNotes.Views.HeaderView();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line.BackColor = System.Drawing.SystemColors.MenuText;
            this.Line.Location = new System.Drawing.Point(13, 82);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(559, 2);
            this.Line.TabIndex = 1;
            // 
            // headerView1
            // 
            this.headerView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerView1.Location = new System.Drawing.Point(3, 4);
            this.headerView1.Name = "headerView1";
            this.headerView1.Size = new System.Drawing.Size(578, 82);
            this.headerView1.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Location = new System.Drawing.Point(13, 93);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(559, 263);
            this.ContentPanel.TabIndex = 2;
            // 
            // NuspecReleaseNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 368);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.headerView1);
            this.Name = "NuspecReleaseNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuspec release notes";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.HeaderView headerView1;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

