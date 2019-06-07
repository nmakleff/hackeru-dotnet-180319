using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number");
        int Num = int.Parse(Console.ReadLine());
        int NewNum = 0;

        while (Num > 0)
        {
            int Digit = Num % 10;
            NewNum = NewNum * 10;
            NewNum = NewNum + Digit;
            Num = Num / 10;
        }

        Console.WriteLine(NewNum);
    }
}
