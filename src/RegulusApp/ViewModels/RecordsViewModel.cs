using System.Collections.ObjectModel;
using System.Windows.Input;
using RegulusApp.Helpers;
using RegulusApp.Models;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp.ViewModels;

public class RecordsViewModel : ViewModelBase
{
    private readonly IFilePathLoader? _filePathLoader;

    public RecordsViewModel()
    {
    }

    public RecordsViewModel(RecordsModel model, IFilePathLoader filePathLoader)
    {
        _filePathLoader = filePathLoader;
        Model = model;
    }

    private RecordsModel? Model { get; }
    public ObservableCollection<BirdRecord> BirdRecords { get; } = new ObservableCollection<BirdRecord>();
    public ICommand LoadDatabaseCommand => new RelayCommand(p => LoadDatabase());
    public double LoadingProgressValue { get; set; }

    public void LoadDatabase()
    {
        var filepath = _filePathLoader?.GetFilePath();
        if (string.IsNullOrWhiteSpace(filepath)) return;
        var parameters = new BirdRecordsLoaderParameters { Filename = filepath };
        LoadDatabase(parameters);
    }

    public void LoadDatabase(BirdRecordsLoaderParameters parameters)
    {
        var records = Model?.GetRecords(parameters);
        if (records == null) return;
        foreach (var record in records) BirdRecords.Add(record);
    }
}