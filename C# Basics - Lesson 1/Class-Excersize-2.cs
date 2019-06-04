using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter distance: ");
		int Distance = int.Parse(Console.ReadLine());

		Console.Write("Enter the amount of gas left: ");
		int GasLeft = int.Parse(Console.ReadLine());

		Console.Write("Enter Km/L: ");
		int KmL = int.Parse(Console.ReadLine());
		
		if (KmL * GasLeft >= Distance)
		{
			Console.WriteLine("We have enough gas!");
		}
		else
		{
			Console.WriteLine("We dont have enough gas!");		
		}
	}
}