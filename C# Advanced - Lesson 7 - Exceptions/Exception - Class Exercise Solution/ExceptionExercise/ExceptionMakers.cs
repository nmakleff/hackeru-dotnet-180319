using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercise
{
    class ExceptionMakers
    {
        public int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        public int[] GetNumbers()
        {
            int[] numbers = new int[4];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        public void DivideByZero()
        {
            int x = 0;
            x = 10 / x;
        }
    }
}
