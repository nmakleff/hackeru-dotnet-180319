// C# program to illustrate the creation 
// of thread using static method 
using System;
using System.Threading;

public class ExThread
{

    // Static method for thread a 
    public static void TheWork()
    {
        for (int z = 0; z < 3; z++)
        {
            Console.WriteLine("The Work: " + z);
            Thread.Sleep(100);
        }
    }
}

// Driver Class 
public class Program
{

    // Main method 
    public static void Main(string[] args)
    {
        // Creating and initializing threads 
        Thread a = new Thread(ExThread.TheWork);
        a.Start();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Main: " + i);
            Thread.Sleep(100);
        }
        a.Join();
    }
}