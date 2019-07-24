using System;

namespace ExceptionExample
{
    class Program
    {
        public static int GetUserInput()
        {
            try
            {
                int num;

                Console.WriteLine("Please enter a number");
                string numStr = Console.ReadLine();

                if (int.TryParse(numStr, out num) == false)
                {
                    throw new Exception("The string entered is not a number");
                }

                if (num % 3 == 0)
                {
                    throw new NumberDividesByThreeException();
                }

                return num;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void Main(string[] args)
        {
            bool IsOK = false;

            do
            {
                try
                {
                    int n = GetUserInput();
                }
                catch (NumberDividesByThreeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    
                }
            } while (IsOK == false);

        }
    }
}
