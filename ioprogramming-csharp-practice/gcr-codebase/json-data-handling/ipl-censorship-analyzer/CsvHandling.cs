using System.IO;

public class CsvProcessor
{
    public static void ProcessCsv(string inputPath, string outputPath)
    {
        string[] lines = File.ReadAllLines(inputPath);

        using StreamWriter writer = new StreamWriter(outputPath);

        // Write header
        writer.WriteLine(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] cols = lines[i].Split(',');

            cols[1] = MaskHelper.MaskTeamName(cols[1]); // team1
            cols[2] = MaskHelper.MaskTeamName(cols[2]); // team2
            cols[5] = MaskHelper.MaskTeamName(cols[5]); // winner
            cols[6] = "REDACTED";                       // player_of_match

            writer.WriteLine(string.Join(",", cols));
        }
    }
}
