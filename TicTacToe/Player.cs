using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public string Name { get; set; }
        public string CharacterChoice { get; set; }
        public bool IsPlayersTurn { get; set; }

        public Player() { }

        public Player(string name, string characterChoice, bool isPlayersTurn)
        {
            Name = name;
            CharacterChoice = characterChoice;
            IsPlayersTurn = isPlayersTurn;
        }

        public void Place(Player player)
        {
            if (player.IsPlayersTurn)
            {
                PrintMessage("Its your turn");
            }
            else
            {
                PrintMessage("Its not your turn");
            }
        }
        public void DrawOnBoard(int position, string[,] board)
        {
            switch (position)
            {
                case 0:
                    board[0, 0] = CharacterChoice;
                    break;
                case 1:
                    board[0, 1] = CharacterChoice;
                    break;
                case 2:
                    board[0, 2] = CharacterChoice;
                    break;
                case 3:
                    board[1, 0] = CharacterChoice;
                    break;
                case 4:
                    board[1, 1] = CharacterChoice;
                    break;
                case 5:
                    board[1, 2] = CharacterChoice;
                    break;
                case 6:
                    board[2, 0] = CharacterChoice;
                    break;
                case 7:
                    board[2, 1] = CharacterChoice;
                    break;
                case 8:
                    board[2, 2] = CharacterChoice;
                    break;
            }
        }

        public void SwitchTurns(Player player1, Player player2)
        {
            player1.IsPlayersTurn = !player1.IsPlayersTurn;
            player2.IsPlayersTurn = !player2.IsPlayersTurn;
        }

        public bool IsOccupiedPosition(int position, string[,] board)
        {
            switch (position)
            {
                case 0: return board[0, 0] != "0";
                case 1: return board[0, 1] != "1";
                case 2: return board[0, 2] != "2";
                case 3: return board[1, 0] != "3";
                case 4: return board[1, 1] != "4";
                case 5: return board[1, 2] != "5";
                case 6: return board[2, 0] != "6";
                case 7: return board[2, 1] != "7";
                case 8: return board[2, 2] != "8";
                default: return true; // Invalid position
            }
        }


        public bool IsValidPosition(int position)
        {
            return position <= 8 && position >= 0;
        }
        private void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
