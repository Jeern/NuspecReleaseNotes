namespace NuspecReleaseNotes.Views
{
    partial class NuspecView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathLabel = new System.Windows.Forms.Label();
            this.ReleaseNotesTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(3, 10);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(24, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "{0}:";
            // 
            // ReleaseNotesTextbox
            // 
            this.ReleaseNotesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseNotesTextbox.Location = new System.Drawing.Point(6, 26);
            this.ReleaseNotesTextbox.Multiline = true;
            this.ReleaseNotesTextbox.Name = "ReleaseNotesTextbox";
            this.ReleaseNotesTextbox.Size = new System.Drawing.Size(88, 39);
            this.ReleaseNotesTextbox.TabIndex = 1;
            // 
            // NuspecView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReleaseNotesTextbox);
            this.Controls.Add(this.PathLabel);
            this.Name = "NuspecView";
            this.Size = new System.Drawing.Size(150, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox ReleaseNotesTextbox;
    }
}
