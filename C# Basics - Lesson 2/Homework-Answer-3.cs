using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
