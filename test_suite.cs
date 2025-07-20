
using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];

        static void Main(string[] args)
        {
            InitializeBoard();

            int player = 1;
            int moves = 0;
            char currentPlayer = 'X';

            do
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {player}'s turn");
                Console.Write("Enter row (0-2): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(row, col))
                {
                    board[row, col] = currentPlayer;
                    moves++;

                    if (IsWinner(currentPlayer))
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine($"Player {player} wins!");
                        break;
                    }

                    if (moves == 9)
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    player = (player == 1) ? 2 : 1;
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            } while (true);
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

        static void DrawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            return (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '-');
        }

        static bool IsWinner(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }

                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }

            return false;
        }
    }
}
