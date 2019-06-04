using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter the first number: ");
        int Num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the arithmetic operator ('+', '-', '*' or '/'): ");
        string Op = Console.ReadLine();
        Console.Write("Please enter the second number: ");
        int Num2 = int.Parse(Console.ReadLine());

        Console.Write(Num1 + Op + Num2 + "=");
        switch (Op)
        {
            case "+": Console.WriteLine((Num1 + Num2)); break;
            case "-": Console.WriteLine((Num1 - Num2)); break;
            case "*": Console.WriteLine((Num1 * Num2)); break;
            case "/": Console.WriteLine((Num1 / Num2)); break;
            default: Console.WriteLine("Illegal arithmetic operator"); break;
        }
    }
}
