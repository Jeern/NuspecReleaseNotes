namespace NuspecReleaseNotes.Views
{
    partial class HeaderView
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
            this.SearchInfoLabel = new System.Windows.Forms.Label();
            this.FoundLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchInfoLabel
            // 
            this.SearchInfoLabel.AutoSize = true;
            this.SearchInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInfoLabel.Location = new System.Drawing.Point(4, 4);
            this.SearchInfoLabel.Name = "SearchInfoLabel";
            this.SearchInfoLabel.Size = new System.Drawing.Size(147, 13);
            this.SearchInfoLabel.TabIndex = 0;
            this.SearchInfoLabel.Text = "Searched for files at: {0}";
            // 
            // FoundLabel
            // 
            this.FoundLabel.AutoSize = true;
            this.FoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundLabel.Location = new System.Drawing.Point(4, 26);
            this.FoundLabel.Name = "FoundLabel";
            this.FoundLabel.Size = new System.Drawing.Size(269, 13);
            this.FoundLabel.TabIndex = 1;
            this.FoundLabel.Text = "Found {0} nuspec files. {1} contains valid xml.";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(179, 44);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "&Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HeaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FoundLabel);
            this.Controls.Add(this.SearchInfoLabel);
            this.Name = "HeaderView";
            this.Size = new System.Drawing.Size(277, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchInfoLabel;
        private System.Windows.Forms.Label FoundLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}
