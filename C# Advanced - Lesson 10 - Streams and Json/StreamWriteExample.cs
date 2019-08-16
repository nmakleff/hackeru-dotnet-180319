using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpStreamsTutorial
{
    class StreamWriteDemo
    {
        public static void Main(string[] args)
        {
            string path = @"C:\temp\MyTest.txt";

            // Create directory.
            Directory.CreateDirectory(@"C:\temp");

            // Create Stream object via Constructor of FileStream.
            // FileMode.Create: Create file, if it already exists, it will be overwritten.
            Stream writingStream = new FileStream(path, FileMode.Create);

            try
            {
                // This array corresponds to: {'H','e','l','l','o',' ','W','o','r','l','d'}.
                string Txt = "Hello World!";

                byte[] bytes = Encoding.ASCII.ToBytes(Txt);

                if (writingStream.CanWrite)
                {
                    writingStream.Write(bytes, 0, bytes.Length);

                    // Write a byte (33 = '!')
                    writingStream.WriteByte(33);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            finally
            {
                // Close Stream, free resources.
                writingStream.Close();
            }
            Console.ReadLine();

        }

    }
}