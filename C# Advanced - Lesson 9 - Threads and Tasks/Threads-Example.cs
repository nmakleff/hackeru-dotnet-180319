using System;
using System.Collections;
using System.Threading;

namespace ThreadingExample
{
    class Program
    {
        private static ArrayList _array = new ArrayList();
        private static Mutex _mutex = new Mutex();
        private static Thread t2 = new Thread();

        public static void Job()
        {
            for (int i = 0; i < 100000; i++)
            {
                _mutex.WaitOne();
                _array.Add(i);
                if (i % 15 == 0)
                {
                    _array.RemoveAt(_array.Count - 1);
                }
                _mutex.ReleaseMutex();
            }

        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Job));

            t.Start();

            for (int i = 0; i < 100000; i++)
            {
                _mutex.WaitOne();
                _array.Add(i);
                if (i % 15 == 0)
                {
                    _array.RemoveAt(_array.Count - 1);
                }
                _mutex.ReleaseMutex();
            }

            t.Join();
            Console.WriteLine("I am here");
        }
    }
}



