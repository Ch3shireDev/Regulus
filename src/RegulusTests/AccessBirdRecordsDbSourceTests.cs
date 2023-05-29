using RegulusLibrary.Services;
using RegulusLibrary.Services.Sources.DataStructures;
using RegulusTests.Mockups;

namespace RegulusTests;

[TestClass]
public class AccessBirdRecordsDbSourceTests
{
    private MockBirdRecordsNewDbSource? newDbSource;
    private MockBirdRecordsOldDbSource? oldDbSource;
    private AccessBirdRecordsDbSource? source;

    [TestInitialize]
    public void Initialize()
    {
        oldDbSource = new MockBirdRecordsOldDbSource();
        newDbSource = new MockBirdRecordsNewDbSource();

        source = new AccessBirdRecordsDbSource(oldDbSource, newDbSource);
    }

    [TestMethod]
    public void ReadTest()
    {
        oldDbSource.BirdRecords = new List<OldDbBirdRecord>
        {
            new OldDbBirdRecord
            {
                IDR_Podab = 1,
                Spec = "REG.REG",
                Sex = "F",
                Wing = 5,
                Tail = 10,
                Mass = 15,
                DT = new DateTime(2020, 01, 02, 03, 00, 00)
            }
        };

        newDbSource.BirdRecords = new List<NewDbBirdRecord>
        {
            new NewDbBirdRecord
            {
                IDR_Podab = 2,
                SpeciesCode = "PHY.LUS",
                Sex = "M",
                Wing = 6,
                Tail = 11,
                Weight = 16,
                DT = new DateTime(2021, 01, 02, 03, 00, 00)
            }
        };

        var records = source.Read().ToList();

        Assert.AreEqual(2, records.Count());

        Assert.AreEqual(1, records[0].Id);
        Assert.AreEqual("REG.REG", records[0].SpeciesCode);
        Assert.AreEqual("F", records[0].Sex);
        Assert.AreEqual(5, records[0].Wing);
        Assert.AreEqual(10, records[0].Tail);
        Assert.AreEqual(15, records[0].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 02, 03, 00, 00), records[0].DateTime);

        Assert.AreEqual(2, records[1].Id);
        Assert.AreEqual("PHY.LUS", records[1].SpeciesCode);
        Assert.AreEqual("M", records[1].Sex);
        Assert.AreEqual(6, records[1].Wing);
        Assert.AreEqual(11, records[1].Tail);
        Assert.AreEqual(16, records[1].Weight);
        Assert.AreEqual(new DateTime(2021, 01, 02, 03, 00, 00), records[1].DateTime);
    }
}