using System;

public class Rectangle
{
    private int _width;
    private int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public void Show()
    {
        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}


public class Program
{
    public static void Main()
    {
        Rectangle rect = new Rectangle(10, 10);

        //rect._height = 4;
        //rect._width = 10;
        rect.Show();
    }
}
