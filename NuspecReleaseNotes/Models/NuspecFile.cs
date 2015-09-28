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
                if (!value.Equals(ReleaseNotes))
                {
                    Changed = true;
                    _releaseNotes = value;
                }
            }
        }

        public XDocument Doc { get; }
        public bool Changed { get; private set; }

        public void MoveNoteToDoc()
        {
            XElement releaseNoteElement = Doc?.Descendants("releaseNotes").FirstOrDefault();
            if (releaseNoteElement != null)
            {
                releaseNoteElement.Value = ReleaseNotes;
            }
            else
            {
                //We just add the element to the metadata element
                XElement metadataElement = Doc?.Descendants("metadata").FirstOrDefault();
                if (metadataElement != null)
                {
                    metadataElement.Add(new XElement("releaseNotes", ReleaseNotes));
                }

            }
        }
    }
}
