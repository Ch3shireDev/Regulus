using RegulusApp.Models;
using RegulusApp.ViewModels;
using RegulusAppTests.Mockups;
using RegulusLibrary.DataStructures;

namespace RegulusAppTests;

[TestClass]
public class RecordsViewModelTests
{
    private MockBirdRecordsLoader? loader;
    private MockFilePathLoader? pathLoader;
    private RecordsModel? model;
    private RecordsViewModel? viewModel;

    [TestInitialize]
    public void Initialize()
    {
        pathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        model = new RecordsModel(loader);
        viewModel = new RecordsViewModel(model, pathLoader);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        pathLoader.FilePath = "test";

        viewModel.LoadDatabase();

        Assert.AreEqual(2, viewModel.BirdRecords.Count);
        Assert.AreEqual(true, pathLoader.IsGet);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}