using System.Windows.Forms;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class NuspecView : UserControl, INuspecView
    {
        public NuspecView()
        {
            InitializeComponent();
        }
    }
}
