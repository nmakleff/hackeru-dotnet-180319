using System;

namespace ExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number between 1 - 3: ");
                int n = int.Parse(Console.ReadLine());

                ExceptionMakers em = new ExceptionMakers();

                switch (n)
                {
                    case 1: em.GetNumber(); break;
                    case 2: em.GetNumbers(); break;
                    case 3: em.DivideByZero(); break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a valid number");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("You have passed the length of the array");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You have divided a number by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("We've got a generic exception. The exception message is " + ex.Message);
            }
        }
    }
}
