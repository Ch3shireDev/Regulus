using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class MainModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;

    public MainModel(IBirdRecordsLoader birdRecordsLoader, IBirdRecordsWriter writer)
    {
        _birdRecordsLoader = birdRecordsLoader;

        RecordsModel = new RecordsModel(birdRecordsLoader, writer);
    }

    public RecordsModel RecordsModel { get; set; }
}