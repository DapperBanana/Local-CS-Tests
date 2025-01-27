
using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static char player = 'X';

        static void Main(string[] args)
        {
            InitializeBoard();

            do
            {
                DrawBoard();
                GetMove();
                player = (player == 'X') ? 'O' : 'X';
            } while (!CheckForWin() && !CheckForTie());

            DrawBoard();

            if (CheckForWin())
            {
                Console.WriteLine("Player " + player + " wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void DrawBoard()
        {
            Console.Clear();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if (col < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (row < 2)
                {
                    Console.WriteLine("-----");
                }
            }
        }

        static void GetMove()
        {
            bool validMove = false;

            do
            {
                Console.WriteLine("Player " + player + ", enter your move (row, col):");
                string[] input = Console.ReadLine().Split(',');
                int row = Convert.ToInt32(input[0].Trim());
                int col = Convert.ToInt32(input[1].Trim());

                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
                {
                    board[row, col] = player;
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            } while (!validMove);
        }

        static bool CheckForWin()
        {
            // Check rows for win
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }
            }

            // Check columns for win
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }

            // Check diagonals for win
            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) || 
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            {
                return true;
            }

            return false;
        }

        static bool CheckForTie()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
