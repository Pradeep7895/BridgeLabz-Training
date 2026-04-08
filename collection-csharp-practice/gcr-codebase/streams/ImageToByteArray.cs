using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class ImageToByteArray
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            string sourceImage = basePath + "original.jpg";
            string destinationImage = basePath + "copy.jpg";

            try
            {
                // Check if source image exists
                if (!File.Exists(sourceImage))
                {
                    Console.WriteLine("Source image file does not exist.");
                    return;
                }

                // Step 1: Read image into byte array
                byte[] imageBytes = File.ReadAllBytes(sourceImage);

                // Step 2: Write byte array to new image using MemoryStream
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    File.WriteAllBytes(destinationImage, ms.ToArray());
                }

                // Step 3: Verify both files are identical
                bool isSame = CompareFiles(sourceImage, destinationImage);

                Console.WriteLine("Image conversion completed.");
                Console.WriteLine("Files identical: " + isSame);
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

        // Method to verify files are identical
        static bool CompareFiles(string file1, string file2)
        {
            byte[] file1Bytes = File.ReadAllBytes(file1);
            byte[] file2Bytes = File.ReadAllBytes(file2);

            if (file1Bytes.Length != file2Bytes.Length)
                return false;

            for (int i = 0; i < file1Bytes.Length; i++)
            {
                if (file1Bytes[i] != file2Bytes[i])
                    return false;
            }
            return true;
        }

    }
}

    