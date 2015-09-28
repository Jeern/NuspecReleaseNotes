using System.Windows.Forms;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes.Views
{
    public partial class HeaderView : UserControl, IHeaderView
    {
        public HeaderView()
        {
            InitializeComponent();
        }
    }
}
