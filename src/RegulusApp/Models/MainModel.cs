using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Processors;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class MainModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;

    public MainModel(IBirdRecordsLoader birdRecordsLoader, IBirdRecordsWriter writer, IBirdRecordsProcessor processor)
    {
        _birdRecordsLoader = birdRecordsLoader;

        RecordsModel = new RecordsModel(birdRecordsLoader, writer, processor);
    }

    public RecordsModel RecordsModel { get; set; }
}