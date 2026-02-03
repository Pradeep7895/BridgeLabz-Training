using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class JsonProcessor
{
    public static void ProcessJson(string inputPath, string outputPath)
    {
        string json = File.ReadAllText(inputPath);
        List<IplMatch> matches = JsonConvert.DeserializeObject<List<IplMatch>>(json);

        foreach (var match in matches)
        {
            // Mask team names
            string maskedTeam1 = MaskHelper.MaskTeamName(match.team1);
            string maskedTeam2 = MaskHelper.MaskTeamName(match.team2);

            match.team1 = maskedTeam1;
            match.team2 = maskedTeam2;
            match.winner = MaskHelper.MaskTeamName(match.winner);
            match.player_of_match = "REDACTED";

            // Mask score dictionary keys
            Dictionary<string, int> newScore = new Dictionary<string, int>();
            foreach (var entry in match.score)
            {
                newScore[
                    MaskHelper.MaskTeamName(entry.Key)
                ] = entry.Value;
            }

            match.score = newScore;
        }

        string censoredJson =
            JsonConvert.SerializeObject(matches, Formatting.Indented);

        File.WriteAllText(outputPath, censoredJson);
    }
}
