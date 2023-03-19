using CsvHelper.Configuration.Attributes;

namespace RegulusLibrary.Services.Sources.DataStructures;

public record NewDbBirdRecord
{
    [Name("IDR_Podab")] public double? IDR_Podab { get; set; }
    [Name("IdBaza")] public double? IdBaza { get; set; }
    [Name("IdSezon")] public double? IdSezon { get; set; }
    [Name("IdZesz")] public double? IdZesz { get; set; }
    [Name("Ztyp")] public string? Ztyp { get; set; }
    [Name("Znr")] public double? Znr { get; set; }
    [Name("Zpage")] public double? Zpage { get; set; }
    [Name("Zrow")] public double? Zrow { get; set; }
    [Name("CoStaSit")] public string? CoStaSit { get; set; }
    [Name("Year")] public double? Year { get; set; }
    [Name("Seas")] public string? Seas { get; set; }
    [Name("Date")] public string? Date { get; set; }
    [Name("Pole13")] public string? Pole13 { get; set; }
    [Name("Date2")] public string? Date2 { get; set; }
    [Name("MD")] public double? MD { get; set; }
    [Name("Hour")] public double? Hour { get; set; }
    [Name("Pole17")] public string? Pole17 { get; set; }
    [Name("Ring Type")] public string? RingType { get; set; }
    [Name("Ring Ser")] public string? RingSer { get; set; }
    [Name("Ring No")] public string? RingNo { get; set; }
    [Name("Ring")] public string? Ring { get; set; }
    [Name("Pole22")] public string? Pole22 { get; set; }
    [Name("Stat")] public string? Stat { get; set; }
    [Name("Net")] public string? Net { get; set; }
    [Name("Species Code")] public string? SpeciesCode { get; set; }
    [Name("English Name")] public string? EnglishName { get; set; }
    [Name("Latin Name")] public string? LatinName { get; set; }
    [Name("AddInfo")] public string? AddInfo { get; set; }
    [Name("Sex")] public string? Sex { get; set; }
    [Name("Pole30")] public string? Pole30 { get; set; }
    [Name("'?'")] public string? QuestionMark { get; set; }
    [Name("Euring")] public string? Euring { get; set; }
    [Name("Age")] public string? Age { get; set; }
    [Name("Pole34")] public string? Pole34 { get; set; }
    [Name("Pole35")] public string? Pole35 { get; set; }
    [Name("WIEK")] public string? WIEK { get; set; }
    [Name("SZATA")] public string? SZATA { get; set; }
    [Name("Fat")] public double? Fat { get; set; }
    [Name("Pole39")] public string? Pole39 { get; set; }
    [Name("Tip")] public string? Tip { get; set; }
    [Name("Pole41")] public string? Pole41 { get; set; }
    [Name("M1")] public string? M1 { get; set; }
    [Name("Pole43")] public string? Pole43 { get; set; }
    [Name("M2")] public string? M2 { get; set; }
    [Name("Pole45")] public string? Pole45 { get; set; }
    [Name("M3")] public string? M3 { get; set; }
    [Name("Pole47")] public string? Pole47 { get; set; }
    [Name("M4")] public string? M4 { get; set; }
    [Name("Pole49")] public string? Pole49 { get; set; }
    [Name("M5")] public string? M5 { get; set; }
    [Name("Pole51")] public string? Pole51 { get; set; }
    [Name("M6")] public string? M6 { get; set; }
    [Name("Pole53")] public string? Pole53 { get; set; }
    [Name("D2")] public double? D2 { get; set; }
    [Name("Pole55")] public string? Pole55 { get; set; }
    [Name("D3")] public double? D3 { get; set; }
    [Name("Pole57")] public string? Pole57 { get; set; }
    [Name("D4")] public double? D4 { get; set; }
    [Name("Pole59")] public string? Pole59 { get; set; }
    [Name("D5")] public double? D5 { get; set; }
    [Name("Pole61")] public string? Pole61 { get; set; }
    [Name("D6")] public double? D6 { get; set; }
    [Name("Pole63")] public string? Pole63 { get; set; }
    [Name("D7")] public double? D7 { get; set; }
    [Name("Pole65")] public string? Pole65 { get; set; }
    [Name("D8")] public double? D8 { get; set; }
    [Name("Pole67")] public string? Pole67 { get; set; }
    [Name("Extra 1")] public string? Extra1 { get; set; }
    [Name("Pole69")] public string? Pole69 { get; set; }
    [Name("Extra 2")] public string? Extra2 { get; set; }
    [Name("Pole71")] public string? Pole71 { get; set; }
    [Name("Wing")] public double? Wing { get; set; }
    [Name("Pole73")] public string? Pole73 { get; set; }
    [Name("Tail")] public double? Tail { get; set; }
    [Name("Pole75")] public string? Pole75 { get; set; }
    [Name("Weight")] public double? Weight { get; set; }
    [Name("Pole77")] public string? Pole77 { get; set; }
    [Name("DW")] public string? DW { get; set; }
    [Name("Notch/Dziób")] public string? NotchDziób { get; set; }
    [Name("Pole80")] public string? Pole80 { get; set; }
    [Name("LocN/Pazur/Kipp")] public string? LocN_Pazur_Kipp { get; set; }
    [Name("Pole82")] public string? Pole82 { get; set; }
    [Name("P1-P2")] public string? P1P2 { get; set; }
    [Name("Pole84")] public string? Pole84 { get; set; }
    [Name("P1-PC")] public string? P1PC { get; set; }
    [Name("Pole86")] public string? Pole86 { get; set; }
    [Name("Special 5")] public string? Special5 { get; set; }
    [Name("Pole88")] public string? Pole88 { get; set; }
    [Name("Special 6")] public string? Special6 { get; set; }
    [Name("Pole90")] public string? Pole90 { get; set; }
    [Name("Special 7")] public string? Special7 { get; set; }
    [Name("Pole92")] public string? Pole92 { get; set; }
    [Name("Special 8")] public string? Special8 { get; set; }
    [Name("Pole94")] public string? Pole94 { get; set; }
    [Name("Comments")] public string? Comments { get; set; }
    [Name("Notes_T")] public string? Notes_T { get; set; }
    [Name("CodeR")] public string? CodeR { get; set; }
    [Name("KOND")] public string? KOND { get; set; }
    [Name("OKOL")] public string? OKOL { get; set; }
    [Name("CHWYT")] public string? CHWYT { get; set; }
    [Name("WABIK")] public string? WABIK { get; set; }
    [Name("MANIP")] public string? MANIP { get; set; }
    [Name("PRZEM")] public string? PRZEM { get; set; }
    [Name("NAZWOB2")] public string? NAZWOB2 { get; set; }
    [Name("BŁĄD")] public string? BŁĄD { get; set; }
    [Name("Godz")] public DateTime? Godz { get; set; }
    [Name("DT")] public DateTime? DT { get; set; }
    [Name("OB2")] public string? OB2 { get; set; }
    [Name("TYP2")] public string? TYP2 { get; set; }
    [Name("CTR2")] public string? CTR2 { get; set; }
    [Name("KRZ2")] public string? KRZ2 { get; set; }
    [Name("NROB2")] public string? NROB2 { get; set; }
    [Name("Name")] public string? Name { get; set; }
    [Name("OB1")] public string? OB1 { get; set; }
    [Name("TYPE1")] public string? TYPE1 { get; set; }
    [Name("CTR1")] public string? CTR1 { get; set; }
    [Name("DD")] public string? DD { get; set; }
    [Name("STATUS")] public string? STATUS { get; set; }
    [Name("Index l'")] public int? Index_l_prim { get; set; }
    [Name("Index e'")] public int? Index_e_prim { get; set; }
    [Name("Index L")] public int? IndexL { get; set; }
    [Name("Index E")] public int? IndexE { get; set; }
    [Name("Index H")] public int? IndexH { get; set; }
    [Name("FotoB")] public string? FotoB { get; set; }
    [Name("FotoW")] public string? FotoW { get; set; }
    [Name("D9")] public int? D9 { get; set; }
    [Name("D10")] public int? D10 { get; set; }
}