using RegulusApp.Models;
using RegulusApp.ViewModels;
using RegulusAppTests.Mockups;
using RegulusLibrary.DataStructures;

namespace RegulusAppTests;

[TestClass]
public class RecordsViewModelTests
{
    private MockBirdRecordsLoader? loader;
    private RecordsModel? model;
    private MockFilePathLoader? pathLoader;
    private MockBirdRecordProcessor? processor;
    private MockBirdRecordsValidator? validator;
    private MockBirdRecordEditorViewer viewer;
    private RecordsViewModel? viewModel;
    private MockBirdRecordsWriter? writer;

    [TestInitialize]
    public void Initialize()
    {
        pathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        writer = new MockBirdRecordsWriter();
        processor = new MockBirdRecordProcessor();
        validator = new MockBirdRecordsValidator();
        viewer = new MockBirdRecordEditorViewer();
        model = new RecordsModel(loader, writer, processor, validator);
        viewModel = new RecordsViewModel(model, pathLoader, viewer);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        pathLoader.FilePath = "test";
        processor.OutputData = new List<BirdRecordWrapper> { new BirdRecordWrapper(), new BirdRecordWrapper() };

        viewModel.LoadDatabase();

        Assert.AreEqual(true, processor.IsProcessCalled);
        Assert.AreEqual(2, processor.InputData.Count());
        Assert.AreEqual(2, viewModel.BirdRecords.Count);
        Assert.AreEqual(true, pathLoader.IsGetOpen);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}