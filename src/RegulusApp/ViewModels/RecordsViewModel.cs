using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using RegulusApp.Helpers;
using RegulusApp.Models;
using RegulusApp.Services;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp.ViewModels;

public class RecordsViewModel : ViewModelBase
{
    private readonly IBirdRecordEditorViewer _birdRecordEditorViewer;
    private readonly IFilePathLoader? _filePathLoader;

    private BirdRecordWrapper selectedBirdRecord;

    public RecordsViewModel()
    {
    }

    public RecordsViewModel(RecordsModel model, IFilePathLoader filePathLoader, IBirdRecordEditorViewer birdRecordEditorViewer)
    {
        _filePathLoader = filePathLoader;
        _birdRecordEditorViewer = birdRecordEditorViewer;
        Model = model;
    }

    private RecordsModel? Model { get; }
    public double LoadingProgressValue { get; set; }
    public double SavingProgressValue { get; set; }
    public ObservableCollection<BirdRecordWrapper> BirdRecords { get; } = new();
    public ICommand LoadDatabaseCommand => new RelayCommand(p => LoadDatabase());
    public ICommand SaveDatabaseToCsvCommand => new RelayCommand(p => SaveDatabaseToCsv());
    public ICommand ValidateDataCommand => new RelayCommand(p => ValidateData());
    public ICommand EditRowCommand => new RelayCommand(p => EditRow());

    public BirdRecordWrapper SelectedBirdRecord
    {
        get => selectedBirdRecord;
        set
        {
            selectedBirdRecord = value;
            OnPropertyChanged();
        }
    }

    public void EditRow()
    {
        if (SelectedBirdRecord == null) return;
        var result = _birdRecordEditorViewer?.EditBirdRecord(SelectedBirdRecord);
        if (result == null) return;
        var index = BirdRecords.IndexOf(SelectedBirdRecord);
        BirdRecords.RemoveAt(index);
        BirdRecords.Insert(index, result);
    }

    private void ValidateData()
    {
        foreach (var record in BirdRecords) record.IsValid = Model?.CheckIsValid(record) ?? true;
    }

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

        ValidateData();
    }

    private void SaveDatabaseToCsv()
    {
        var records = BirdRecords.ToList();
        if (records.Count == 0) return;
        var filepath = _filePathLoader?.GetSaveFilePath();
        var parameters = new BirdRecordsSaverParameters
        {
            Filename = filepath,
            Records = Model?.AsSimpleRecords(records) ?? new List<BirdRecord>()
        };

        Model?.WriteRecordsToCsv(parameters);
    }
}