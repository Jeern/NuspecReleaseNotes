﻿namespace NuspecReleaseNotes
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
            this.headerView1 = new NuspecReleaseNotes.Views.HeaderView();
            this.SuspendLayout();
            // 
            // headerView1
            // 
            this.headerView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerView1.Location = new System.Drawing.Point(3, 4);
            this.headerView1.Name = "headerView1";
            this.headerView1.Size = new System.Drawing.Size(442, 82);
            this.headerView1.TabIndex = 0;
            // 
            // NuspecReleaseNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 368);
            this.Controls.Add(this.headerView1);
            this.Name = "NuspecReleaseNotesForm";
            this.Text = "Nuspec release notes";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.HeaderView headerView1;
    }
}

