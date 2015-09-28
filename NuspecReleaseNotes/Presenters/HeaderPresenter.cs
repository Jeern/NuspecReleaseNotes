using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class HeaderPresenter
    {
        private readonly IHeaderView _view;

        public HeaderPresenter(IHeaderView view)
        {
            _view = view;
        }
    }
}
