using System.ComponentModel.DataAnnotations;

namespace QuickSurvey.Data.Uebung3;

public class Uebung3Estimates
{
    [Required(ErrorMessage = "Eingabe fehlt für Österreich")]
    public TShirtSize? Oesterreich { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Deutschland")]
    public TShirtSize? Deutschland { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Frankreich")]
    public TShirtSize? Frankreich { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Lichtenstein")]
    public TShirtSize? Liechtenstein { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Italien")]
    public TShirtSize? Italien { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Russland")]
    public TShirtSize? Russland { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für England")]
    public TShirtSize? England { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Malta")]
    public TShirtSize? Malta { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Griechenland")]
    public TShirtSize? Griechenland { get; set; }

    [Required(ErrorMessage = "Eingabe fehlt für Lettland")]
    public TShirtSize? Lettland { get; set; }
}