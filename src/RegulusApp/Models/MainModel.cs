using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Processors;
using RegulusLibrary.Services.Validators;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class MainModel
{
    public MainModel(IBirdRecordsLoader birdRecordsLoader, IBirdRecordsWriter writer, IBirdRecordsProcessor processor, IBirdRecordsValidator validator)
    {
        RecordsModel = new RecordsModel(birdRecordsLoader, writer, processor, validator);
    }

    public RecordsModel RecordsModel { get; set; }
}