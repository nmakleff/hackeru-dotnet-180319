using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Let's speak English with a Chinese accent...");
        Console.Write("Enter something in English: ");
        string s = Console.ReadLine();
        s = s.Replace("r", "l");
        s = s.Replace("R", "L");
        Console.WriteLine("With Chinese accent it will sound like this: " + s);
    }
}
