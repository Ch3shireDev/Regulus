namespace RegulusLibrary.Services;

public interface IFilePathLoader
{
    string GetOpenFilePath();
    string GetSaveFilePath();
}