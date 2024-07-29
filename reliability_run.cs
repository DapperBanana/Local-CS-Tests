
using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';
    static bool gameWon = false;

    static void Main()
    {
        InitializeBoard();

        do
        {
            DisplayBoard();
            MakeMove();
            gameWon = CheckForWin();
            SwitchPlayer();

        } while (!gameWon);

        DisplayBoard();
        Console.WriteLine($"Player {currentPlayer} wins!");
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

    static void DisplayBoard()
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
            Console.Write($"Player {currentPlayer}, enter row (0-2): ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Player {currentPlayer}, enter column (0-2): ");
            col = Convert.ToInt32(Console.ReadLine());
        } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != '-');

        board[row, col] = currentPlayer;
    }

    static bool CheckForWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                return true;
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                return true;
        }

        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            return true;
        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            return true;

        return false;
    }

    static void SwitchPlayer()
    {
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
    }
}
