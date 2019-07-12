using System;

public class ClassA
{
    private static int _x;
    private int _y;

    public ClassA(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public void Print()
    {
        Console.WriteLine("_x = " + _x);
        Console.WriteLine("_y = " + _y);
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        ClassA C1 = new ClassA(123, 456);
        Console.WriteLine("C1 Attributes:");
        C1.Print();

        ClassA C2 = new ClassA(111, 444);
        Console.WriteLine("C2 Attributes:");
        C2.Print();
        Console.WriteLine("C1 Attributes (again):");
        C1.Print();
    }
}
