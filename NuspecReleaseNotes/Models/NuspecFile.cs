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
            ReleaseNotes = doc?.Descendants("releaseNotes").FirstOrDefault()?.Value;
            Changed = false;
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

    }
}
