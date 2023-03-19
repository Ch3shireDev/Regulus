using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;
using System.Collections;
using System.Collections.Generic;

namespace RegulusApp.Models;

public class MainModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;

    public MainModel(IBirdRecordsLoader birdRecordsLoader)
    {
        _birdRecordsLoader = birdRecordsLoader;

        RecordsModel = new RecordsModel(birdRecordsLoader);
    }

    public RecordsModel RecordsModel { get; set; }
}