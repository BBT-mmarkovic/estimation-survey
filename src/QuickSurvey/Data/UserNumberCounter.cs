namespace QuickSurvey.Data;

internal static class UserNumberCounter
{
    private static int _number = 10;

    internal static int NextNumber()
    {
        return _number++;
    }
}