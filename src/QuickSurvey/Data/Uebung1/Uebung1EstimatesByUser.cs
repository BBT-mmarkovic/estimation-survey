namespace QuickSurvey.Data.Uebung1;

public class Uebung1EstimatesByUser : Uebung1Estimates
{
    public string UserId { get; set; }

    public int DiffToBerlin => this.ToBerlin - 700;
    public int DiffToMadrid=> this.ToMadrid - 1500;
    public int DiffToRom => this.ToRom - 650;
    public int DiffToStockholm => this.ToStockholm - 1200;
}