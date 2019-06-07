using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter banana's weight: ");
        int kg = int.Parse(Console.ReadLine());

        int num;

        do
        {
            num = int.Parse(Console.ReadLine());
        } while (num != 0);

        Console.WriteLine(kg);
    }
}
