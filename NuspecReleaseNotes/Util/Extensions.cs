using System.Windows.Forms;

namespace NuspecReleaseNotes.Util
{
    public static class Extensions
    {
        public static Label Format(this Label label, params object[] parameters)
        {
            label.Text = string.Format(label.Text, parameters);
            return label;
        }
    }
}
