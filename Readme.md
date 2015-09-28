NugetReleaseNotes is just a simple WinForm application that recursively 
finds all Nuspec files in the current Directory. Loads the release notes and makes 
it easy to edit them. Either for all files or for each one. 

## Usage

If you have several nuspec files in 
your Visual Studio solution and want to edit your release notes before you 
create and deploy your nuget packages. You just place NuspecReleaseNotes.exe in the root folder
of your solution and run it.

The UI shows the release notes from all Nuspec files and gives you the option to change each one individually. You can also press "Replace all" which changes all Release notes to the same as the current line. "Prefix all" or "Suffix all" which prefixes / suffixes all release notes with the content of the current line. 

The release notes are not Persisted until you press Save. 

## Warning

If you place the NuspecReleaseNotes in the root of your harddrive it will load all Nuspec 
files on your entire harddrive. This is probably not what you want !

Also be aware that there are no "Yes/No" dialogues to confirm the save. It just happens immediately.


