
using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];

        static void Main(string[] args)
        {
            InitializeBoard();
            bool player1Turn = true;

            while (true)
            {
                DrawBoard();
                int row, col;
                char playerSymbol = player1Turn ? 'X' : 'O';

                do
                {
                    Console.WriteLine($"Player {(player1Turn ? 1 : 2)} enter row and column (1-3, space separated): ");
                    string[] input = Console.ReadLine().Split(' ');
                    row = int.Parse(input[0]) - 1;
                    col = int.Parse(input[1]) - 1;
                } while (!IsValidMove(row, col));

                board[row, col] = playerSymbol;

                if (CheckWin(playerSymbol))
                {
                    DrawBoard();
                    Console.WriteLine($"Player {(player1Turn ? 1 : 2)} wins!");
                    break;
                }

                if (CheckDraw())
                {
                    DrawBoard();
                    Console.WriteLine("It's a draw!");
                    break;
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

        static void DrawBoard()
        {
            Console.WriteLine("  1 2 3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
            {
                Console.WriteLine("Invalid move. Please enter numbers between 1 and 3.");
                return false;
            }
            if (board[row, col] != ' ')
            {
                Console.WriteLine("Invalid move. That position is already taken.");
                return false;
            }
            return true;
        }

        static bool CheckWin(char playerSymbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playerSymbol && board[i, 1] == playerSymbol && board[i, 2] == playerSymbol)
                    return true;
                if (board[0, i] == playerSymbol && board[1, i] == playerSymbol && board[2, i] == playerSymbol)
                    return true;
            }

            if (board[0, 0] == playerSymbol && board[1, 1] == playerSymbol && board[2, 2] == playerSymbol)
                return true;
            if (board[0, 2] == playerSymbol && board[1, 1] == playerSymbol && board[2, 0] == playerSymbol)
                return true;

            return false;
        }

        static bool CheckDraw()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == ' ')
                        return false;

            return true;
        }
    }
}
