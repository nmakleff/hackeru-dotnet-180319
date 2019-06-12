using System;

public class Program
{
    public static void Main()
    {
        int a;
        GetNumber(1, 100, out a);
        int b;
        GetNumber(1, 100, out b);

        int m = Max(a, b);
        Console.WriteLine("The max number between the two is: " + m);
    }

    public static void GetNumber(int RangeFrom, int RangeTo, out int NewNum)
    {
        Console.WriteLine("Now in GetNumber(RangeFrom,RangeTo)");
        int num;
        do
        {
            Console.WriteLine("Please enter a number between {0}-{1}: ", RangeFrom, RangeTo);
            num = int.Parse(Console.ReadLine());
        } while (num < RangeFrom || num > RangeTo);

        NewNum = num;
    }

    public static int Max(int x, int y)
    {
        Console.WriteLine("Now in Max(x,y)");
        if (x > y)
            return x;
        else
            return y;
    }
}
