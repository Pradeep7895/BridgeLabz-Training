public static class MaskHelper
{
    public static string MaskTeamName(string team)
    {
        string[] parts = team.Split(' ');

        if (parts.Length == 1)
            return "***";

        if (parts.Length == 2)
            return parts[0] + " ***";

        // For 3 or more words
        return parts[0] + " *** " + parts[^1];
    }
}
