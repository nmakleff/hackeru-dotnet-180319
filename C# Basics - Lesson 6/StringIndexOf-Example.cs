public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string Name = Console.ReadLine();
        int Pos = Name.IndexOf("ir");
        int Count = 0;

        while (Pos != -1)
        {
            Console.WriteLine("ir is found in name in position " + Pos);
            Count++;
            Pos = Name.IndexOf("ir", Pos + 1);
        }

        Console.WriteLine("We have found 'ir' {0} times", Count);
    }
}
