using System.Collections.Concurrent;
using QuickSurvey.Data.Uebung1;
using QuickSurvey.Data.Uebung2;
using QuickSurvey.Data.Uebung3;

namespace QuickSurvey.Data;

internal static class ResponseStore
{
    private static ConcurrentDictionary<string, Uebung1Estimates> UserEstimatesUebung1 = new();
    private static ConcurrentDictionary<string, Uebung2Estimates> UserEstimatesUebung2 = new();
    private static ConcurrentDictionary<string, Uebung3Estimates> UserEstimatesUebung3 = new();

    public static void SetEstimate(string userId, Uebung1Estimates estimates)
    {
        UserEstimatesUebung1[userId] = estimates;
    }

    public static void SetEstimate(string userId, Uebung2Estimates estimates)
    {
        UserEstimatesUebung2[userId] = estimates;
    }

    public static void SetEstimate(string userId, Uebung3Estimates estimates)
    {
        UserEstimatesUebung3[userId] = estimates;
    }

    public static IEnumerable<Uebung1EstimatesByUser> GetAllUebung1()
    {
        return UserEstimatesUebung1.Select(userEstimate => new Uebung1EstimatesByUser()
            {
                UserId = userEstimate.Key,
                ToBerlin = userEstimate.Value.ToBerlin,
                ToMadrid = userEstimate.Value.ToMadrid,
                ToRom = userEstimate.Value.ToRom,
                ToStockholm = userEstimate.Value.ToStockholm
            });
    }

    public static IEnumerable<Uebung2EstimatesByUser> GetAllUebung2()
    {
        return UserEstimatesUebung2.Select(userEstimate => new Uebung2EstimatesByUser()
            {
                UserId = userEstimate.Key,
                ToAthen = userEstimate.Value.ToAthen,
                ToLissabon = userEstimate.Value.ToLissabon,
                ToOslo = userEstimate.Value.ToOslo,
                ToParis = userEstimate.Value.ToParis
        });
    }

    public static IEnumerable<Uebung3EstimatesByUser> GetAllUebung3()
    {
        return UserEstimatesUebung3.Select(userEstimate => new Uebung3EstimatesByUser()
        {
            UserId = userEstimate.Key,
            Deutschland = userEstimate.Value.Deutschland,
            England = userEstimate.Value.England,
            Frankreich = userEstimate.Value.Frankreich,
            Griechenland = userEstimate.Value.Griechenland,
            Italien = userEstimate.Value.Italien,
            Lettland = userEstimate.Value.Lettland,
            Liechtenstein = userEstimate.Value.Liechtenstein,
            Malta = userEstimate.Value.Malta,
            Oesterreich = userEstimate.Value.Oesterreich,
            Russland = userEstimate.Value.Russland,
        });
    }

    public static Uebung1Estimates GetEstimateUebung1(string userId)
    {
        Uebung1Estimates returnValue;

        if (UserEstimatesUebung1.TryGetValue(userId, out returnValue))
        {
            return returnValue;
        }

        return new Uebung1Estimates();
    }

    public static Uebung2Estimates GetEstimateUebung2(string userId)
    {
        Uebung2Estimates returnValue;

        if (UserEstimatesUebung2.TryGetValue(userId, out returnValue))
        {
            return returnValue;
        }

        return new Uebung2Estimates();
    }

    public static Uebung3Estimates GetEstimateUebung3(string userId)
    {
        Uebung3Estimates returnValue;

        if (UserEstimatesUebung3.TryGetValue(userId, out returnValue))
        {
            return returnValue;
        }

        return new Uebung3Estimates();
    }

    public static bool EstimateUebung1Submitted(string userId)
    {
        return UserEstimatesUebung1.ContainsKey(userId);
    }

    public static bool EstimateUebung2Submitted(string userId)
    {
        return UserEstimatesUebung2.ContainsKey(userId);
    }

    public static bool EstimateUebung3Submitted(string userId)
    {
        return UserEstimatesUebung3.ContainsKey(userId);
    }

    public static void ResetUebung1()
    {
        UserEstimatesUebung1.Clear();
    }

    public static void ResetUebung2()
    {
        UserEstimatesUebung2.Clear();
    }

    public static void ResetUebung3()
    {
        UserEstimatesUebung3.Clear();
    }
}