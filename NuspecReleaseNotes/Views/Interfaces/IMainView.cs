using System.Collections.Generic;
using NuspecReleaseNotes.Models;

namespace NuspecReleaseNotes.Views.Interfaces
{
    public interface IMainView
    {
        void AddNuspecViews(List<NuspecFile> files);
    }
}
