using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public static bool CheckForWin(string[,] board, Player player)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == player.CharacterChoice && board[row, 1] == player.CharacterChoice && board[row, 2] == player.CharacterChoice)
                {
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == player.CharacterChoice && board[1, col] == player.CharacterChoice && board[2, col] == player.CharacterChoice)
                {
                    return true;
                }
            }

            // Check diagonals
            if ((board[0, 0] == player.CharacterChoice && board[1, 1] == player.CharacterChoice && board[2, 2] == player.CharacterChoice) ||
                (board[0, 2] == player.CharacterChoice && board[1, 1] == player.CharacterChoice && board[2, 0] == player.CharacterChoice))
            {
                return true;
            }

            return false;
        }
    }
}
