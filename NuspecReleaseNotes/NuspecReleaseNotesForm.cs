using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NuspecReleaseNotes.Models;
using NuspecReleaseNotes.Presenters;
using NuspecReleaseNotes.Util;
using NuspecReleaseNotes.Views;
using NuspecReleaseNotes.Views.Interfaces;

namespace NuspecReleaseNotes
{
    public partial class NuspecReleaseNotesForm : Form, IMainView
    {
        private readonly MainPresenter _presenter;
        public NuspecReleaseNotesForm()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
            _presenter.LoadFiles();
        }

        public void AddNuspecViews(List<NuspecFile> files)
        {
            SuspendLayout();
            int idx = 0;
            foreach (var file in files)
            {
                AddNuspecView(file, idx);
                idx += 1;
            }
            ResumeLayout(false);
        }

        private void AddNuspecView(NuspecFile file, int idx)
        {
            var nuspecView = new NuspecView(file)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Location = new System.Drawing.Point(13, 3 + idx * 100),
                Name = $"nuspecView{idx}",
                Size = new System.Drawing.Size(559, 83),
                TabIndex = idx + 2
            };
            ContentPanel.Controls.Add(nuspecView);
        }
    }
}
