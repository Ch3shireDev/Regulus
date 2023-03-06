using CsvHelper.Configuration.Attributes;

namespace RegulusLibrary.DataStructures;

public record DbData
{
    /// <summary>
    ///     Identyfikator rekordu w bazie.
    /// </summary>
    [Name("ID_Record")]
    public string? ID_Record { get; set; }

    /// <summary>
    ///     Klucz wiążący z plikiem i pozycją w pliku RINGER.
    /// </summary>
    [Name("ID_RINGER")]
    public string? ID_RINGER { get; set; }

    /// <summary>
    ///     Źródło danych.
    /// </summary>
    [Name("Source")]
    public string? Source { get; set; }

    /// <summary>
    ///     Typ zeszytu w RINGER.
    /// </summary>
    [Name("Ztyp")]
    public string? Ztyp { get; set; }

    /// <summary>
    ///     Numer zeszytu danego Typu.
    /// </summary>
    [Name("Znr")]
    public string? Znr { get; set; }

    /// <summary>
    ///     Numer strony w zeszycie.
    /// </summary>
    [Name("Zpage")]
    public string? Zpage { get; set; }

    /// <summary>
    ///     Numer wiersza na stronie.
    /// </summary>
    [Name("Zrow")]
    public string? Zrow { get; set; }

    /// <summary>
    ///     dwuliterowy kod kraju.
    /// </summary>
    [Name("CA")]
    public string? CA { get; set; }

    /// <summary>
    ///     dwuliterowy kod stacji.
    /// </summary>
    [Name("ST")]
    public string? ST { get; set; }

    /// <summary>
    ///     dwucyfrowy kod położenia stacji.
    /// </summary>
    [Name("LO1")]
    public string? LO1 { get; set; }

    /// <summary>
    ///     nazwa konkretnego miejsca.
    /// </summary>
    [Name("LO2")]
    public string? LO2 { get; set; }

    /// <summary>
    ///     rok.
    /// </summary>
    [Name("Year")]
    public string? Year { get; set; }

    /// <summary>
    ///     miesiąc.
    /// </summary>
    [Name("Month")]
    public string? Month { get; set; }

    /// <summary>
    ///     dzień.
    /// </summary>
    [Name("Day")]
    public string? Day { get; set; }

    /// <summary>
    ///     Informacja dotycząca niepewność co do dnia.
    /// </summary>
    [Name("DateInf")]
    public string? DateInf { get; set; }

    /// <summary>
    ///     godzina.
    /// </summary>
    [Name("Hour")]
    public string? Hour { get; set; }

    /// <summary>
    ///     Informacja dotycząca niepewność co do godziny.
    /// </summary>
    [Name("HourInf")]
    public string? HourInf { get; set; }

    /// <summary>
    ///     sezon.
    /// </summary>
    [Name("Seas")]
    public string? Seas { get; set; }

    /// <summary>
    ///     centrala pierwszej obrączki(metalowej).
    /// </summary>
    [Name("Centr1")]
    public string? Centr1 { get; set; }

    /// <summary>
    ///     numer obrączki.
    /// </summary>
    [Name("Ring1")]
    public string? Ring1 { get; set; }

    /// <summary>
    ///     potwierdzenie nietypowej obrączki.
    /// </summary>
    [Name("Ring!")]
    public string? RingConfirm { get; set; }

    /// <summary>
    ///     status zeszytowo-ringerowy.
    /// </summary>
    [Name("Stat0")]
    public string? Stat0 { get; set; }

    /// <summary>
    ///     centrala drugiej obrączki(metalowej).
    /// </summary>
    [Name("Centr2")]
    public string? Centr2 { get; set; }

    /// <summary>
    ///     numer drugiej obrączki.
    /// </summary>
    [Name("Ring2")]
    public string? Ring2 { get; set; }

    /// <summary>
    ///     status obrączki nr 2.
    /// </summary>
    [Name("StatRI2")]
    public string? StatRI2 { get; set; }

    /// <summary>
    ///     umiejscowienie kolorowej obrączki nr 1.
    /// </summary>
    [Name("TypCol")]
    public string? TypCol { get; set; }

