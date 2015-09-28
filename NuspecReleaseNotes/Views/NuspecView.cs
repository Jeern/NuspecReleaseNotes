using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class NuspecView : UserControl, INuspecView
    {
        private readonly NuspecFile _file;

        public NuspecView(NuspecFile file)
        {
            _file = file;
            InitializeComponent();
        }
    }
}
