using System;

public class Program
{
    public static void Main()
    {
        string s = "http://www.ynet.co.il";
        if (s.EndsWith("ynet.co.il") == true)
        {
            Console.WriteLine("This is ynet");
        }
        else
        {
            Console.WriteLine("This is not ynet");
        }
    }
}
