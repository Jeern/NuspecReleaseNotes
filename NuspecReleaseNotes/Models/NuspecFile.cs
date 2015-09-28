using System.Linq;
using System.Xml.Linq;

namespace NuspecReleaseNotes.Models
{
    public class NuspecFile
    {
        private string _releaseNotes;

        public NuspecFile(string path, XDocument doc)
        {
            Doc = doc;
            Path = path;
            _releaseNotes = doc?.Descendants("releaseNotes").FirstOrDefault()?.Value;
        }

        public string Path { get;  }

        public string ReleaseNotes
        {
            get { return _releaseNotes; }
            set
            {
                Changed = true;
                _releaseNotes = value;
            }
        }

        public XDocument Doc { get; }
        public bool Changed { get; private set; }

        public void MoveNoteToDoc()
        {
            XElement element = Doc?.Descendants("releaseNotes").FirstOrDefault();
            if (element != null)
            {
                element.Value = ReleaseNotes;
            }
        }
    }
}
