using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class ReadAndWriteFileHandling
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            string sourceFile = basePath + "Source.txt";
            string destinationFile = basePath + "destination.txt";

            try
            {
                // Check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                // Open source file for reading
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                // Create destination file for writing
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int byteData;

                    // Read byte-by-byte and write to destination file
                    while ((byteData = fsRead.ReadByte()) != -1)
                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                }

                Console.WriteLine("File copied successfully.");
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

