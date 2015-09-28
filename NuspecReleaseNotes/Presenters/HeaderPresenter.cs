using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class HeaderPresenter
    {
        public HeaderPresenter(IHeaderView view)
        {
            Messenger.Register<Metadata>(MessageNames.MetadataLoaded, m => view.SetLabels(m.Path, m.NumberOfFiles, m.ValidXmlFiles));
            Messenger.Register<string>(MessageNames.ReleaseNoteChanged, text => view.EnableSave());
            Messenger.Register(MessageNames.FinishedLoading, view.DisableSave);
        }
    }
}
