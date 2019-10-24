using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class XOUI
    {
        private XO _xo;

        public XOUI()
        {
            _xo = new XO();
        }

        public void PaintBoard(string[,] Board)
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", Board[0, 0], Board[1, 0], Board[2, 0]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", Board[0, 1], Board[1, 1], Board[2, 1]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", Board[0, 2], Board[1, 2], Board[2, 2]);
            Console.WriteLine("-------------");
            Console.WriteLine();

            Console.WriteLine("Where do you want to place your X/O?");
            Console.WriteLine();

            Console.WriteLine("-------------");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }

        public void PlayGame()
        {
            bool IsGameOver = false;
            bool isThereAWinner = false;
            string winner;

            do
            {
                PaintBoard(_xo.Board);
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
                    if (_xo.SetPlayerState(num) == false)
                    {
                        Console.WriteLine("This position already has a move");
                    }
                }

                IsGameOver = _xo.IsGameOver(out isThereAWinner, out winner);
                PaintBoard(_xo.Board);
            }
            while (IsGameOver == false);

            Console.WriteLine("Do we have a winner? " + isThereAWinner);
            if (isThereAWinner == true)
                Console.WriteLine(winner + " has won");
        }
    }
}
