using System;
using RegulusLibrary.Services;

namespace RegulusApp.Services;

public class FilePathLoader : IFilePathLoader
{
    public string GetFilePath()
    {
        var dialog = new Microsoft.Win32.OpenFileDialog
        {
            DefaultExt = ".mdb",
            ShowReadOnly = true
        };

        var result = dialog.ShowDialog();

        if (result != true) return "";

        return dialog.FileName;
    }
}