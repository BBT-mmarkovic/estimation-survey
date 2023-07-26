using System.ComponentModel.DataAnnotations;

namespace QuickSurvey.Data.Uebung1;

public class Uebung1Estimates
{
    [Required(ErrorMessage = "Eingabe fehlt für Berlin")]
    [Range(1, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km für Berlin eingeben.")]
    public int ToBerlin { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Stockholm")]
    [Range(1, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km für Stockholm eingeben.")]
    public int ToStockholm { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Madrid")]
    [Range(1, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km für Madrid eingeben.")]
    public int ToMadrid { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Rom")]
    [Range(1, 10000, ErrorMessage = "Bitte eine Schätzung zwischen 50 km und 10'000 km für Rom eingeben.")]
    public int ToRom { get; set; }
}