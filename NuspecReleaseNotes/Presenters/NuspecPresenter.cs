using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class NuspecPresenter
    {
        private readonly INuspecView _view;

        public NuspecPresenter(INuspecView view)
        {
            _view = view;
        }
    }
}
