using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    internal class FileReadHandling
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("D:\\Collections\\Collections\\" +
                    "collection-csharp-practice\\gcr-codebase\\exceptions\\data.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }

    }
}

   