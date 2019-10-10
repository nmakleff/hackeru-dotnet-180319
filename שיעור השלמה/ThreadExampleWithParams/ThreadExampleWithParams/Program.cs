using System;
using System.Threading;
class Program
{
    static void Main()
    {
        // Create a thread with a ParemeterizedThreadStart  
        Print p = new Print();
        Thread workerThread = new Thread(p.PrintJob);
        // Start thread with a parameter  
        workerThread.Start("Some data");

        // Pass a class object to a worker thread  
        Person mahesh = new Person("Mahesh Chand", 40, "Male");
        Thread workerThread2 = new Thread(p.PrintPerson);
        workerThread2.Start(mahesh);

        // Main thread  
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Main thread: {i}");
            Thread.Sleep(200);
        }

        Console.ReadKey();
    }
}

public class Print
{
    public void PrintJob(object data)
    {
        Console.WriteLine("Background PrintJob started.");
        Thread.Sleep(1000);
        Console.WriteLine("PrintJob still printing...");
        Console.WriteLine($"Data: {data}");
        Thread.Sleep(1000);
        Console.WriteLine("PrintJob finished.");
    }

    public void PrintPerson(object data)
    {
        Console.WriteLine("Background PrintPerson started.");
        Thread.Sleep(1000);
        Console.WriteLine("PrintPerson still printing...");
        Person p = (Person)data;
        Console.WriteLine($"Person {p.Name} is a {p.Sex} of {p.Age} age.");
        Thread.Sleep(1000);
        Console.WriteLine("PrintPerson finished.");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }

    public Person(string name, int age, string sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
}