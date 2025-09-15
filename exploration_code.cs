
using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void Main()
    {
        InitializeBoard();
        PlayGame();
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

    static void PlayGame()
    {
        int turns = 0;
        bool gameWon = false;

        while (!gameWon && turns < 9)
        {
            Console.WriteLine("Current board:");
            PrintBoard();

            Console.WriteLine("Player {0}, enter the row and column where you want to place your mark (e.g. '1 1' for top left cell):", currentPlayer);
            string[] input = Console.ReadLine().Split(' ');

            int row = int.Parse(input[0]) - 1;
            int col = int.Parse(input[1]) - 1;

            if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != '-')
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            board[row, col] = currentPlayer;

            gameWon = CheckWinCondition();

            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            turns++;
        }

        Console.WriteLine("Game over!");
        if (gameWon)
        {
            Console.WriteLine("Player {0} wins!", currentPlayer == 'X' ? 'O' : 'X');
            PrintBoard();
        }
        else
        {
            Console.WriteLine("It's a tie!");
            PrintBoard();
        }
    }

    static bool CheckWinCondition()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer &&
                board[i, 1] == currentPlayer &&
                board[i, 2] == currentPlayer)
            {
                return true;
            }

            if (board[0, i] == currentPlayer &&
                board[1, i] == currentPlayer &&
                board[2, i] == currentPlayer)
            {
                return true;
            }
        }

        if (board[0, 0] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 2] == currentPlayer)
        {
            return true;
        }

        if (board[0, 2] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 0] == currentPlayer)
        {
            return true;
        }

        return false;
    }
}
