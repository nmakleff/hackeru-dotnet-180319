using System;

public class Program
{
    public static void KeepInRange(out int vol)
    {
        if (vol < 0)
            vol = 0;
        if (vol > 100)
            vol = 100;
        else
            vol = 1;
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the system volume (1-100):");
        int volume = int.Parse(Console.ReadLine());

        KeepInRange(out volume);

        Console.WriteLine("The actual set volume is " + volume);
    }
}
