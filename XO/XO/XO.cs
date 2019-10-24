using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class XO
    {
        private string[,] _board;
        private bool _turn;

        public XO()
        {
            _board = new string[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _board[i, j] = " ";

            _turn = false;
        }

        public void PaintBoard()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", _board[0, 0], _board[1, 0], _board[2, 0]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", _board[0, 1], _board[1, 1], _board[2, 1]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", _board[0, 2], _board[1, 2], _board[2, 2]);
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

        public bool SetPlayerState(int position)
        {
            string val = "X";
            if (_turn == true)
                val = "O";

            position--;
            int x = position % 3;
            int y = position / 3;
            if (_board[x, y] == " ")
            {
                _board[x, y] = val;
                _turn = !_turn;
                return true;
            }
            else
                return false;
                
        }

        public bool IsGameOver(out bool isThereAWinner, out string winner)
        {
            isThereAWinner = false;
            winner = " ";

            bool ifThereIsAWinnder = false;

            // Check all rows
            for (int y = 0; y < 3; y++)
            {
                ifThereIsAWinnder = true;
                for (int x = 1; x < 3; x++)
                    if (_board[x, y] != _board[x-1, y] || _board[x, y] == " ")
                    {
                        ifThereIsAWinnder = false;
                        break;
                    }

                if (ifThereIsAWinnder == true)
                {
                    isThereAWinner = true;
                    winner = _board[0, y];
                    return true;
                }
            }

            // Check all columns
            for (int x = 0; x < 3; x++)
            {
                ifThereIsAWinnder = true;
                for (int y = 1; y < 3; y++)
                    if (_board[x, y] != _board[x, y - 1] || _board[x, y] == " ")
                    {
                        ifThereIsAWinnder = false;
                        break;
                    }

                if (ifThereIsAWinnder == true)
                {
                    isThereAWinner = true;
                    winner = _board[x, 0];
                    return true;
                }
            }


            // Check 0,0 to 2,2
            ifThereIsAWinnder = true;
            for (int x = 1; x < 3; x++)
                if (_board[x, x] != _board[x - 1, x - 1] || _board[x, x] == " ")
                {
                    ifThereIsAWinnder = false;
                    break;
                }

            if (ifThereIsAWinnder == true)
            {
                isThereAWinner = true;
                winner = _board[0, 0];
                return true;
            }

            // Check 0,2 to 0,2
            ifThereIsAWinnder = true;
            for (int x = 1; x < 3; x++)
                if (_board[x, 2-x] != _board[x - 1, x + 1] || _board[x, 2 - x] == " ")
                {
                    ifThereIsAWinnder = false;
                    break;
                }

            if (ifThereIsAWinnder == true)
            {
                isThereAWinner = true;
                winner = _board[2, 0];
                return true;
            }


            // Check if all elements are filled
            bool isFilled = true;
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                    if (_board[x,y] == " ")
                    {
                        isFilled = false;
                        break;
                    }

            return isFilled;
        }
    }
}
