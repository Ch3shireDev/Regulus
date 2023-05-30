using Microsoft.Win32;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp.Services;

public class FilePathLoader : IFilePathLoader
{
    public string GetOpenFilePath()
    {
        var dialog = new OpenFileDialog
        {
            DefaultExt = ".csv",
            Filter = "CSV Files (*.csv)|*.csv|Access Database Files (*.mdb)|*.mdb",
            ShowReadOnly = true
        };

        var result = dialog.ShowDialog();

        if (result != true) return "";

        return dialog.FileName;
    }

    public string GetSaveFilePath()
    {
        var dialog = new SaveFileDialog
        {
            DefaultExt = ".csv",
            Filter = "CSV Files (*.csv)|*.csv"
        };

        var result = dialog.ShowDialog();

        if (result != true) return "";

        return dialog.FileName;
    }
}