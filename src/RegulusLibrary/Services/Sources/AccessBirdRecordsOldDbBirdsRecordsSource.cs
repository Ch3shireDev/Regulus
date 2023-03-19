using System.Data.OleDb;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public class AccessBirdRecordsOldDbBirdsRecordsSource : IBirdRecordsOldDbSource
{
    public AccessBirdRecordsOldDbBirdsRecordsSource()
    {
    }

    public AccessBirdRecordsOldDbBirdsRecordsSource(string fileName, string tableName)
    {
        FileName = fileName;
        TableName = tableName;
    }

    public string FileName { get; set; }
    public string TableName { get; set; }
    public string ConnectionString => $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FileName};Persist Security Info=False;";

    public IEnumerable<OldDbBirdRecord> Read()
    {
        using var connection = new OleDbConnection(ConnectionString);

        connection.Open();

        var query = $@"SELECT * FROM `{TableName}`";
        var command = new OleDbCommand(query, connection);

        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var record = new OldDbBirdRecord
                {
                    IDR_Podab = reader["IDR_Podab"] as int? ?? 0,
                    IdrZesz = reader["IdrZesz"] as int?,
                    IdBase = reader["IdBase"] as Int16?,
                    IdInp = reader["IdInp"] as int?,
                    Sta = reader["Sta"] as string,
                    Row = reader["Row"] as int?,
                    ST = reader["ST"] as string,
                    CoStaSit = reader["CoStaSit"] as string,
                    Year = reader["Year"] as Int16?,
                    Seas = reader["Seas"] as string,
                    Date = reader["Date"] as DateTime?,
                    Hour = reader["Hour"] as Int16?,
                    Ring = reader["Ring"] as string,
                    Status = reader["Status"] as string,
                    Spec = reader["Spec"] as string,
                    Sex = reader["Sex"] as string,
                    Age = reader["Age"] as string,
                    Ringer = reader["Ringer"] as string,
                    Mass = reader["Mass"] as float?,
                    Fat = reader["Fat"] as float?,
                    Wing = reader["Wing"] as float?,
                    Tail = reader["Tail"] as float?,
                    D2 = reader["D2"] as float?,
                    D3 = reader["D3"] as float?,
                    D4 = reader["D4"] as float?,
                    D5 = reader["D5"] as float?,
                    D6 = reader["D6"] as float?,
                    D7 = reader["D7"] as float?,
                    D8 = reader["D8"] as float?,
                    PP = reader["PP"] as string,
                    P1 = reader["P1"] as string,
                    P2 = reader["P2"] as string,
                    P3 = reader["P3"] as string,
                    P4 = reader["P4"] as string,
                    P5 = reader["P5"] as string,
                    P6 = reader["P6"] as string,
                    Notes = reader["Notes"] as string,
                    OK = reader["OK"] as byte?,
                    TS_Import = reader["TS_Import"] as DateTime?,
                    TS_Zesz = reader["TS_Zesz"] as DateTime?,
                    Sel = reader["Sel"] as bool?,
                    MD = reader["MD"] as Int16?,
                    RNG = reader["RNG"] as string,
                    AgeT = reader["AgeT"] as string,
                    DT = reader["DT"] as DateTime?,
                    Ztyp = reader["Ztyp"] as string,
                    Znr = reader["Znr"] as int?,
                    P1PC = reader["P1PC"] as double?,
                    P2PC = reader["P2PC"] as double?,
                    P1P2 = reader["P1P2"] as double?,
                    Kipp = reader["Kipp"] as double?,
                    Tarsus = reader["Tarsus"] as string,
                    THL = reader["THL"] as double?,
                    Bill1 = reader["Bill1"] as string,
                    Bill2 = reader["Bill2"] as double?,
                    Claw = reader["Claw"] as double?,
                    Emarg = reader["Emarg"] as double?,
                    Notch_mm = reader["Notch_mm"] as string,
                    Notch_tip = reader["Notch_tip"] as double?,
                    Moult_short = reader["Moult_short"] as string,
                    Parasite = reader["Parasite"] as string,
                    N_unmoult_cov = reader["N_unmoult_cov"] as int?,
                    X1 = reader["X1"] as double?,
                    X2 = reader["X2"] as double?,
                    X3 = reader["X3"] as double?,
                    X4 = reader["X4"] as double?,
                    X5 = reader["X5"] as double?,
                    X6 = reader["X6"] as double?,
                    Net = reader["Net"] as string
                };
                yield return record;
            }
        }
    }
}