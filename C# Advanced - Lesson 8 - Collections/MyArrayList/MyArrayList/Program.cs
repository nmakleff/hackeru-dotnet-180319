using System;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> testArray = new MyArrayList<int>();
            MyArrayList<string> testArrayStr = new MyArrayList<string>();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    testArray.Add(i);
                    testArrayStr.Add(i);
                }

                testArray.Insert(5, 100);

                for (int i = 0; i < testArray.Count; i++)
                {
                    Console.WriteLine(testArray.Get(i));
                }

                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
