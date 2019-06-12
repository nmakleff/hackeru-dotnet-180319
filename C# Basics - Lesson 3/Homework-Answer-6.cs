using System;

public class Program
{
    public static void Main()
    {
        const int MAX_NUM = 20;
        const string INVALID_NUMBER = "Please enter a valid number between 1-20";

        int[] Ar = new int[MAX_NUM];
        int num;

        do
        {
            if (int.TryParse(Console.ReadLine(), out num) == true)
            {
                if (num == 0)
                    break;

                if (num < 1 || num > MAX_NUM)
                {
                    Console.WriteLine(INVALID_NUMBER);
                }
                else
                {
                    Ar[num - 1]++;
                }
            }
            else
            {
                Console.WriteLine(INVALID_NUMBER);
            }
        }
        while (num != 0);

        for (int i = 0; i < MAX_NUM; i++)
        {
            if (Ar[i] != 0)
            {
                Console.WriteLine((i + 1) + " was entered " + Ar[i] + " times!");
            }
        }

    }
}
