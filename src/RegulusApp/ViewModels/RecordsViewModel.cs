using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using RegulusApp.Helpers;
using RegulusApp.Models;
using RegulusLibrary.DataStructures;
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
    public ObservableCollection<BirdRecordWrapper> BirdRecords { get; } = new();
    public ICommand LoadDatabaseCommand => new RelayCommand(p => LoadDatabase());
    public ICommand SaveDatabaseToCsvCommand => new RelayCommand(p => SaveDatabaseToCsv());
    public double LoadingProgressValue { get; set; }
    public double SavingProgressValue { get; set; }

    public void LoadDatabase()
    {
        var filepath = _filePathLoader?.GetOpenFilePath();
        if (string.IsNullOrWhiteSpace(filepath)) return;
        var extension = Path.GetExtension(filepath);
        var parameters = new BirdRecordsLoaderParameters
        {
            Filename = filepath,
            Extension = extension
        };
        LoadDatabase(parameters);
    }

    public void LoadDatabase(BirdRecordsLoaderParameters parameters)
    {
        var records = Model?.GetRecordWrappers(parameters);
        if (records == null) return;
        foreach (var record in records) BirdRecords.Add(record);
    }
    private void SaveDatabaseToCsv()
    {
        var records = BirdRecords.ToList();
        if (records.Count == 0) return;
        var filepath = _filePathLoader?.GetSaveFilePath();
        var parameters = new BirdRecordsSaverParameters
        {
            Filename = filepath,
            Records = Model.AsSimpleRecords(records)
        };

        Model?.WriteRecordsToCsv(parameters);
    }
}