using System;

public class A
{
    public int X { get; set; }

    public virtual void PrintData()
    {
        Console.WriteLine(X);
    }

    public virtual void PrintClassName()
    {
        Console.WriteLine("A");
    }
}

public class B : A
{
    public int Y { get; set; }

    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine(Y);
    }

    public override void PrintClassName()
    {
        Console.WriteLine("B");
    }
}

public class Program
{
    public static void Main()
    {
        A a = new A();
        a.X = 1;

        B b = new B();
        b.X = 2;
        b.Y = 3;

        Console.WriteLine("This is A");
        a.PrintClassName();
        a.PrintData();
        Console.WriteLine("This is B");
        b.PrintClassName();
        b.PrintData();

    }
}
