namespace QuickSurvey.Data.Uebung2;

public class Uebung2OnePertEstimateByUser
{
    public Uebung2OnePertEstimateByUser()
    {
    }

    public Uebung2OnePertEstimateByUser(string userId, PertEstimate estimate)
    {
        UserId = userId;
        Estimate = estimate;
    }

    public string UserId { get; set; }

    public PertEstimate Estimate { get; set; } = new();
}