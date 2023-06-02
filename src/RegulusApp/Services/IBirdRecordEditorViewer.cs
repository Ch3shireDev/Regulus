using RegulusApp.ViewModels;
using RegulusLibrary.DataStructures;

namespace RegulusApp.Services;

public interface IBirdRecordEditorViewer
{
    BirdRecordWrapper EditBirdRecord(BirdRecordWrapper record);
}

internal class BirdRecordEditorViewer : IBirdRecordEditorViewer
{
    public BirdRecordWrapper EditBirdRecord(BirdRecordWrapper record)
    {
        var recordCopy = new BirdRecordWrapper(record);

        var viewModel = new EditRecordViewModel(recordCopy);

        var editRecordView = new EditRecordWindow
        {
            DataContext = viewModel
        };

        var result = editRecordView.ShowDialog();

        if (result == true)
        {
            return recordCopy;
        }

        return record;
    }
}