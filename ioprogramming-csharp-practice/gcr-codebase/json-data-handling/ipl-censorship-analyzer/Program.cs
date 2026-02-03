using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("IPL Censorship Analyzer");

        JsonProcessor.ProcessJson(
            @"D:\Collections\Collections\ioprogramming-csharp-practice\gcr-codebase\json-data-handling\ipl-censorship-analyzer\ipl_input.json",
            "ipl_censored.json"
        );

        CsvProcessor.ProcessCsv(
            @"D:\Collections\Collections\ioprogramming-csharp-practice\gcr-codebase\json-data-handling\ipl-censorship-analyzer\ipl_input.csv",
            "ipl_censored.csv"
        );

        Console.WriteLine("Censorship completed successfully!");
    }
}
