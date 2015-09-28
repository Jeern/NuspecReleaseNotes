using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class HeaderPresenter
    {
        private readonly IHeaderView _view;

        public HeaderPresenter(IHeaderView view)
        {
            Messenger.Register<Metadata>(MessageNames.MetadataLoaded, m => _view.SetLabels(m.Path, m.NumberOfFiles, m.ValidXmlFiles));
            Messenger.Register<string>(MessageNames.ReleaseNoteChanged, text => _view.EnableSave());
            Messenger.Register(MessageNames.FinishedLoading, view.DisableSave);
            _view = view;
        }
    }
}
