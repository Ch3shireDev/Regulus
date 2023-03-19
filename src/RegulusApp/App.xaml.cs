using System.Windows;
using RegulusApp.Models;
using RegulusApp.Services;
using RegulusApp.ViewModels;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var filePathLoader = new FilePathLoader();
        var model = new MainModel(new BirdRecordsLoader());
        var viewModel = new MainViewModel(model, filePathLoader);
        var window = new MainWindow
        {
            DataContext = viewModel
        };
        window.Show();
    }
}