using System.Windows.Input;
using RegulusApp.Helpers;
using RegulusApp.Models;
using RegulusLibrary.Services;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IFilePathLoader? _filePathLoader;

    public MainViewModel()
    {
        RecordsViewModel = new RecordsViewModel();
        ConfigViewModel = new ConfigViewModel();
    }

    public MainViewModel(MainModel model, IFilePathLoader filePathLoader)
    {
        _filePathLoader = filePathLoader;
        Model = model;

        RecordsViewModel = new RecordsViewModel(model.RecordsModel, filePathLoader);
        ConfigViewModel = new ConfigViewModel();
    }

    private MainModel? Model { get; }

    public ICommand LoadDatabaseCommand => new RelayCommand(p => LoadDatabase());
    public RecordsViewModel RecordsViewModel { get; set; }
    public ConfigViewModel ConfigViewModel { get; set; }

    public void LoadDatabase()
    {
        RecordsViewModel.LoadDatabase();
    }
}