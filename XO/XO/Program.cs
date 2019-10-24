using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            XO xo = new XO();
            xo.PaintBoard();

            bool IsGameOver = false;
            bool isThereAWinner = false;
            string winner;

            do
            {
                xo.PaintBoard();
                string pos = Console.ReadLine();
                int num = 0;

                if (int.TryParse(pos, out num) == false)
                {
                    Console.WriteLine("Please enter a valid number between 1-9");
                }
                else if (num < 1 || num > 9)
                {
                    Console.WriteLine("Please enter a valid number between 1-9");
                }
                else
                {
                    if (xo.SetPlayerState(num) == false)
                    {
                        Console.WriteLine("This position already has a move");
                    }
                }

                IsGameOver = xo.IsGameOver(out isThereAWinner, out winner);
                xo.PaintBoard();
            }
            while (IsGameOver == false);

            Console.WriteLine("Do we have a winner? " + isThereAWinner);
            if (isThereAWinner == true)
                Console.WriteLine(winner + " has won");
        }
    }
}
