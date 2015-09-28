using System.Collections.Generic;
using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;

namespace NuspecReleaseNotes
{
    public partial class NuspecReleaseNotesForm : Form
    {
        public NuspecReleaseNotesForm()
        {
            InitializeComponent();
            Messenger.Register<List<NuspecFile>>(MessageNames.FilesLoaded, AddNuspecViews);
        }

        private void AddNuspecViews(List<NuspecFile> files)
        {
            int yPosition = 0;
            foreach (var file in files)
            {
                AddNuspecView(file, yPosition);
                yPosition += 100;
            }
        }
    }
}
