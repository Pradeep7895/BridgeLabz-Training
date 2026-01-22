using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class FileCopyBufferedStreams
    {
        const int BUFFER_SIZE = 4096; // 4 KB

        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";

            string sourceFile = basePath + "largefile.dat";
            string unbufferedDest = basePath + "copy_unbuffered.dat";
            string bufferedDest = basePath + "copy_buffered.dat";


            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            CopyWithoutBuffer(sourceFile, unbufferedDest);
            CopyWithBuffer(sourceFile, bufferedDest);
        }

        //Unbuffered File Copy
        static void CopyWithoutBuffer(string source, string destination)
        {
            byte[] buffer = new byte[BUFFER_SIZE];
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {sw.ElapsedMilliseconds} ms");
        }

        // Buffered File Copy
        static void CopyWithBuffer(string source, string destination)
        {
            byte[] buffer = new byte[BUFFER_SIZE];
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            {
                int bytesRead;
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine($"Buffered Copy Time: {sw.ElapsedMilliseconds} ms");
        }

    }
}

