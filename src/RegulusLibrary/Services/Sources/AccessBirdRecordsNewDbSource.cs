using System.Data.OleDb;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public class AccessBirdRecordsNewDbSource : IBirdRecordsNewDbSource
{
    public AccessBirdRecordsNewDbSource(string fileName, string tableName)
    {
        FileName = fileName;
        TableName = tableName;
    }

    public AccessBirdRecordsNewDbSource()
    {
    }

    public string? FileName{ get; set; }
    public string? ConnectionString => $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FileName};Persist Security Info=False;";

    public string? TableName { get; set; }

    public IEnumerable<NewDbBirdRecord> Read()
    {
        using var connection = new OleDbConnection(ConnectionString);

        connection.Open();

        var query = $@"SELECT * FROM `{TableName}`";
        var command = new OleDbCommand(query, connection);

        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var record = new NewDbBirdRecord
                {
                    IDR_Podab = reader["IDR_Podab"] as double?,
                    IdBaza = reader["IdBaza"] as double?,
                    IdSezon = reader["IdSezon"] as double?,
                    IdZesz = reader["IdZesz"] as double?,
                    Ztyp = reader["Ztyp"] as string,
                    Znr = reader["Znr"] as double?,
                    Zpage = reader["Zpage"] as double?,
                    Zrow = reader["Zrow"] as double?,
                    CoStaSit = reader["CoStaSit"] as string,
                    Year = reader["Year"] as double?,
                    Seas = reader["Seas"] as string,
                    Date = reader["Date"] as string,
                    Pole13 = reader["Pole13"] as string,
                    Date2 = reader["Date2"] as string,
                    MD = reader["MD"] as double?,
                    Hour = reader["Hour"] as double?,
                    Pole17 = reader["Pole17"] as string,
                    RingType = reader["Ring Type"] as string,
                    RingSer = reader["Ring Ser"] as string,
                    RingNo = reader["Ring No"] as string,
                    Ring = reader["Ring"] as string,
                    Pole22 = reader["Pole22"] as string,
                    Stat = reader["Stat"] as string,
                    Net = reader["Net"] as string,
                    SpeciesCode = reader["Species Code"] as string,
                    EnglishName = reader["English Name"] as string,
                    LatinName = reader["Latin Name"] as string,
                    AddInfo = reader["AddInfo"] as string,
                    Sex = reader["Sex"] as string,
                    Pole30 = reader["Pole30"] as string,
                    QuestionMark = reader["'?'"] as string,
                    Euring = reader["Euring"] as string,
                    Age = reader["Age"] as string,
                    Pole34 = reader["Pole34"] as string,
                    Pole35 = reader["Pole35"] as string,
                    WIEK = reader["WIEK"] as string,
                    SZATA = reader["SZATA"] as string,
                    Fat = reader["Fat"] as double?,
                    Pole39 = reader["Pole39"] as string,
                    Tip = reader["Tip"] as string,
                    Pole41 = reader["Pole41"] as string,
                    M1 = reader["M1"] as string,
                    Pole43 = reader["Pole43"] as string,
                    M2 = reader["M2"] as string,
                    Pole45 = reader["Pole45"] as string,
                    M3 = reader["M3"] as string,
                    Pole47 = reader["Pole47"] as string,
                    M4 = reader["M4"] as string,
                    Pole49 = reader["Pole49"] as string,
                    M5 = reader["M5"] as string,
                    Pole51 = reader["Pole51"] as string,
                    M6 = reader["M6"] as string,
                    Pole53 = reader["Pole53"] as string,
                    D2 = reader["D2"] as double?,
                    Pole55 = reader["Pole55"] as string,
                    D3 = reader["D3"] as double?,
                    Pole57 = reader["Pole57"] as string,
                    D4 = reader["D4"] as double?,
                    Pole59 = reader["Pole59"] as string,
                    D5 = reader["D5"] as double?,
                    Pole61 = reader["Pole61"] as string,
                    D6 = reader["D6"] as double?,
                    Pole63 = reader["Pole63"] as string,
                    D7 = reader["D7"] as double?,
                    Pole65 = reader["Pole65"] as string,
                    D8 = reader["D8"] as double?,
                    Pole67 = reader["Pole67"] as string,
                    Extra1 = reader["Extra 1"] as string,
                    Pole69 = reader["Pole69"] as string,
                    Extra2 = reader["Extra 2"] as string,
                    Pole71 = reader["Pole71"] as string,
                    Wing = reader["Wing"] as double?,
                    Pole73 = reader["Pole73"] as string,
                    Tail = reader["Tail"] as double?,
                    Pole75 = reader["Pole75"] as string,
                    Weight = reader["Weight"] as double?,
                    Pole77 = reader["Pole77"] as string,
                    DW = reader["DW"] as string,
                    NotchDziób = reader["Notch/Dziób"] as string,
                    Pole80 = reader["Pole80"] as string,
                    LocN_Pazur_Kipp = reader["LocN/Pazur/Kipp"] as string,
                    Pole82 = reader["Pole82"] as string,
                    P1P2 = reader["P1-P2"] as string,
                    Pole84 = reader["Pole84"] as string,
                    P1PC = reader["P1-PC"] as string,
                    Pole86 = reader["Pole86"] as string,
                    Special5 = reader["Special 5"] as string,
                    Pole88 = reader["Pole88"] as string,
                    Special6 = reader["Special 6"] as string,
                    Pole90 = reader["Pole90"] as string,
                    Special7 = reader["Special 7"] as string,
                    Pole92 = reader["Pole92"] as string,
                    Special8 = reader["Special 8"] as string,
                    Pole94 = reader["Pole94"] as string,
                    Comments = reader["Comments"] as string,
                    Notes_T = reader["Notes_T"] as string,
                    CodeR = reader["CodeR"] as string,
                    KOND = reader["KOND"] as string,
                    OKOL = reader["OKOL"] as string,
                    CHWYT = reader["CHWYT"] as string,
                    WABIK = reader["WABIK"] as string,
                    MANIP = reader["MANIP"] as string,
                    PRZEM = reader["PRZEM"] as string,
                    NAZWOB2 = reader["NAZWOB2"] as string,
                    BŁĄD = reader["BŁĄD"] as string,
                    Godz = reader["Godz"] as DateTime?,
                    DT = reader["DT"] as DateTime?,
                    OB2 = reader["OB2"] as string,
                    TYP2 = reader["TYP2"] as string,
                    CTR2 = reader["CTR2"] as string,
                    KRZ2 = reader["KRZ2"] as string,
                    NROB2 = reader["NROB2"] as string,
                    Name = reader["Name"] as string,
                    OB1 = reader["OB1"] as string,
                    TYPE1 = reader["TYPE1"] as string,
                    CTR1 = reader["CTR1"] as string,
                    DD = reader["DD"] as string,
                    STATUS = reader["STATUS"] as string,
                    Index_l_prim = reader["Index l'"] as int?,
                    Index_e_prim = reader["Index e'"] as int?,
                    IndexL = reader["Index L"] as int?,
                    IndexE = reader["Index E"] as int?,
                    IndexH = reader["Index H"] as int?,
                    FotoB = reader["FotoB"] as string,
                    FotoW = reader["FotoW"] as string,
                    D9 = reader["D9"] as int?,
                    D10 = reader["D10"] as int?
                };

                yield return record;
            }
        }

        connection.Close();
    }
}