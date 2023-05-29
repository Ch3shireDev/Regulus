using Microsoft.Win32;
using RegulusLibrary.Services;

namespace RegulusApp.Services;

public class FilePathLoader : IFilePathLoader
{
    public string GetOpenFilePath()
    {
        var dialog = new OpenFileDialog
        {
            DefaultExt = ".mdb",
            Filter = "Access Database Files (*.mdb)|*.mdb|CSV Files (*.csv)|*.csv",
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