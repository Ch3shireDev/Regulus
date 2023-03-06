using RegulusLibrary.Services;

namespace RegulusTests;

[TestClass]
public class BirdRecordCsvDataReaderTests
{
    //private BirdRecordCsvDataReader csvReader;

    [TestInitialize]
    public void Initialize()
    {
    }

    [TestMethod]
    public void ReadRowTest()
    {
        var str = @"IDR_Podab,Species Code,English Name,Latin Name,Sex,Wing,Tail,Weight
1987091,TUR.MER,BLACKBIRD,TURDUS MERULA,F,10,20,30";

        var reader = new StringReader(str);

        var csvReader = new BirdRecordCsvDataReader(reader);

        var birds = csvReader.Read().ToList();

        var birb = birds[0];
        Assert.AreEqual(1, birds.Count);
        Assert.AreEqual(1987091, birb.IDR_Podab);
        Assert.AreEqual("TUR.MER", birb.SpeciesCode);
        Assert.AreEqual("BLACKBIRD", birb.EnglishName);
        Assert.AreEqual("TURDUS MERULA", birb.LatinName);
        Assert.AreEqual("F", birb.Sex);
        Assert.AreEqual(10, birb.Wing);
        Assert.AreEqual(20, birb.Tail);
        Assert.AreEqual(30, birb.Weight);
    }
}