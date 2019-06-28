using System;

public class Program
{
	public void Main()
	{
        string S1 = Console.ReadLine(); 
        string S2 = Console.ReadLine();

        if (S1.IndexOf(S2) >= 0)
        {
            Console.WriteLine("Second string found in first string");
        }
        else
        {
            Console.WriteLine("Second string not found in first string");
        }

        
	}
}
