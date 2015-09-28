using System.Collections.Generic;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            Messenger.Register<List<NuspecFile>>(MessageNames.FilesLoaded, _view.AddNuspecViews);
        }
    }
}
