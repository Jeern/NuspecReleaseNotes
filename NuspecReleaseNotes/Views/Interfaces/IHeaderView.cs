namespace NuspecReleaseNotes.Views.Interfaces
{
    public interface IHeaderView
    {
        void SetLabels(string searchDirectory, int numberOfFiles, int couldBeLoaded);
    }
}
