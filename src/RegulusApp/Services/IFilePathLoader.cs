namespace RegulusApp.Services;

public interface IFilePathLoader
{
    string GetOpenFilePath();
    string GetSaveFilePath();
}