    /// <summary>
    ///     kolor kolorowej obrączki nr 1.
    /// </summary>
    [Name("Ring3_Col")]
    public string? Ring3_Col { get; set; }

    /// <summary>
    ///     numer kolorowej obrączki.
    /// </summary>
    [Name("No.Col")]
    public string? No_Col { get; set; }

    /// <summary>
    ///     status kolorowej obrączki.
    /// </summary>
    [Name("StatRI3")]
    public string? StatRI3 { get; set; }

    /// <summary>
    ///     umiejscowienie kolorowej obrączki nr 2.
    /// </summary>
    [Name("TypCol2")]
    public string? TypCol2 { get; set; }

    /// <summary>
    ///     kolor kolorowej obrączki nr 2.
    /// </summary>
    [Name("Ring4_Col2")]
    public string? Ring4_Col2 { get; set; }

    /// <summary>
    ///     numer kolejnej obrączki/drugiej kolorowej.
    /// </summary>
    [Name("Ring4")]
    public string? Ring4 { get; set; }

    /// <summary>
    ///     status kolejnej obrączki/drugiej kolorowej.
    /// </summary>
    [Name("StatRI4")]
    public string? StatRI4 { get; set; }

    /// <summary>
    ///     Sieć(numer lub typ).
    /// </summary>
    [Name("Net")]
    public string? Net { get; set; }

    /// <summary>
    ///     Sześcioliterowy kod gatunku.
    /// </summary>
    [Name("Spec")]
    public string? Spec { get; set; }

    /// <summary>
    ///     płeć.
    /// </summary>
    [Name("Sex")]
    public string? Sex { get; set; }

    /// <summary>
    ///     !/?.
    /// </summary>
    [Name("SexInf")]
    public string? SexInf { get; set; }

    /// <summary>
    ///     wiek szatowy.
    /// </summary>
    [Name("Age")]
    public string? Age { get; set; }

    /// <summary>
    ///     !/?.
    /// </summary>
    [Name("AgeInf")]
    public string? AgeInf { get; set; }

    /// <summary>
    ///     wiek.
    /// </summary>
    [Name("AgeEURING")]
    public string? AgeEURING { get; set; }

    /// <summary>
    ///     Kod obrączkarza.
    /// </summary>
    [Name("Ringer")]
    public string? Ringer { get; set; }

    /// <summary>
    ///     Kod mierzącego.
    /// </summary>
    [Name("Ringer2")]
    public string? Ringer2 { get; set; }

    /// <summary>
    ///     masa.
    /// </summary>
    [Name("Mass")]
    public string? Mass { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Mass!")]
    public string? MassConfirm { get; set; }

    /// <summary>
    ///     dokładność pomiaru masy.
    /// </summary>
    [Name("Dmass")]
    public string? Dmass { get; set; }

    /// <summary>
    ///     otłuszczenie.
    /// </summary>
    [Name("Fat")]
    public string? Fat { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Fat!")]
    public string? FatConfirm { get; set; }

    /// <summary>
    ///     skrzydło.
    /// </summary>
    [Name("Wing")]
    public string? Wing { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Wing!")]
    public string? WingConfirm { get; set; }

    /// <summary>
    ///     ogon.
    /// </summary>
    [Name("Tail")]
    public string? Tail { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Tail!")]
    public string? TailConfirm { get; set; }

    /// <summary>
    ///     dystans: szczyt pierwszej lotki do szczytu pokryw pierwszorzędowych.
    /// </summary>
    [Name("P1-PC")]
    public string? P1_PC { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("P1-PC!")]
    public string? P1_PCConfirm { get; set; }

    /// <summary>
    ///     dystans: szczyt drugiej lotki do szczytu pokryw pierwszorzędowych.
    /// </summary>
    [Name("P2-PC")]
    public string? P2_PC { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("P2-PC!")]
    public string? P2_PCConfirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("P1-P2")]
    public string? P1_P2 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("P1-P2!")]
    public string? P1_P2Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D2")]
    public string? D2 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D2!")]
    public string? D2Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D3")]
    public string? D3 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D3!")]
    public string? D3Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D4")]
    public string? D4 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D4!")]
    public string? D4Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D5")]
    public string? D5 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D5!")]
    public string? D5Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D6")]
    public string? D6 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D6!")]
    public string? D6Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D7")]
    public string? D7 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D7!")]
    public string? D7Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D8")]
    public string? D8 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D8!")]
    public string? D8Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D9")]
    public string? D9 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D9!")]
    public string? D9Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("D10")]
    public string? D10 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("D10!")]
    public string? D10Confirm { get; set; }

