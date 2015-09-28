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
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.PrefixButton = new System.Windows.Forms.Button();
            this.SuffixButton = new System.Windows.Forms.Button();
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
            this.ReleaseNotesTextbox.Size = new System.Drawing.Size(309, 39);
            this.ReleaseNotesTextbox.TabIndex = 1;
            this.ReleaseNotesTextbox.TextChanged += new System.EventHandler(this.ReleaseNotesTextbox_TextChanged);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceButton.Location = new System.Drawing.Point(321, 26);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 2;
            this.ReplaceButton.Text = "&Replace all";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // PrefixButton
            // 
            this.PrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrefixButton.Location = new System.Drawing.Point(402, 26);
            this.PrefixButton.Name = "PrefixButton";
            this.PrefixButton.Size = new System.Drawing.Size(75, 23);
            this.PrefixButton.TabIndex = 3;
            this.PrefixButton.Text = "&Prefix all";
            this.PrefixButton.UseVisualStyleBackColor = true;
            this.PrefixButton.Click += new System.EventHandler(this.PrefixButton_Click);
            // 
            // SuffixButton
            // 
            this.SuffixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuffixButton.Location = new System.Drawing.Point(483, 26);
            this.SuffixButton.Name = "SuffixButton";
            this.SuffixButton.Size = new System.Drawing.Size(75, 23);
            this.SuffixButton.TabIndex = 4;
            this.SuffixButton.Text = "S&uffix all";
            this.SuffixButton.UseVisualStyleBackColor = true;
            this.SuffixButton.Click += new System.EventHandler(this.SuffixButton_Click);
            // 
            // NuspecView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SuffixButton);
            this.Controls.Add(this.PrefixButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.ReleaseNotesTextbox);
            this.Controls.Add(this.PathLabel);
            this.Name = "NuspecView";
            this.Size = new System.Drawing.Size(598, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox ReleaseNotesTextbox;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button PrefixButton;
        private System.Windows.Forms.Button SuffixButton;
    }
}
