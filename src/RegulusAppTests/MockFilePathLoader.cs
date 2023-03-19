using RegulusLibrary.Services;

namespace RegulusAppTests;

public class MockFilePathLoader : IFilePathLoader
{
    public string FilePath { get; set; } = "";
    public bool IsGet { get; set; }

    public string GetFilePath()
    {
        IsGet = true;
        return FilePath;
    }
}