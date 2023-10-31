using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PayPalHelper.Enum;

namespace PayPalHelper.Model;

internal class PpTransaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Kasse Relevance { get; set; }

    //PayPal Data
    public string? Datum { get; set; }
    public DateTime? Uhrzeit { get; set; }
    public string? Zeitzone { get; set; }
    public string? Name { get; set; }
    public string? Typ { get; set; }
    public string? Status { get; set; }
    public string? Währung { get; set; }
    public decimal Brutto { get; set; }
    public string? Gebühr { get; set; }
    public decimal? Netto { get; set; }
    public string? AbsenderEMailAdresse { get; set; }
    public string? EmpfängerEMailAdresse { get; set; }
    public string Transaktionscode { get; set; }
    public string? Lieferadresse { get; set; }
    public string? AdressStatus { get; set; }
    public string? Artikelbezeichnung { get; set; }
    public string? Artikelnummer { get; set; }
    public string? VersandUndBearbeitungsgebühr { get; set; }
    public string? Versicherungsbetrag { get; set; }
    public string? Umsatzsteuer { get; set; }
    public string? Option1Name { get; set; }
    public string? Option1Wert { get; set; }
    public string? Option2Name { get; set; }
    public string? Option2Wert { get; set; }
    public string? ZugehörigerTransaktionscode { get; set; }
    public string? Rechnungsnummer { get; set; }
    public string? Zollnummer { get; set; }
    public decimal? Anzahl { get; set; }
    public string? Empfangsnummer { get; set; }
    public string? Guthaben { get; set; }
    public string? Adresszeile1 { get; set; }
    public string? Adresszusatz { get; set; }
    public string? Ort { get; set; }
    public string? Bundesland { get; set; }
    public string? PLZ { get; set; }
    public string? Land { get; set; }
    public string? Telefon { get; set; }
    public string? Betreff { get; set; }
    public string? Hinweis { get; set; }
    public string? Ländervorwahl { get; set; }
    public string? AuswirkungaufGuthaben { get; set; }

    public PpTransaction()
    {
    }

    public PpTransaction(string? datum, string? uhrzeit, string? zeitzone, string? name, string? typ, string? status, string? währung, string? brutto, string? gebühr, string? netto, string? absenderEMailAdresse, string? empfängerEMailAdresse, string? transaktionscode, string? lieferadresse, string? adressStatus, string? artikelbezeichnung, string? artikelnummer, string? versandUndBearbeitungsgebühr, string? versicherungsbetrag, string? umsatzsteuer, string? option1Name, string? option1Wert, string? option2Name, string? option2Wert, string? zugehörigerTransaktionscode, string? rechnungsnummer, string? zollnummer, string? anzahl, string? empfangsnummer, string? guthaben, string? adresszeile1, string? adresszusatz, string? ort, string? bundesland, string? plz, string? land, string? telefon, string? betreff, string? hinweis, string? ländervorwahl, string? auswirkungaufGuthaben)
    {
        Datum = datum;
        Uhrzeit = uhrzeit != null ? DateTime.Parse(uhrzeit) : null;
        Zeitzone = zeitzone;
        Name = name;
        Typ = typ;
        Status = status;
        Währung = währung;
        Brutto = ToDecimalValue(brutto) ?? 0;
        Gebühr = gebühr;
        Netto = ToDecimalValue(netto);
        AbsenderEMailAdresse = absenderEMailAdresse;
        EmpfängerEMailAdresse = empfängerEMailAdresse;
        Transaktionscode = transaktionscode;
        Lieferadresse = lieferadresse;
        AdressStatus = adressStatus;
        Artikelbezeichnung = artikelbezeichnung;
        Artikelnummer = artikelnummer;
        VersandUndBearbeitungsgebühr = versandUndBearbeitungsgebühr;
        Versicherungsbetrag = versicherungsbetrag;
        Umsatzsteuer = umsatzsteuer;
        Option1Name = option1Name;
        Option1Wert = option1Wert;
        Option2Name = option2Name;
        Option2Wert = option2Wert;
        ZugehörigerTransaktionscode = zugehörigerTransaktionscode;
        Rechnungsnummer = rechnungsnummer;
        Zollnummer = zollnummer;
        Anzahl = ToDecimalValue(anzahl);
        Empfangsnummer = empfangsnummer;
        Guthaben = guthaben;
        Adresszeile1 = adresszeile1;
        Adresszusatz = adresszusatz;
        Ort = ort;
        Bundesland = bundesland;
        PLZ = plz;
        Land = land;
        Telefon = telefon;
        Betreff = betreff;
        Hinweis = hinweis;
        Ländervorwahl = ländervorwahl;
        AuswirkungaufGuthaben = auswirkungaufGuthaben;
    }

    public static PpTransaction Create(List<string> l)
    {
        int i = 0;
        return new PpTransaction(G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), G(l, i++), l[i++]);
    }

    private static string? G(List<string> list, int num)
    {
        var value = list[num].Trim();
        return string.IsNullOrWhiteSpace(value) ? null : value;
    }


    private static decimal? ToDecimalValue(string? text)
    {
        if (text == null)
            return null;

        return decimal.TryParse(text, out decimal value) ? value : null;
    }
}