using RegulusLibrary.Services.Sources;
using RegulusTests.Properties;

namespace RegulusTests;

[TestClass]
public class CsvBirdRecordsNewDbSourceTests
{
    private CsvBirdRecordsNewDbSource? source;

    [TestInitialize]
    public void Initialize()
    {
        source = new CsvBirdRecordsNewDbSource();
    }

    [TestMethod]
    public void ReadRowTest()
    {
        source.StringReader = new StringReader(Resources.csv_example_new_db);
        var birds = source.Read().ToList();

        var birb = birds[0];
        Assert.AreEqual(100, birds.Count);


        Assert.AreEqual(1924534, birb.IDR_Podab);
        Assert.AreEqual(15471, birb.IdBaza);
        Assert.AreEqual(1, birb.IdSezon);
        Assert.AreEqual(1, birb.IdZesz);
        Assert.AreEqual("L", birb.Ztyp);
        Assert.AreEqual(1, birb.Znr);
        Assert.AreEqual(1, birb.Zpage);
        Assert.AreEqual(1, birb.Zrow);
        Assert.AreEqual("PL.BK.08", birb.CoStaSit);
        Assert.AreEqual(2017, birb.Year);
        Assert.AreEqual("S", birb.Seas);
        Assert.AreEqual("26.03", birb.Date);
        Assert.AreEqual("", birb.Pole13);
        Assert.AreEqual("2017-03-26", birb.Date2);
        Assert.AreEqual(326, birb.MD);
        Assert.AreEqual(6, birb.Hour);
        Assert.AreEqual("", birb.Pole17);
        Assert.AreEqual("LJ", birb.RingType);
        Assert.AreEqual("985", birb.RingSer);
        Assert.AreEqual("45", birb.RingNo);
        Assert.AreEqual("LJ98545", birb.Ring);
        Assert.AreEqual("", birb.Pole22);
        Assert.AreEqual("O", birb.Stat);
        Assert.AreEqual("M", birb.Net);
        Assert.AreEqual("REG.REG", birb.SpeciesCode);
        Assert.AreEqual("GOLDCREST", birb.EnglishName);
        Assert.AreEqual("REGULUS REGULUS", birb.LatinName);
        Assert.AreEqual("", birb.AddInfo);
        Assert.AreEqual("M", birb.Sex);
        Assert.AreEqual("", birb.Pole30);
        Assert.AreEqual("", birb.QuestionMark);
        Assert.AreEqual("2", birb.Euring);
        Assert.AreEqual("I", birb.Age);
        Assert.AreEqual("", birb.Pole34);
        Assert.AreEqual("", birb.Pole35);
        Assert.AreEqual("2", birb.WIEK);
        Assert.AreEqual("", birb.SZATA);
        Assert.AreEqual(0, birb.Fat);
        Assert.AreEqual("", birb.Pole39);
        Assert.AreEqual("45", birb.Tip);
        Assert.AreEqual("", birb.Pole41);
        Assert.AreEqual("1", birb.M1);
        Assert.AreEqual("", birb.Pole43);
        Assert.AreEqual("1", birb.M2);
        Assert.AreEqual("", birb.Pole45);
        Assert.AreEqual("5", birb.M3);
        Assert.AreEqual("", birb.Pole47);
        Assert.AreEqual("06", birb.M4);
        Assert.AreEqual("", birb.Pole49);
        Assert.AreEqual("7", birb.M5);
        Assert.AreEqual("", birb.Pole51);
        Assert.AreEqual("", birb.M6);
        Assert.AreEqual("", birb.Pole53);
        Assert.AreEqual(6, birb.D2);
        Assert.AreEqual("", birb.Pole55);
        Assert.AreEqual(1, birb.D3);
        Assert.AreEqual("", birb.Pole57);
        Assert.AreEqual(0, birb.D4);
        Assert.AreEqual("", birb.Pole59);
        Assert.AreEqual(0, birb.D5);
        Assert.AreEqual("", birb.Pole61);
        Assert.AreEqual(1, birb.D6);
        Assert.AreEqual("", birb.Pole63);
        Assert.AreEqual(5, birb.D7);
        Assert.AreEqual("", birb.Pole65);
        Assert.AreEqual(7, birb.D8);
        Assert.AreEqual("", birb.Pole67);
        Assert.AreEqual("", birb.Extra1);
        Assert.AreEqual("", birb.Pole69);
        Assert.AreEqual("", birb.Extra2);
        Assert.AreEqual("", birb.Pole71);
        Assert.AreEqual(53, birb.Wing);
        Assert.AreEqual("", birb.Pole73);
        Assert.AreEqual(42, birb.Tail);
        Assert.AreEqual("", birb.Pole75);
        Assert.AreEqual(4.9, birb.Weight);
        Assert.AreEqual("", birb.Pole77);
        Assert.AreEqual("0.1", birb.DW);
        Assert.AreEqual("", birb.NotchDziób);
        Assert.AreEqual("", birb.Pole80);
        Assert.AreEqual("", birb.LocN_Pazur_Kipp);
        Assert.AreEqual("", birb.Pole82);
        Assert.AreEqual("21", birb.P1P2);
        Assert.AreEqual("", birb.Pole84);
        Assert.AreEqual("+7", birb.P1PC);
        Assert.AreEqual("", birb.Pole86);
        Assert.AreEqual(null, birb.Special5);
        Assert.AreEqual(null, birb.Pole88);
        Assert.AreEqual(null, birb.Special6);
        Assert.AreEqual(null, birb.Pole90);
        Assert.AreEqual(null, birb.Special7);
        Assert.AreEqual(null, birb.Pole92);
        Assert.AreEqual(null, birb.Special8);
        Assert.AreEqual(null, birb.Pole94);
        Assert.AreEqual("", birb.Comments);
        Assert.AreEqual(null, birb.Notes_T);
        Assert.AreEqual("KRS", birb.CodeR);
        Assert.AreEqual("ŻYWOB", birb.KOND);
        Assert.AreEqual("25", birb.OKOL);
        Assert.AreEqual("SIEĆ", birb.CHWYT);
        Assert.AreEqual("BEZ", birb.WABIK);
        Assert.AreEqual("-", birb.MANIP);
        Assert.AreEqual("-", birb.PRZEM);
        Assert.AreEqual("STĘPNIEWSKI,KRZYSZTOF", birb.NAZWOB2);
        Assert.AreEqual("", birb.BŁĄD);
        Assert.AreEqual(new DateTime(1899, 12, 30, 06, 00, 00), birb.Godz);
        Assert.AreEqual(new DateTime(2017, 03, 26, 06, 00, 00), birb.DT);
        Assert.AreEqual(null, birb.OB2);
        Assert.AreEqual(null, birb.TYP2);
        Assert.AreEqual(null, birb.CTR2);
        Assert.AreEqual(null, birb.KRZ2);
        Assert.AreEqual(null, birb.NROB2);
        Assert.AreEqual("KRZYSZTOF STĘPNIEWSKI", birb.Name);
        Assert.AreEqual("O", birb.OB1);
        Assert.AreEqual("MET", birb.TYPE1);
        Assert.AreEqual("PLG", birb.CTR1);
        Assert.AreEqual("0", birb.DD);
        Assert.AreEqual("?", birb.STATUS);
        Assert.AreEqual(null, birb.Index_l_prim);
        Assert.AreEqual(null, birb.Index_e_prim);
        Assert.AreEqual(null, birb.IndexL);
        Assert.AreEqual(null, birb.IndexE);
        Assert.AreEqual(null, birb.IndexH);
        Assert.AreEqual(null, birb.FotoB);
        Assert.AreEqual(null, birb.FotoW);
        Assert.AreEqual(null, birb.D9);
        Assert.AreEqual(null, birb.D10);
    }
}