using RegulusLibrary.Services.Sources;

namespace RegulusTests;

[TestClass]
public class AccessBirdRecordsOldDbSourceTests
{
    private AccessBirdRecordsOldDbSource? source;

    [TestInitialize]
    public void Initialize()
    {
        source = new AccessBirdRecordsOldDbSource();
    }

    [TestMethod]
    public void ReadRowTest()
    {
        source.FileName = @"Resources\access_example_old_db.mdb";
        source.TableName = "Tab_Ring_Podab";

        var results = source.Read().ToList();
        var result = results[0];
        Assert.AreEqual(2, results.Count);

        Assert.AreEqual(1, result.IDR_Podab);
        Assert.AreEqual(128, result.IdrZesz);
        Assert.AreEqual(1, result.IDR_Podab);
        Assert.AreEqual(128, result.IdrZesz);
        Assert.AreEqual(2007, result.IdBase);
        Assert.AreEqual(null, result.IdInp);
        Assert.AreEqual("BU", result.Sta);
        Assert.AreEqual(129, result.Row);
        Assert.AreEqual("BK", result.ST);
        Assert.AreEqual("PL.BK.01", result.CoStaSit);
        Assert.AreEqual(1967, result.Year);
        Assert.AreEqual("A", result.Seas);
        Assert.AreEqual(new DateTime(1967, 08, 16), result.Date);
        Assert.AreEqual(18, result.Hour);
        Assert.AreEqual("J634038", result.Ring);
        Assert.AreEqual("O", result.Status);
        Assert.AreEqual("PHY.LUS", result.Spec);
        Assert.AreEqual(null, result.Sex);
        Assert.AreEqual("I", result.Age);
        Assert.AreEqual(null, result.Ringer);
        Assert.AreEqual(9, result.Mass);
        Assert.AreEqual(0, result.Fat);
        Assert.AreEqual(61, result.Wing);
        Assert.AreEqual(45, result.Tail);
        Assert.AreEqual(5, result.D2);
        Assert.AreEqual(0, result.D3);
        Assert.AreEqual(0, result.D4);
        Assert.AreEqual(2, result.D5);
        Assert.AreEqual(6, result.D6);
        Assert.AreEqual(8, result.D7);
        Assert.AreEqual(10, result.D8);
        Assert.AreEqual(null, result.PP);
        Assert.AreEqual(null, result.P1);
        Assert.AreEqual(null, result.P2);
        Assert.AreEqual(null, result.P3);
        Assert.AreEqual(null, result.P4);
        Assert.AreEqual("+4", result.P5);
        Assert.AreEqual(null, result.P6);
        Assert.AreEqual(null, result.Notes);
        Assert.AreEqual(1, result.OK);
        Assert.AreEqual(null, result.TS_Import);
        Assert.AreEqual(null, result.TS_Zesz);
        Assert.AreEqual(true, result.Sel);
        Assert.AreEqual(816, result.MD);
        Assert.AreEqual(null, result.RNG);
        Assert.AreEqual("1", result.AgeT);
        Assert.AreEqual(new DateTime(1967, 08, 16, 18, 00, 00), result.DT);
        Assert.AreEqual("L", result.Ztyp);
        Assert.AreEqual(1, result.Znr);
        Assert.AreEqual(null, result.P1PC);
        Assert.AreEqual(null, result.P2PC);
        Assert.AreEqual(null, result.P1P2);
        Assert.AreEqual(null, result.Kipp);
        Assert.AreEqual(null, result.Tarsus);
        Assert.AreEqual(null, result.THL);
        Assert.AreEqual(null, result.Bill1);
        Assert.AreEqual(null, result.Bill2);
        Assert.AreEqual(null, result.Claw);
        Assert.AreEqual(null, result.Emarg);
        Assert.AreEqual(null, result.Notch_mm);
        Assert.AreEqual(null, result.Notch_tip);
        Assert.AreEqual(null, result.Moult_short);
        Assert.AreEqual(null, result.Parasite);
        Assert.AreEqual(null, result.N_unmoult_cov);
        Assert.AreEqual(null, result.X1);
        Assert.AreEqual(null, result.X2);
        Assert.AreEqual(null, result.X3);
        Assert.AreEqual(null, result.X4);
        Assert.AreEqual(null, result.X5);
        Assert.AreEqual(null, result.X6);
        Assert.AreEqual(null, result.Net);
    }
}