using System;

public class Program
{
    public static void Main()
    {
        int[] Numbers = new int[10];

        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = int.Parse(Console.ReadLine());
        }

        int Sum = 0;
        int OddSum = 0;

        for (int i = 0; i < Numbers.Length; i++)
        {
            Sum += Numbers[i];
            if (i % 2 == 1)
                OddSum += Numbers[i];
        }

        Console.WriteLine(Sum / 10);
        Console.WriteLine(OddSum);

    }
}