    /// <summary>
    ///     formuła skrzydła.
    /// </summary>
    [Name("Kipp")]
    public string? Kipp { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Kipp!")]
    public string? KippConfirm { get; set; }

    /// <summary>
    ///     szerokość skrzydła na wysokości 6. lotki drugorzędowej.
    /// </summary>
    [Name("S6")]
    public string? S6 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("S6!")]
    public string? S6Confirm { get; set; }

    /// <summary>
    ///     rozpiętość skrzydeł.
    /// </summary>
    [Name("WS")]
    public string? WS { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("WS!")]
    public string? WSConfirm { get; set; }

    /// <summary>
    ///     skok.
    /// </summary>
    [Name("Tarsus")]
    public string? Tarsus { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Tarsus!")]
    public string? TarsusConfirm { get; set; }

    /// <summary>
    ///     przedramie.
    /// </summary>
    [Name("Ulna")]
    public string? Ulna { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Ulna!")]
    public string? UlnaConfirm { get; set; }

    /// <summary>
    ///     dziób z głową.
    /// </summary>
    [Name("THL")]
    public string? THL { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("THL!")]
    public string? THLConfirm { get; set; }

    /// <summary>
    ///     pomiar dzioba.
    /// </summary>
    [Name("Bill1")]
    public string? Bill1 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Bill1!")]
    public string? Bill1Confirm { get; set; }

    /// <summary>
    ///     rodzaj pmiaru dzioba Bill1.
    /// </summary>
    [Name("Bill1_dis")]
    public string? Bill1_dis { get; set; }

    /// <summary>
    ///     pomiar dzioba.
    /// </summary>
    [Name("Bill2")]
    public string? Bill2 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Bill2!")]
    public string? Bill2Confirm { get; set; }

    /// <summary>
    ///     rodzaj pomiaru dzioba Bill2.
    /// </summary>
    [Name("Bill2_dis")]
    public string? Bill2_dis { get; set; }

    /// <summary>
    ///     odległość między szczytem 1. i 6. sterówki.
    /// </summary>
    [Name("T1-T6")]
    public string? T1_T6 { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("T1-T6!")]
    public string? T1_T6Confirm { get; set; }

    /// <summary>
    ///     odległość między szczytem 6. i najdłuższej sterówki.
    /// </summary>
    [Name("T6-TL")]
    public string? T6_TL { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("T6-TL!")]
    public string? T6_TLConfirm { get; set; }

    /// <summary>
    ///     ogon mierzony w amerykański sposób.
    /// </summary>
    [Name("TailA")]
    public string? TailA { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("TailA!")]
    public string? TailAConfirm { get; set; }

    /// <summary>
    ///     grubość skrzydła.
    /// </summary>
    [Name("WT")]
    public string? WT { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("WT!")]
    public string? WTConfirm { get; set; }

    /// <summary>
    ///     pazur.
    /// </summary>
    [Name("Claw")]
    public string? Claw { get; set; }

    /// <summary>
    ///     potwierdzenie pomiaru odstającego.
    /// </summary>
    [Name("Claw!")]
    public string? ClawConfirm { get; set; }

    /// <summary>
    ///     do której lotki emarginacja.
    /// </summary>
    [Name("Emarg")]
    public string? Emarg { get; set; }

    /// <summary>
    ///     notch - w mm.
    /// </summary>
    [Name("Notch_mm")]
    public string? Notch_mm { get; set; }

    /// <summary>
    ///     notch - do szczytu której pierwszorzędówki.
    /// </summary>
    [Name("Notch_tip")]
    public string? Notch_tip { get; set; }

    /// <summary>
    ///     zapis dotyczący pasożyta.
    /// </summary>
    [Name("Parasite")]
    public string? Parasite { get; set; }

    /// <summary>
    ///     opis jakiego pasożyta/badań dotyczy zapis w Parasite.
    /// </summary>
    [Name("Parasite_dis")]
    public string? Parasite_dis { get; set; }

    /// <summary>
    ///     skrócony opis pierzenia.
    /// </summary>
    [Name("Moult_short")]
    public string? Moult_short { get; set; }

    /// <summary>
    ///     liczba nieprzepierzonych dużych pokryw.
    /// </summary>
    [Name("N_unmoult_cov")]
    public string? N_unmoult_cov { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X1")]
    public string? X1 { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X2")]
    public string? X2 { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X3")]
    public string? X3 { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X4")]
    public string? X4 { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X5")]
    public string? X5 { get; set; }

    /// <summary>
    ///     nierozpoznany zapis z specjali.
    /// </summary>
    [Name("X6")]
    public string? X6 { get; set; }

    /// <summary>
    ///     rozpoznany zapis z uwag - badania czasowe.
    /// </summary>
    [Name("Z1")]
    public string? Z1 { get; set; }

    /// <summary>
    ///     opis zawartości Z1.
    /// </summary>
    [Name("Z1_dis")]
    public string? Z1_dis { get; set; }

    /// <summary>
    ///     rozpoznany zapis z uwag - badania czasowe.
    /// </summary>
    [Name("Z2")]
    public string? Z2 { get; set; }

    /// <summary>
    ///     opis zawartości Z2.
    /// </summary>
    [Name("Z2_dis")]
    public string? Z2_dis { get; set; }

    /// <summary>
    ///     uwagi.
    /// </summary>
    [Name("Notes")]
    public string? Notes { get; set; }

    /// <summary>
    ///     logiczne- rekord zweryfikowany.Po kliknięciu rekord transformowany jest do DB2 i pozostałych baz.
    /// </summary>
    [Name("VerifiedPole")]
    public string? VerifiedPole { get; set; }

    /// <summary>
    ///     Błąd w schemacie - przeniesione wartości dla ignorowanych pól.
    /// </summary>
    [Name("SchemeError")]
    public string? SchemeError { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 1 LS")]
    public string? Primaries1LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 2 LS")]
    public string? Primaries2LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 3 LS")]
    public string? Primaries3LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 4 LS")]
    public string? Primaries4LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 5 LS")]
    public string? Primaries5LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 6 LS")]
    public string? Primaries6LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 7 LS")]
    public string? Primaries7LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 8 LS")]
    public string? Primaries8LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 9 LS")]
    public string? Primaries9LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 10 LS")]
    public string? Primaries10LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 11 LS")]
    public string? Primaries11LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 12 LS")]
    public string? Primaries12LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 1 LS")]
    public string? Secondaries1LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 2 LS")]
    public string? Secondaries2LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 3 LS")]
    public string? Secondaries3LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 4 LS")]
    public string? Secondaries4LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 5 LS")]
    public string? Secondaries5LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 6 LS")]
    public string? Secondaries6LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 7 LS")]
    public string? Secondaries7LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 8 LS")]
    public string? Secondaries8LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 9 LS")]
    public string? Secondaries9LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 10 LS")]
    public string? Secondaries10LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 11 LS")]
    public string? Secondaries11LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 12 LS")]
    public string? Secondaries12LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 13 LS")]
    public string? Secondaries13LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 14 LS")]
    public string? Secondaries14LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 15 LS")]
    public string? Secondaries15LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 16 LS")]
    public string? Secondaries16LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 17 LS")]
    public string? Secondaries17LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 18 LS")]
    public string? Secondaries18LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 19 LS")]
    public string? Secondaries19LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 20 LS")]
    public string? Secondaries20LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 21 LS")]
    public string? Secondaries21LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 22 LS")]
    public string? Secondaries22LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 23 LS")]
    public string? Secondaries23LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 24 LS")]
    public string? Secondaries24LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 25 LS")]
    public string? Secondaries25LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 26 LS")]
    public string? Secondaries26LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 27 LS")]
    public string? Secondaries27LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 28 LS")]
    public string? Secondaries28LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 29 LS")]
    public string? Secondaries29LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 30 LS")]
    public string? Secondaries30LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 31 LS")]
    public string? Secondaries31LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 32 LS")]
    public string? Secondaries32LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 33 LS")]
    public string? Secondaries33LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 34 LS")]
    public string? Secondaries34LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 35 LS")]
    public string? Secondaries35LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 36 LS")]
    public string? Secondaries36LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 37 LS")]
    public string? Secondaries37LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 1 LS")]
    public string? Tertials1LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 2 LS")]
    public string? Tertials2LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 3 LS")]
    public string? Tertials3LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 1 LS")]
    public string? TailF1LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 2 LS")]
    public string? TailF2LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 3 LS")]
    public string? TailF3LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 4 LS")]
    public string? TailF4LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 5 LS")]
    public string? TailF5LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 6 LS")]
    public string? TailF6LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 7 LS")]
    public string? TailF7LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 8 LS")]
    public string? TailF8LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 9 LS")]
    public string? TailF9LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 10 LS")]
    public string? TailF10LS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 1 RS")]
    public string? Primaries1RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 2 RS")]
    public string? Primaries2RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 3 RS")]
    public string? Primaries3RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 4 RS")]
    public string? Primaries4RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 5 RS")]
    public string? Primaries5RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 6 RS")]
    public string? Primaries6RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 7 RS")]
    public string? Primaries7RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 8 RS")]
    public string? Primaries8RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 9 RS")]
    public string? Primaries9RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 10 RS")]
    public string? Primaries10RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 11 RS")]
    public string? Primaries11RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Primaries 12 RS")]
    public string? Primaries12RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 1 RS")]
    public string? Secondaries1RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 2 RS")]
    public string? Secondaries2RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 3 RS")]
    public string? Secondaries3RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 4 RS")]
    public string? Secondaries4RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 5 RS")]
    public string? Secondaries5RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 6 RS")]
    public string? Secondaries6RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 7 RS")]
    public string? Secondaries7RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 8 RS")]
    public string? Secondaries8RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 9 RS")]
    public string? Secondaries9RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 10 RS")]
    public string? Secondaries10RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 11 RS")]
    public string? Secondaries11RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 12 RS")]
    public string? Secondaries12RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 13 RS")]
    public string? Secondaries13RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 14 RS")]
    public string? Secondaries14RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 15 RS")]
    public string? Secondaries15RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 16 RS")]
    public string? Secondaries16RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 17 RS")]
    public string? Secondaries17RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 18 RS")]
    public string? Secondaries18RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 19 RS")]
    public string? Secondaries19RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 20 RS")]
    public string? Secondaries20RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 21 RS")]
    public string? Secondaries21RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 22 RS")]
    public string? Secondaries22RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 23 RS")]
    public string? Secondaries23RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 24 RS")]
    public string? Secondaries24RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 25 RS")]
    public string? Secondaries25RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 26 RS")]
    public string? Secondaries26RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 27 RS")]
    public string? Secondaries27RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 28 RS")]
    public string? Secondaries28RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 29 RS")]
    public string? Secondaries29RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 30 RS")]
    public string? Secondaries30RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 31 RS")]
    public string? Secondaries31RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 32 RS")]
    public string? Secondaries32RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 33 RS")]
    public string? Secondaries33RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 34 RS")]
    public string? Secondaries34RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 35 RS")]
    public string? Secondaries35RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 36 RS")]
    public string? Secondaries36RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Secondaries 37 RS")]
    public string? Secondaries37RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 1 RS")]
    public string? Tertials1RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 2 RS")]
    public string? Tertials2RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tertials 3 RS")]
    public string? Tertials3RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 1 RS")]
    public string? TailF1RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 2 RS")]
    public string? TailF2RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 3 RS")]
    public string? TailF3RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 4 RS")]
    public string? TailF4RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 5 RS")]
    public string? TailF5RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 6 RS")]
    public string? TailF6RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 7 RS")]
    public string? TailF7RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 8 RS")]
    public string? TailF8RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 9 RS")]
    public string? TailF9RS { get; set; }

    /// <summary>
    ///     Stadium pierzenia danego pióra.
    /// </summary>
    [Name("Tail f. 10 RS")]
    public string? TailF10RS { get; set; }
}