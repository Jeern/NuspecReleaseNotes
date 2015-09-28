using System.IO;
using System.Xml.Linq;

namespace NuspecReleaseNotes.Util
{
    public static class XDocLoader
    {
        public static XDocument Load(string path)
        {
            if (!File.Exists(path))
                return null;

            try
            {
                return XDocument.Load(path);
            }
            catch
            {
                return null;
            }
        }
    }
}
