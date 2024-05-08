using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Player1 1 Name: ");
            string p1Name = Console.ReadLine();
            Console.Write("Enter Player1 Character choice: ");
            string p1Char = Console.ReadLine();
            Console.Write("Enter Player2 Name: ");
            string p2Name = Console.ReadLine();
            Console.Write("Enter Player2 Character choice: ");
            string p2Char = Console.ReadLine();
            Player player1 = new Player(p1Name, p1Char, true);
            Player player2 = new Player(p2Name, p2Char, false);
            string[,] board = { { "0", "1", "2" }, { "3", "4", "5" }, { "6", "7", "8" } };
            ShowBoard(board);

            while (!Game.CheckForWin(board, player1) && !Game.CheckForWin(board, player2))
            {
                try
                {
                    if (player1.IsPlayersTurn)
                    {
                        Console.WriteLine($"{player1.Name}'s turn ({player1.CharacterChoice}): ");
                        int position = int.Parse(Console.ReadLine());
                        if (player1.IsValidPosition(position))
                        {
                            if (!player1.IsOccupiedPosition(position, board))
                            {
                                player1.DrawOnBoard(position, board);
                                ShowBoard(board);
                                player1.SwitchTurns(player1, player2);
                            }
                            else
                            {
                                Console.WriteLine("Position already occupied. Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{position} is not valid");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{player2.Name}'s turn ({player2.CharacterChoice}): ");
                        int position = int.Parse(Console.ReadLine());
                        if (player2.IsValidPosition(position))
                        {
                            if (!player2.IsOccupiedPosition(position, board))
                            {
                                player2.DrawOnBoard(position, board);
                                ShowBoard(board);
                                player2.SwitchTurns(player1, player2);
                            }
                            else
                            {
                                Console.WriteLine("Position already occupied. Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{position} is not valid");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Game over!");
            Console.ReadLine();
        }


        public static void ShowBoard(string[,] board)
        {
            Console.WriteLine("===============================");
            Console.WriteLine($"|    {board[0, 0]}    |    {board[0, 1]}    |    {board[0, 2]}    |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine($"|    {board[1, 0]}    |    {board[1, 1]}    |    {board[1, 2]}    |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine($"|    {board[2, 0]}    |    {board[2, 1]}    |    {board[2, 2]}    |");
            Console.WriteLine("===============================");
        }
    }
}
