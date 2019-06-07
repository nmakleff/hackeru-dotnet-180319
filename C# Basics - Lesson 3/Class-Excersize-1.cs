using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many children do you have?");
        int ChildrenCount = int.Parse(Console.ReadLine());

        string[] Names = new string[ChildrenCount];

        for (int i = 0; i < ChildrenCount; i++)
        {
            Console.Write("What is your #{0} childs name: ", i + 1);
            Names[i] = Console.ReadLine();
        }

        Console.WriteLine("Please say hello to ");
        for (int i = 0; i < ChildrenCount; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }

            Console.Write(Names[i]);
        }
    }
}
