using System.Windows;
using RegulusApp.Models;
using RegulusApp.Services;
using RegulusApp.ViewModels;
using RegulusLibrary.Services.Loaders;
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
        var model = new MainModel(loader, writer);
        var viewModel = new MainViewModel(model, filePathLoader);
        var window = new MainWindow
        {
            DataContext = viewModel
        };
        window.Show();
    }
}