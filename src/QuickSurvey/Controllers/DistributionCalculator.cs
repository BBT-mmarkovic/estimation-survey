using QuickSurvey.Data;
using QuickSurvey.Data.Uebung1;

namespace QuickSurvey.Controllers;

public static class DistributionCalculator
{
    public static IEnumerable<DistributionItem> GenerateNormalDistributionForUebung1Berlin()
    {
        var elements = ResponseStore.GetAllUebung1().ToList();
        if (elements.Count == 0)
        {
            return Array.Empty<DistributionItem>();
        }

        var diffs = elements.Select(x => x.DiffToBerlin).ToList();

        if (diffs.Distinct().Count() == 1)
        {
            return new DistributionItem[]
            {
                new(diffs[0].ToString(), diffs.Count)
            };
        }

        return GetNormalDistributionFor(diffs);
    }

    public static IEnumerable<DistributionItem> GenerateNormalDistributionForUebung1Madrid()
    {
        var elements = ResponseStore.GetAllUebung1().ToList();
        if (elements.Count == 0)
        {
            return Array.Empty<DistributionItem>();
        }

        var diffs = elements.Select(x => x.DiffToMadrid).ToList();

        if (diffs.Distinct().Count() == 1)
        {
            return new DistributionItem[]
            {
                new(diffs[0].ToString(), diffs.Count)
            };
        }

        return GetNormalDistributionFor(diffs);
    }

    public static IEnumerable<DistributionItem> GenerateNormalDistributionForUebung1Rom()
    {
        var elements = ResponseStore.GetAllUebung1().ToList();
        if (elements.Count == 0)
        {
            return Array.Empty<DistributionItem>();
        }

        var diffs = elements.Select(x => x.DiffToRom).ToList();

        if (diffs.Distinct().Count() == 1)
        {
            return new DistributionItem[]
            {
                new(diffs[0].ToString(), diffs.Count)
            };
        }

        return GetNormalDistributionFor(diffs);
    }

    public static IEnumerable<DistributionItem> GenerateNormalDistributionForUebung1Stockholm()
    {
        var elements = ResponseStore.GetAllUebung1().ToList();
        if (elements.Count == 0)
        {
            return Array.Empty<DistributionItem>();
        }

        var diffs = elements.Select(x => x.DiffToStockholm).ToList();

        if (diffs.Distinct().Count() == 1)
        {
            return new DistributionItem[]
            {
                new(diffs[0].ToString(), diffs.Count)
            };
        }

        return GetNormalDistributionFor(diffs);
    }

    private static IEnumerable<DistributionItem> GetNormalDistributionFor(List<int> points)
    {
        var min = points.Min();
        var max = points.Max();
        var range = max - min;
        var numberOfSections = (int)Math.Round(Math.Sqrt(points.Count), 0);
        var rangePerSection = (int)Math.Round((decimal)range / numberOfSections, 0);

        var result = new List<DistributionItem>();

        for (int i = 0; i < numberOfSections; i++)
        {
            var sectionRange = min + i * rangePerSection;
            var nextSectionRange = min + (i + 1) * rangePerSection;
            // extend value range of the last section by 1
            var valueRangeNextSection = i + 1 == numberOfSections ? nextSectionRange + 1 : nextSectionRange;

            result.Add(new DistributionItem()
            {
                Gruppe = $"[{sectionRange}, {nextSectionRange})",
                AnzahlSchaetzungen = points.Count(x => sectionRange <= x && x < valueRangeNextSection),
            });
        }

        return result;
    }
}