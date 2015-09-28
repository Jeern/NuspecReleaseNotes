using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public void LoadFiles()
        {
            string searchDirectory = Directory.GetCurrentDirectory();

            var files = Directory.GetFiles(searchDirectory, "*.nuspec", SearchOption.AllDirectories);

            var loadedDocs = files.Select(f => new NuspecFile(f, XDocLoader.Load(f))).Where(doc => doc.Doc != null).ToList();

            Messenger.Send(MessageNames.MetadataLoaded, new Metadata
            {
                NumberOfFiles = files.Length,
                Path = searchDirectory,
                ValidXmlFiles = loadedDocs.Count
            });
            Messenger.Send(MessageNames.FilesLoaded, loadedDocs);
            Messenger.Send(MessageNames.FinishedLoading);
        }
    }
}
