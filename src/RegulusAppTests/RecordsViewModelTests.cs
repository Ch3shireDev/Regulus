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
    private RecordsViewModel? viewModel;
    private MockBirdRecordsWriter? writer;


    [TestInitialize]
    public void Initialize()
    {
        pathLoader = new MockFilePathLoader();
        loader = new MockBirdRecordsLoader();
        writer = new MockBirdRecordsWriter();
        model = new RecordsModel(loader, writer);
        viewModel = new RecordsViewModel(model, pathLoader);
    }

    [TestMethod]
    public void LoadDatabaseTest()
    {
        loader.BirdRecords = new List<BirdRecord> { new BirdRecord(), new BirdRecord() };
        pathLoader.FilePath = "test";

        viewModel.LoadDatabase();

        Assert.AreEqual(2, viewModel.BirdRecords.Count);
        Assert.AreEqual(true, pathLoader.IsGetOpen);
        Assert.AreEqual("test", loader.Parameters.Filename);
    }
}