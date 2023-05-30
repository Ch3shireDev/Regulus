using System.Collections;
using System.ComponentModel.DataAnnotations;
using RegulusApp.Models;
using RegulusApp.ViewModels;
using RegulusLibrary.DataStructures;

namespace RegulusAppTests.Mockups;

[TestClass]
public class MainViewModelTests
{
    private MockFilePathLoader? filePathLoader;
    private MockBirdRecordsLoader? loader;
    private MainModel? model;
    private MainViewModel? viewModel;
    private MockBirdRecordsWriter? writer;
    private MockBirdRecordProcessor? processor;
    private MockBirdRecordsValidator? validator;

    [TestInitialize]
    public void Initialize()
    {
        filePathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        writer = new MockBirdRecordsWriter();
        processor = new MockBirdRecordProcessor();
        validator = new MockBirdRecordsValidator();

        model = new MainModel(loader, writer, processor, validator);
        viewModel = new MainViewModel(model, filePathLoader);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        filePathLoader.FilePath = "test";
        processor.OutputData = new List<BirdRecordWrapper> { new BirdRecordWrapper(), new BirdRecordWrapper() };

        viewModel.LoadDatabase();

        Assert.AreEqual(true, processor.IsProcessCalled);
        Assert.AreEqual(2, processor.InputData.Count());
        Assert.AreEqual(2, viewModel.RecordsViewModel.BirdRecords.Count);
        Assert.AreEqual(true, filePathLoader.IsGetOpen);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}