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
            Messenger.Register<string>(MessageNames.ReplaceAll, _presenter.Replace);
            Messenger.Register<string>(MessageNames.PrefixAll, text => _presenter.Prefix(text, ReleaseNotesTextbox.Text));
            Messenger.Register<string>(MessageNames.SuffixAll, text => _presenter.Suffix(text, ReleaseNotesTextbox.Text));
        }

        private bool IsNotChanged(string text)
        {
            return text.Equals(ReleaseNotesTextbox.Text);
        }

        private void ReplaceButton_Click(object sender, System.EventArgs e)
        {
            Messenger.Send(MessageNames.ReplaceAll, ReleaseNotesTextbox.Text);
        }

        private void PrefixButton_Click(object sender, System.EventArgs e)
        {
            Messenger.Send(MessageNames.PrefixAll, ReleaseNotesTextbox.Text);
        }

        private void SuffixButton_Click(object sender, System.EventArgs e)
        {
            Messenger.Send(MessageNames.SuffixAll, ReleaseNotesTextbox.Text);
        }

        public void ShowPath(string path)
        {
            PathLabel.Format(path);
        }

        public void ShowReleaseNotes(string releaseNotes, string changedPart)
        {
            if (IsNotChanged(changedPart))
                return;

            ReleaseNotesTextbox.Text = releaseNotes;
        }

        private void ReleaseNotesTextbox_TextChanged(object sender, System.EventArgs e)
        {
            Messenger.Send(MessageNames.ReleaseNoteChanged, ReleaseNotesTextbox.Text);
        }
    }
}
