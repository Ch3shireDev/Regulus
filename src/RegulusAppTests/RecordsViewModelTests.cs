using RegulusApp.Models;
using RegulusApp.ViewModels;
using RegulusAppTests.Mockups;
using RegulusLibrary.DataStructures;
using System.ComponentModel.DataAnnotations;

namespace RegulusAppTests;

[TestClass]
public class RecordsViewModelTests
{
    private MockBirdRecordsLoader? loader;
    private RecordsModel? model;
    private MockFilePathLoader? pathLoader;
    private RecordsViewModel? viewModel;
    private MockBirdRecordsWriter? writer;
    private MockBirdRecordProcessor? processor;
    private MockBirdRecordsValidator? validator;

    [TestInitialize]
    public void Initialize()
    {
        pathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        writer = new MockBirdRecordsWriter();
        processor = new MockBirdRecordProcessor();
        validator = new MockBirdRecordsValidator();
        model = new RecordsModel(loader, writer, processor, validator);
        viewModel = new RecordsViewModel(model, pathLoader);
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