using System.Windows;
using System.Windows.Input;
using RegulusApp.Helpers;
using RegulusLibrary.DataStructures;

namespace RegulusApp.ViewModels;

public class EditRecordViewModel : ViewModelBase
{
    public EditRecordViewModel()
    {
    }

    public EditRecordViewModel(BirdRecordWrapper recordWrapper)
    {
        Model = recordWrapper;
    }

    public BirdRecordWrapper Model { get; set; }
    public ICommand SaveCommand => new RelayCommand(Save);

    public ICommand CancelCommand => new RelayCommand(Cancel);

    private void Save(object windowObj)
    {
        var window = (Window)windowObj;

        try
        {
            window.DialogResult = true;
        }
        catch
        {
            //
        }

        window.Close();
    }

    private void Cancel(object windowObj)
    {
        var window = (Window)windowObj;

        try
        {
            window.DialogResult = false;
        }
        catch
        {
            //
        }

        window.Close();
    }
}