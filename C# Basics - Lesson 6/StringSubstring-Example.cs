using System;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        if (s.ToLower().IndexOf("doctor") != -1)
        {
            int doctorPos = s.ToLower().IndexOf("doctor");
            doctorPos += "doctor ".Length;
            string doctorsName = s.Substring(doctorPos, s.IndexOf(" ", doctorPos) - doctorPos);

            Console.WriteLine("The doctor's name is: " + doctorsName);
        }
        else
        {
            Console.WriteLine("No doctor was found!");
        }

    }
}
