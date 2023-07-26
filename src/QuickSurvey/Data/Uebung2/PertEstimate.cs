using System.ComponentModel.DataAnnotations;

namespace QuickSurvey.Data.Uebung2;

public class PertEstimate
{
    [Required(ErrorMessage = "Eingabe fehlt")]
    [Range(50, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km eingeben.")]
    public int BestCase { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt")]
    [Range(50, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km eingeben.")]
    public int LikelyCase { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt")]
    [Range(50, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km eingeben.")]
    public int WorstCase { get; set; }

    public int Expected => (int)Math.Round((BestCase + 4 * LikelyCase + WorstCase) / 6m);

    public decimal StandardDeviation => Math.Round((WorstCase - BestCase) / 6m, 3);

    public double Variance => Math.Round(Math.Pow((double)StandardDeviation, 2), 3);

    public decimal ZScore => (decimal)(Math.Round((LikelyCase - Expected) / Math.Pow(Variance, 0.5), 3));
}