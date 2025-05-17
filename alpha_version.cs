
using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void Main()
    {
        InitializeBoard();
        PrintBoard();

        int row, col;

        do
        {
            Console.WriteLine($"Player {currentPlayer}'s turn");
            Console.Write("Enter row number (0-2): ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column number (0-2): ");
            col = Convert.ToInt32(Console.ReadLine());

            if (IsValidMove(row, col))
            {
                board[row, col] = currentPlayer;
                PrintBoard();
                if (CheckForWin())
                {
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }

                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Invalid move, try again.");
            }

        } while (!IsBoardFull());

        if (!CheckForWin())
        {
            Console.WriteLine("It's a draw!");
        }
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
        return board[row, col] == '-';
    }

    static bool CheckForWin()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] != '-' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return true;
        }
        if (board[2, 0] != '-' && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
        {
            return true;
        }

        return false;
    }

    static bool IsBoardFull()
    {
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

        return true;
    }
}
