namespace QuickSurvey.Data.Uebung1;

public class DistributionItem
{
    public DistributionItem()
    {
    }

    public DistributionItem(string gruppe, int anzahlSchaetzungen)
    {
        Gruppe = gruppe;
        AnzahlSchaetzungen = anzahlSchaetzungen;
    }

    public string Gruppe { get; set; }

    public int AnzahlSchaetzungen { get; set; }
}