
using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static bool player1Turn = true;
        static bool gameover = false;

        static void Main(string[] args)
        {
            InitializeBoard();

            while (!gameover)
            {
                PrintBoard();

                int row, col;
                do
                {
                    Console.WriteLine($"Player {(player1Turn ? 1 : 2)}, enter row (0-2):");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Player {(player1Turn ? 1 : 2)}, enter column (0-2):");
                    col = int.Parse(Console.ReadLine());
                } while (!IsValidMove(row, col));

                board[row, col] = player1Turn ? 'X' : 'O';

                if (CheckForWin())
                {
                    PrintBoard();
                    Console.WriteLine($"Player {(player1Turn ? 1 : 2)} wins!");
                    gameover = true;
                }
                else if (CheckForTie())
                {
                    PrintBoard();
                    Console.WriteLine("It's a tie!");
                    gameover = true;
                }

                player1Turn = !player1Turn;
            }
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            if (board[row, col] == ' ')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                return false;
            }
        }

        static bool CheckForWin()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    return true;
                }
            }

            // Check diagonals
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
                || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' '))
            {
                return true;
            }

            return false;
        }

        static bool CheckForTie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
