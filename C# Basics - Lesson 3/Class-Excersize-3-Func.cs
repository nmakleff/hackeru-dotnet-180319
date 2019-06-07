using System;

public class Program
{
    public static int Max(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int Bigger = Max(a, b);

        Console.WriteLine("The bigger number is: " + Bigger);

    }
}
