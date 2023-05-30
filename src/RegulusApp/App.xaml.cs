using System.Windows;
using RegulusApp.Models;
using RegulusApp.Services;
using RegulusApp.ViewModels;
using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Processors;
using RegulusLibrary.Services.Validators;
using RegulusLibrary.Services.Writers;

namespace RegulusApp;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var filePathLoader = new FilePathLoader();
        var loader = new BirdRecordsLoader();
        var writer = new BirdsRecordsCsvWriter();
        var processor = new BirdRecordsProcessor();
        var validator = new BirdRecordsValidator
        {
            TailNumberOfStandardDeviations = 5,
            WingNumberOfStandardDeviations = 2,
            WeightNumberOfStandardDeviations = 3
        };
        var model = new MainModel(loader, writer, processor, validator);
        var viewModel = new MainViewModel(model, filePathLoader);
        var window = new MainWindow
        {
            DataContext = viewModel
        };
        window.Show();
    }
}