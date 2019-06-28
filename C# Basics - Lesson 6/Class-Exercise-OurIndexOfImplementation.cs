using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine();

        string searchingFor = "ab";

        for (int i = 0; i < s.Length - searchingFor.Length + 1; i++)
        {
            bool found = true;

            for (int j = 0; j < searchingFor.Length; j++)
            {
                if (s[i + j] != searchingFor[j])
                {
                    found = false;
                    break;
                }
            }

            if (found == true)
            {
                Console.WriteLine("We found the search string in position " + i);
                break;
            }

        }
    }
}

