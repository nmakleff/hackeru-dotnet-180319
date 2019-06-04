using System;

public class Program
{
    public static void Main()
    {
        int x;
        float Sum = 0;
        int Counter = 0;

        do
        {
            x = int.Parse(Console.ReadLine());
            Sum += x;
            if (x != 0)
                Counter++;

        } while (x != 0);

        Console.WriteLine(Sum / Counter);
    }
}
