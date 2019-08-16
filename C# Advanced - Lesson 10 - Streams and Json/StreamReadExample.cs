using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpStreamsTutorial
{
    class StreamReadDemo
    {
        public static void Main(string[] args)
        {
            String path = @"C:\temp\MyTest.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("File " + path + " does not exists!");
                return;
            }

            // Create Stream object via constructor of FileStream
            // FileMode.Open: Open file to read.
            using (Stream readingStream = new FileStream(path, FileMode.Open))
            {
                byte[] temp = new byte[10];
                
                int len = 0;

                // Read on stream and asign to temporary array.
                // (Asign to elements of array from index 0, and max 'temp.Length' elements)
                // Returns the number of bytes read.
                while ((len = readingStream.Read(temp, 0, temp.Length)) > 0)
                {
                    // Converts to string.
                    // ('len' elements from index 0).
                    String s = Encoding.UTF8.GetString(temp, 0, len);
                    Console.WriteLine(s);
                }
            }

            Console.ReadLine();
        }
    }

}