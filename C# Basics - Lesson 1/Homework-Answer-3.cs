using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter a number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine((x > 0) ? "X is positive" : "X is negative");
        Console.WriteLine((x % 2 == 0) ? "X is even" : "X is odd");
        Console.WriteLine((x > 100) ? "x > 100" : "");
    }
}
