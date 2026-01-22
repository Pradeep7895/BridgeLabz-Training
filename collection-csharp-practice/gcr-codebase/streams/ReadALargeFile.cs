using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class ReadALargeFile
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            string filePath =basePath + "large_log_file.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Case-insensitive check for "error"
                        if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
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

   