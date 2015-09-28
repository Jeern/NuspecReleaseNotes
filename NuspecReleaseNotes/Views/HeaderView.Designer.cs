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
            this.CouldBeLoadedLabel = new System.Windows.Forms.Label();
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
            this.FoundLabel.Size = new System.Drawing.Size(135, 13);
            this.FoundLabel.TabIndex = 1;
            this.FoundLabel.Text = "Found {0} nuspec files";
            // 
            // CouldBeLoadedLabel
            // 
            this.CouldBeLoadedLabel.AutoSize = true;
            this.CouldBeLoadedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CouldBeLoadedLabel.Location = new System.Drawing.Point(4, 49);
            this.CouldBeLoadedLabel.Name = "CouldBeLoadedLabel";
            this.CouldBeLoadedLabel.Size = new System.Drawing.Size(119, 13);
            this.CouldBeLoadedLabel.TabIndex = 2;
            this.CouldBeLoadedLabel.Text = "{0} could be loaded";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(178, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "&Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // HeaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CouldBeLoadedLabel);
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
        private System.Windows.Forms.Label CouldBeLoadedLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}
