using System;

public class Program
{
	public void Main()
	{
        string S1;

        do
        {
            Console.WriteLine("Please enter a string that is more than 3 char of length: ");
            S1 = Console.ReadLine();
        }
        while (S1.Length < 3);

        Console.WriteLine("Please enter a second string to be inserted into the first one: ");
        string S2 = Console.ReadLine();

        S1 = S1.Insert(2, S2);

        Console.WriteLine(S1);
        
	}
}
