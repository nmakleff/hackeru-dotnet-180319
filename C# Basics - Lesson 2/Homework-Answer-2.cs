using System;

public class Program
{
    public static void Main()
    {
        int num;
        bool IsNumber;

        do
        {
            IsNumber = int.TryParse(Console.ReadLine(), out num);
            if (IsNumber == true)
            {
                if (num != 0)
                {
                    Console.WriteLine("Number is " + ((num > 0) ? "positive" : "negative"));
                    Console.WriteLine("Number is " + ((num % 2 == 0) ? "even" : "odd"));
                }
            }
            else
            {
                Console.WriteLine("This is not a number");
            }

        } while (num != 0 || IsNumber == false);
    }
}

