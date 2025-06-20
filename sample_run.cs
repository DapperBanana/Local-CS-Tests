
using System;

class Program
{
    static char[,] board = new char[3, 3]; // 3x3 tic-tac-toe board
    static char currentPlayer = 'X'; // Starting player
    static bool gameOver = false; // Flag to check if game is over

    static void Main()
    {
        InitializeBoard();

        while (!gameOver)
        {
            DisplayBoard();
            MakeMove();
            CheckForWin();
            CheckForDraw();
            ChangePlayer();
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

    static void DisplayBoard()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void MakeMove()
    {
        Console.WriteLine("Player " + currentPlayer + ", make your move (row column): ");
        string input = Console.ReadLine();
        string[] coordinates = input.Split(' ');
        int row = int.Parse(coordinates[0]);
        int col = int.Parse(coordinates[1]);

        if (board[row, col] == '-')
        {
            board[row, col] = currentPlayer;
        }
        else
        {
            Console.WriteLine("Invalid move. Please try again.");
            MakeMove();
        }
    }

    static void CheckForWin()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                Console.WriteLine("Player " + currentPlayer + " wins!");
                gameOver = true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
            {
                Console.WriteLine("Player " + currentPlayer + " wins!");
                gameOver = true;
            }
        }

        // Check diagonals
        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            Console.WriteLine("Player " + currentPlayer + " wins!");
            gameOver = true;
        }
        else if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            Console.WriteLine("Player " + currentPlayer + " wins!");
            gameOver = true;
        }
    }

    static void CheckForDraw()
    {
        bool isDraw = true;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '-')
                {
                    isDraw = false;
                    break;
                }
            }
        }

        if (isDraw)
        {
            Console.WriteLine("It's a draw!");
            gameOver = true;
        }
    }

    static void ChangePlayer()
    {
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
    }
}
