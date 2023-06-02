using RegulusApp.Services;
using RegulusLibrary.DataStructures;

namespace RegulusAppTests.Mockups;

public class MockEditRecordViewer : IBirdRecordEditorViewer
{
    public BirdRecordWrapper EditBirdRecord(BirdRecordWrapper record)
    {
        throw new NotImplementedException();
    }
}