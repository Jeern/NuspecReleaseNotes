using NuspecReleaseNotes.Models;
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
            view.ShowReleaseNotes(file.ReleaseNotes, file.ReleaseNotes);
        }

        public void Replace(string text)
        {
            _view.ShowReleaseNotes(text, text);
        }
        public void Prefix(string newText, string currentText)
        {
            _view.ShowReleaseNotes(newText + currentText, newText);
        }

        public void Suffix(string newText, string currentText)
        {
            _view.ShowReleaseNotes(currentText + newText, newText);
        }
    }
}
