using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Presenters;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class NuspecView : UserControl, INuspecView
    {
        private readonly NuspecFile _file;
        private readonly NuspecPresenter _presenter;

        public NuspecView(NuspecFile file)
        {
            _file = file;
            InitializeComponent();
            _presenter = new NuspecPresenter(this);
            PathLabel.Format(file.Path);
            ReleaseNotesTextbox.Text = file.ReleaseNotes;
        }
    }
}
