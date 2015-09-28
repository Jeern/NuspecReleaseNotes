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
            Messenger.Register<string>(MessageNames.ReplaceAll, Replace);
            Messenger.Register<string>(MessageNames.PrefixAll, Prefix);
            Messenger.Register<string>(MessageNames.SuffixAll, Suffix);
            _file = file;
            InitializeComponent();
            _presenter = new NuspecPresenter(this);
            PathLabel.Format(file.Path);
            ReleaseNotesTextbox.Text = file.ReleaseNotes;
        }

        private void Replace(string text)
        {
            if(IsOriginator(text))
                return;

            ReleaseNotesTextbox.Text = text;
        }
        private void Prefix(string text)
        {
            if (IsOriginator(text))
                return;

            ReleaseNotesTextbox.Text = text + ReleaseNotesTextbox.Text;
        }

        private void Suffix(string text)
        {
            if (IsOriginator(text))
                return;

            ReleaseNotesTextbox.Text += text;
        }

        private bool IsOriginator(string text)
        {
            //Could be implemented in a more correct manner, i.e sending the sender too, but this is good enough
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
    }
}
