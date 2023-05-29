using RegulusLibrary.Services;

namespace RegulusAppTests.Mockups;

public class MockFilePathLoader : IFilePathLoader
{
    public string FilePath { get; set; } = "";
    public bool IsGetOpen { get; set; }
    public bool IsGetSave { get; set; }

    public string GetOpenFilePath()
    {
        IsGetOpen = true;
        return FilePath;
    }

    public string GetSaveFilePath()
    {
        IsGetSave = true;
        return FilePath;
    }
}