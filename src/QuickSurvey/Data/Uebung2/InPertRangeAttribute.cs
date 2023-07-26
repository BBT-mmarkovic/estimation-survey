using System.ComponentModel.DataAnnotations;

namespace QuickSurvey.Data.Uebung2;

[AttributeUsage(AttributeTargets.Property |
                AttributeTargets.Field, AllowMultiple = false)]
public sealed class InPertRangeAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value != null && value.GetType() == typeof(PertEstimate))
        {
            var pert = (PertEstimate)value;
            return pert.BestCase >= 50 
                && pert.BestCase < pert.LikelyCase
                && pert.LikelyCase < pert.WorstCase
                && pert.WorstCase <= 10000;
        }

        return true;
    }
}