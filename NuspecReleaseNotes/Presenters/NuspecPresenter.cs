using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class NuspecPresenter
    {
        private readonly INuspecView _view;
        private readonly NuspecFile _file;

        public NuspecPresenter(INuspecView view, NuspecFile file)
        {
            _view = view;
            _file = file;
            view.ShowPath(file.Path);
            view.ShowReleaseNotes(file.ReleaseNotes);
            Messenger.Register<string>(MessageNames.ReplaceAll, Replace);
            Messenger.Register<string>(MessageNames.PrefixAll, Prefix);
            Messenger.Register<string>(MessageNames.SuffixAll, Suffix);
            Messenger.Register(MessageNames.SaveChangedNotes, Save);

        }

        public void ReplaceAll(string text)
        {
            Messenger.Send(MessageNames.ReplaceAll, text);
        }

        public void PrefixAll(string text)
        {
            Messenger.Send(MessageNames.PrefixAll, text);
        }

        public void SuffixAll(string text)
        {
            Messenger.Send(MessageNames.SuffixAll, text);
        }


        private void Replace(string text)
        {
            if(IsNotChanged(text))
                return;

            _view.ShowReleaseNotes(text);
        }
        private void Prefix(string text)
        {
            if (IsNotChanged(text))
                return;

            _view.ShowReleaseNotes(text + _file.ReleaseNotes);
        }

        private void Suffix(string text)
        {
            if (IsNotChanged(text))
                return;

            _view.ShowReleaseNotes(_file.ReleaseNotes + text);
        }

        private bool IsNotChanged(string text)
        {
            return text.Equals(_file.ReleaseNotes);
        }

        private void Save()
        {
            if (_file.Changed)
            {
                _file.MoveNoteToDoc();
                _file.Doc.Save(_file.Path);
            }
        }

        public void ChangeNote(string text)
        {
            _file.ReleaseNotes = text;
        }
    }
}
