using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class VirtualXOPlayer
    {
        public int CalcNextMove(string[,] board, string state)
        {
            int pos = CheckForWinningMove(board, state);
            if (pos == -1)
                pos = CheckForBlockMove(board, state);
            if (pos == -1)
                pos = StartAMove(board, state);

            return pos;
        }

        protected void CountElements(string X1, string X2, string X3, out int XCount, out int OCount, out int SpaceCount)
        {
            XCount = 0;
            OCount = 0;
            SpaceCount = 0;

            switch (X1)
            {
                case "X": XCount++; break;
                case "O": OCount++; break;
                case " ": SpaceCount++; break;
            }
            switch (X2)
            {
                case "X": XCount++; break;
                case "O": OCount++; break;
                case " ": SpaceCount++; break;
            }
            switch (X3)
            {
                case "X": XCount++; break;
                case "O": OCount++; break;
                case " ": SpaceCount++; break;
            }
        }

        protected int CheckForWinningMove(string[,] board, string state)
        {
            int XCount = 0;
            int OCount = 0;
            int SpaceCount = 0;

            // Check all rows
            for (int y = 0; y < 3; y++)
            {
                CountElements(board[0, y], board[1, y], board[2, y], out XCount, out OCount, out SpaceCount);
                if (state == "X")
                {
                    if (XCount == 2 && SpaceCount == 1) // This is our winning option
                        for (int x = 0; x < 3; x++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
                else if (state == "O")
                {
                    if (OCount == 2 && SpaceCount == 1) // This is our winning option
                        for (int x = 0; x < 3; x++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
            }

            // Check all columns
            for (int x = 0; x < 3; x++)
            {
                CountElements(board[x, 0], board[x, 1], board[x, 2], out XCount, out OCount, out SpaceCount);
                if (state == "X")
                {
                    if (XCount == 2 && SpaceCount == 1) // This is our winning option
                        for (int y = 0; y < 3; y++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
                else if (state == "O")
                {
                    if (OCount == 2 && SpaceCount == 1) // This is our winning option
                        for (int y = 0; y < 3; y++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
            }


            // Check 0,0 to 2,2
            CountElements(board[0, 0], board[1, 1], board[2, 2], out XCount, out OCount, out SpaceCount);
            if (state == "X")
            {
                if (XCount == 2 && SpaceCount == 1) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, y] == " ")
                            return y * 3 + (y + 1);
            }
            else if (state == "O")
            {
                if (OCount == 2 && SpaceCount == 1) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, y] == " ")
                            return y * 3 + (y + 1);
            }

            CountElements(board[0, 2], board[1, 1], board[2, 0], out XCount, out OCount, out SpaceCount);
            if (state == "X")
            {
                if (XCount == 2 && SpaceCount == 1) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, 2-y] == " ")
                            return y * 3 + (y + 1);
            }
            else if (state == "O")
            {
                if (OCount == 2 && SpaceCount == 1) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, 2-y] == " ")
                            return (2 - y) * 3 + (y + 1);
            }

            return -1;

        }

        protected int CheckForBlockMove(string[,] board, string state)
        {
            return CheckForWinningMove(board, (state == "X" ? "O" : "X"));
        }

        protected int StartAMove(string[,] board, string state)
        {
            int XCount = 0;
            int OCount = 0;
            int SpaceCount = 0;

            // First, we look for rows with two spaces and one of out state 
            
            // Check all rows
            for (int y = 0; y < 3; y++)
            {
                CountElements(board[0, y], board[1, y], board[2, y], out XCount, out OCount, out SpaceCount);
                if (state == "X")
                {
                    if (XCount > 0 && OCount == 0) // This is our winning option
                        for (int x = 0; x < 3; x++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
                else if (state == "O")
                {
                    if (OCount > 0 && XCount == 0) // This is our winning option
                        for (int x = 0; x < 3; x++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
            }

            // Check all columns
            for (int x = 0; x < 3; x++)
            {
                CountElements(board[x, 0], board[x, 1], board[x, 2], out XCount, out OCount, out SpaceCount);
                if (state == "X")
                {
                    if (XCount > 0 && OCount == 0) // This is our winning option
                        for (int y = 0; y < 3; y++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
                else if (state == "O")
                {
                    if (OCount > 0 && XCount == 0) // This is our winning option
                        for (int y = 0; y < 3; y++)
                            if (board[x, y] == " ")
                                return y * 3 + (x + 1);
                }
            }


            // Check 0,0 to 2,2
            CountElements(board[0, 0], board[1, 1], board[2, 2], out XCount, out OCount, out SpaceCount);
            if (state == "X")
            {
                if (XCount > 0 && OCount == 0) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, y] == " ")
                            return y * 3 + (y + 1);
            }
            else if (state == "O")
            {
                if (OCount > 0 && XCount == 0) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, y] == " ")
                            return y * 3 + (y + 1);
            }

            CountElements(board[0, 2], board[1, 1], board[2, 0], out XCount, out OCount, out SpaceCount);
            if (state == "X")
            {
                if (XCount > 0 && OCount == 0) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, 2 - y] == " ")
                            return y * 3 + (y + 1);
            }
            else if (state == "O")
            {
                if (OCount > 0 && XCount == 0) // This is our winning option
                    for (int y = 0; y < 3; y++)
                        if (board[y, 2 - y] == " ")
                            return y * 3 + (y + 1);
            }

            
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    if (board[x, y] == " ")
                        return y * 3 + (x + 1);

            return -1;
        }
    }
}
