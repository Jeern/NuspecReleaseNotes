using System.Linq;
using System.Xml.Linq;

namespace NuspecReleaseNotes.Models
{
    public class NuspecFile
    {
        public NuspecFile(string path, XDocument doc)
        {
            Doc = doc;
            Path = path;
            ReleaseNotes = doc?.Descendants("releaseNotes").FirstOrDefault()?.Value;
        }

        public string Path { get;  }
        public string ReleaseNotes { get; }
        public XDocument Doc { get; }

    }
}
