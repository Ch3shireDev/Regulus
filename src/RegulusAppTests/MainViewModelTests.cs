using RegulusApp.Models;
using RegulusApp.ViewModels;
using RegulusAppTests.Mockups;
using RegulusLibrary.DataStructures;

namespace RegulusAppTests;

[TestClass]
public class MainViewModelTests
{
    private MockFilePathLoader? filePathLoader;
    private MockBirdRecordsLoader? loader;
    private MainModel? model;
    private MainViewModel? viewModel;

    [TestInitialize]
    public void Initialize()
    {
        filePathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();

        model = new MainModel(loader);
        viewModel = new MainViewModel(model, filePathLoader);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        filePathLoader.FilePath = "test";

        viewModel.LoadDatabase();

        Assert.AreEqual(2, viewModel.RecordsViewModel.BirdRecords.Count);
        Assert.AreEqual(true, filePathLoader.IsGet);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}