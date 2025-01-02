
using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[,] board = new char[3, 3]; // Initialize 3x3 board
        static bool player1Turn = true; // Player 1 starts first

        static void Main(string[] args)
        {
            InitializeBoard();

            while (!IsGameOver())
            {
                PrintBoard();
                MakeMove();
            }

            PrintBoard();
            Console.WriteLine("Game Over!");
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
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

        static void MakeMove()
        {
            int row, col;
            do
            {
                Console.WriteLine($"Player {(player1Turn ? 1 : 2)} Enter row and column (e.g. 0 0):");
                string[] input = Console.ReadLine().Split(' ');
                row = int.Parse(input[0]);
                col = int.Parse(input[1]);
            } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != '-');

            board[row, col] = player1Turn ? 'X' : 'O';
            player1Turn = !player1Turn;
        }

        static bool IsGameOver()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    Console.WriteLine($"Player {(player1Turn ? 2 : 1)} wins!");
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != '-' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    Console.WriteLine($"Player {(player1Turn ? 2 : 1)} wins!");
                    return true;
                }
            }

            // Check diagonals
            if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                Console.WriteLine($"Player {(player1Turn ? 2 : 1)} wins!");
                return true;
            }

            if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine($"Player {(player1Turn ? 2 : 1)} wins!");
                return true;
            }

            // Check for draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("It's a draw!");
            return true;
        }
    }
}
