namespace NuspecReleaseNotes.Views.Interfaces
{
    public interface INuspecView
    {
        void ShowPath(string path);
        void ShowReleaseNotes(string releaseNotes);

        void ShowChangedLabel(bool show);
    }
}
