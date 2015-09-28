using System.IO;
using System.Linq;
using System.Xml.Linq;
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
            _view = view;
        }


        public void LoadFiles()
        {
            string searchDirectory = Directory.GetCurrentDirectory();

            var files = Directory.GetFiles(searchDirectory, "*.nuspec", SearchOption.AllDirectories);

            var loadedDocs = files.Select(f => new NuspecFile(f, XDocLoader.Load(f))).Where(doc => doc.Doc != null).ToList();

            _view.SetLabels(searchDirectory, files.Length, loadedDocs.Count);

            Messenger.Send(MessageNames.FilesLoaded, loadedDocs);
        }
    }
}
