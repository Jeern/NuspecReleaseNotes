using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Presenters;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class NuspecView : UserControl, INuspecView
    {
        private readonly NuspecPresenter _presenter;

        public NuspecView(NuspecFile file)
        {
            InitializeComponent();
            _presenter = new NuspecPresenter(this, file);
        }

        private void ReplaceButton_Click(object sender, System.EventArgs e)
        {
            _presenter.ReplaceAll(ReleaseNotesTextbox.Text);
        }

        private void PrefixButton_Click(object sender, System.EventArgs e)
        {
            _presenter.PrefixAll(ReleaseNotesTextbox.Text);
        }

        private void SuffixButton_Click(object sender, System.EventArgs e)
        {
            _presenter.SuffixAll(ReleaseNotesTextbox.Text);
        }

        public void ShowPath(string path)
        {
            PathLabel.Format(path);
        }

        public void ShowReleaseNotes(string releaseNotes)
        {
            ReleaseNotesTextbox.Text = releaseNotes;
        }

        private void ReleaseNotesTextbox_TextChanged(object sender, System.EventArgs e)
        {
            Messenger.Send(MessageNames.ReleaseNoteChanged, ReleaseNotesTextbox.Text);
        }
    }
}
