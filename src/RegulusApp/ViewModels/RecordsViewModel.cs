using System.Collections.ObjectModel;
using System.Linq;
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
    public ICommand SaveDatabaseToCsvCommand => new RelayCommand(p => SaveDatabaseToCsv());
    public double SavingProgressValue { get; set; }

    private void SaveDatabaseToCsv()
    {
        var records = BirdRecords.ToList();
        if (records.Count == 0) return;
        var filepath = _filePathLoader?.GetSaveFilePath();
        var parameters = new BirdRecordsSaverParameters
        {
            Filename = filepath,
            BirdRecords = records
        };

        Model?.WriteRecordsToCsv(parameters);
    }

    public void LoadDatabase()
    {
        var filepath = _filePathLoader?.GetOpenFilePath();
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