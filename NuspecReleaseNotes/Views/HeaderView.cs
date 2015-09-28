using System.ComponentModel;
using System.Windows.Forms;
using NuspecReleaseNotes.Models;
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
            Messenger.Register<Metadata>(MessageNames.MetadataLoaded, m => SetLabels(m.Path, m.NumberOfFiles, m.ValidXmlFiles));
            Messenger.Register<string>(MessageNames.ReleaseNoteChanged, text => SaveButton.Enabled = true);
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _presenter = new HeaderPresenter(this);
            }
            SaveButton.Enabled = false;
        }

        public void SetLabels(string searchDirectory, int numberOfFiles, int validXml)
        {
            SearchInfoLabel.Format(searchDirectory);
            FoundLabel.Format(numberOfFiles, numberOfFiles == validXml ? "All" : validXml.ToString());
        }
    }
}
