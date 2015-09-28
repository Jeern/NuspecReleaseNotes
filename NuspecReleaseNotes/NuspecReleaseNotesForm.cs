using System.Collections.Generic;
using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views;

namespace NuspecReleaseNotes
{
    public partial class NuspecReleaseNotesForm : Form
    {
        public NuspecReleaseNotesForm()
        {
            Messenger.Register<List<NuspecFile>>(MessageNames.FilesLoaded, AddNuspecViews);
            InitializeComponent();
        }

        private void AddNuspecViews(List<NuspecFile> files)
        {
            //SuspendLayout();
            int idx = 0;
            foreach (var file in files)
            {
                AddNuspecView(file, idx);
                idx += 1;
            }
            //ResumeLayout(false);
        }

        private void AddNuspecView(NuspecFile file, int idx)
        {
            var nuspecView = new NuspecView(file)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Location = new System.Drawing.Point(13, 93 + idx * 100),
                Name = $"nuspecView{idx}",
                Size = new System.Drawing.Size(559, 83),
                TabIndex = idx + 2
            };
            Controls.Add(nuspecView);
        }
    }
}
