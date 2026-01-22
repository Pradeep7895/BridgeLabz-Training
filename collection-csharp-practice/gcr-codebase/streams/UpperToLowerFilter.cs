using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class UpperToLowerFilter
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";

            string sourceFile = basePath + "input.txt";
            string destinationFile = basePath + "output.txt";

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                // Open file streams with buffering
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (BufferedStream bsRead = new BufferedStream(fsRead))
                using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))

                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File processed successfully. Uppercase converted to lowercase.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error occurred:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error:");
                Console.WriteLine(ex.Message);
            }
        }

    }
}

   