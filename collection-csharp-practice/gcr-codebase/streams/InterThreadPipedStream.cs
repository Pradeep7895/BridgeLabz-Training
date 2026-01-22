using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class InterThreadPipedStream
    {
        static void Main()
        {
            try
            {
                // Create pipe server for writing
                using (AnonymousPipeServerStream pipeServer =
                       new AnonymousPipeServerStream(PipeDirection.Out,
                                                      HandleInheritability.Inheritable))
                {
                    // Create pipe client for reading
                    using (AnonymousPipeClientStream pipeClient =
                           new AnonymousPipeClientStream(PipeDirection.In,
                                                         pipeServer.GetClientHandleAsString()))
                    {
                        Thread writerThread = new Thread(() => Writer(pipeServer));
                        Thread readerThread = new Thread(() => Reader(pipeClient));

                        writerThread.Start();
                        readerThread.Start();

                        writerThread.Join();
                        readerThread.Join();
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

        // Writer Thread
        static void Writer(AnonymousPipeServerStream pipe)
        {
            try
            {
                StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8);
                writer.AutoFlush = true;

                writer.WriteLine("Hello from Writer Thread");
                writer.WriteLine("This data is sent through PipeStream");
                writer.WriteLine("END");

                // ❗ DO NOT close the pipe here
                writer.Flush();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Writer Error: " + ex.Message);
            }
        }


        // Reader Thread
        static void Reader(AnonymousPipeClientStream pipe)
        {
            try
            {
                using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "END")
                            break;

                        Console.WriteLine("Reader received: " + line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reader Error: " + ex.Message);
            }
        }

    }
}


   