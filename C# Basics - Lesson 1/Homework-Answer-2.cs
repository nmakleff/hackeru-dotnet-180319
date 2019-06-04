using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number of seconds: ");
        int Seconds = int.Parse(Console.ReadLine());

        int Days = Seconds / (60 * 60 * 24);
        Seconds = Seconds % (60 * 60 * 24);
        int Hours = Seconds / (60 * 60);
        Seconds = Seconds % (60 * 60);
        int Minutes = Seconds / 60;
        Seconds = Seconds % 60;

        Console.WriteLine(Days + ":" + Hours + ":" + Minutes + ":" + Seconds);
        Console.WriteLine("{0}:{1}:{2}:{3}", Days, Hours, Minutes, Seconds);
        string x = String.Format("{0}:{1}:{2}:{3}", Days, Hours, Minutes, Seconds);
        Console.WriteLine("x=" + x);
    }
}
