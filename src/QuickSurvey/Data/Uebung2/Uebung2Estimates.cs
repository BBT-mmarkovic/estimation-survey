using System.ComponentModel.DataAnnotations;

namespace QuickSurvey.Data.Uebung2;

public class Uebung2Estimates
{
    [Required(ErrorMessage = "Eingabe fehlt für Paris")]
    [InPertRange(ErrorMessage = "Ungülite PERT Werte für Paris")]
    public PertEstimate ToParis { get; set; } = new();

    [Required(ErrorMessage = "Eingabe fehlt für Oslo")]
    [InPertRange(ErrorMessage = "Ungülite PERT Werte für Oslo")]
    public PertEstimate ToOslo { get; set; } = new();

    [Required(ErrorMessage = "Eingabe fehlt für Lissabon")]
    [InPertRange(ErrorMessage = "Ungülite PERT Werte für Lissabon")]
    public PertEstimate ToLissabon { get; set; } = new();

    [Required(ErrorMessage = "Eingabe fehlt für Athen")]
    [InPertRange(ErrorMessage = "Ungülite PERT Werte für Athen")]
    public PertEstimate ToAthen { get; set; } = new();
}