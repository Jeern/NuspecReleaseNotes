﻿using System.ComponentModel;
using System.Windows.Forms;
using NuspecReleaseNotes.Presenters;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class HeaderView : UserControl, IHeaderView
    {
        private HeaderPresenter _presenter;
        public HeaderView()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _presenter = new HeaderPresenter(this);
            }
        }

        public void SetLabels(string searchDirectory, int numberOfFiles, int validXml)
        {
            SearchInfoLabel.Format(searchDirectory);
            FoundLabel.Format(numberOfFiles, numberOfFiles == validXml ? "All" : validXml.ToString());
        }

        public void EnableSave()
        {
            SaveButton.Enabled = true;
        }

        public void DisableSave()
        {
            SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            _presenter.Save();
            DisableSave();
        }
    }
}
