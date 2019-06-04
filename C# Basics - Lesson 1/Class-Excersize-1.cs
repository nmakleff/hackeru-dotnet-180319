using System;
					
public class Program
{
	public static void Main()
	{
		int x, y;
		
		Console.Write ("Please enter the first number: ");
		x = int.Parse(Console.ReadLine());

		Console.Write ("Please enter the second number: ");
		y = int.Parse(Console.ReadLine());
		
		Console.Write("The sum of the numric values are: ");
		Console.WriteLine(x + y);

		Console.WriteLine("The sum of the numric values are: " + (x + y));
		
		
		Console.Write("The sum of the string values are: ");
		Console.WriteLine(x.ToString() + y.ToString());

		Console.Write("The sum of the string values are: " + x + y);


	}
}