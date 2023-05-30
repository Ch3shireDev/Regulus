namespace RegulusLibrary.Services.Loaders;

public interface IFilePathLoader
{
    string GetOpenFilePath();
    string GetSaveFilePath();
}