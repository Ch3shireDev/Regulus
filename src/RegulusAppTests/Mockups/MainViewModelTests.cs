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

    [TestInitialize]
    public void Initialize()
    {
        filePathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        writer = new MockBirdRecordsWriter();

        model = new MainModel(loader, writer);
        viewModel = new MainViewModel(model, filePathLoader);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        filePathLoader.FilePath = "test";

        viewModel.LoadDatabase();

        Assert.AreEqual(2, viewModel.RecordsViewModel.BirdRecords.Count);
        Assert.AreEqual(true, filePathLoader.IsGetOpen);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}