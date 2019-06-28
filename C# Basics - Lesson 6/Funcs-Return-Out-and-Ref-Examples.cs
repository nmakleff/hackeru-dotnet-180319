using System;
    
public class Program
{
public static int Sum(int a, int b)
{
 return a + b;
}

public static void SumMulOut(int a, int b, out int sum, out int mul, out int min, out int max)
{
 sum = a + b;
 mul = a * b;
 min = (a < b ? a : b);
 max = (a > b ? a : b);
}

public static void Sqr2(ref int x)
{
 x = x * x;
}



public static void Main()
{
 int res1 = Sum(10, 20);
 int res2, res3, minNum, maxNum;
 SumMulOut(10, 20, out res2, out res3, out minNum, out maxNum);
 
 int sqr2Num = 25;
 Sqr2(ref sqr2Num);
 
 Console.WriteLine(res1);
 Console.WriteLine(res2);
 Console.WriteLine(minNum);
 Console.WriteLine(maxNum);
 Console.WriteLine(sqr2Num);
}
}
