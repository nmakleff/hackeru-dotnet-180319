public class Program
{
    public static bool StartsWith(string Str, string LookFor)
    {
        if (Str.Length < LookFor.Length)
            return false;

        for (int i = 0; i < LookFor.Length; i++)
        {
            if (LookFor[i] != Str[i])
                return false;
        }

        return true;
    }

    public static bool EndsWith(string Str, string LookFor)
    {
        if (Str.Length < LookFor.Length)
            return false;

        for (int i = 0; i < LookFor.Length; i++)
        {
            if (LookFor[i] != Str[Str.Length - LookFor.Length + i])
                return false;
        }

        return true;
    }

    public static string Substring(string Str, int Pos, int Length)
    {
        if (Pos > Str.Length)
            return string.Empty;

        if (Length < 1)
            return string.Empty;

        if (Pos + Length > Str.Length)
            return string.Empty;

        string RetVal = string.Empty;
        for (int i = Pos; i < Pos + Length; i++)
        {
            RetVal = RetVal + Str[i];  // RetVal += Str[i]
        }

        return RetVal;
    }

    public static void Main()
    {
        string Main = "Hi Menash, What's up?";
        string LookFor = "up?";
        bool Result = EndsWith(Main, LookFor);

        if (Result == true)
        {
            Console.WriteLine("'{0}' is found in '{1}'", LookFor, Main);
        }
        else
        {
            Console.WriteLine("'{0}' is not found in '{1}'", LookFor, Main);
        }
    }
}
