
using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';
        static bool gameOver = false;

        static void Main(string[] args)
        {
            InitializeBoard();

            while (!gameOver)
            {
                DrawBoard();
                MakeMove();
                CheckForWinner();
                CheckForTie();
                ChangePlayer();
            }
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MakeMove()
        {
            bool validMove = false;
            while (!validMove)
            {
                Console.Write($"Player {currentPlayer}, enter row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write($"Player {currentPlayer}, enter col: ");
                int col = int.Parse(Console.ReadLine());

                if (board[row, col] == '-')
                {
                    board[row, col] = currentPlayer;
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Invalid move, try again.");
                }
            }
        }

        static void CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                {
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    gameOver = true;
                }
                else if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                {
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    gameOver = true;
                }
            }

            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                Console.WriteLine($"Player {currentPlayer} wins!");
                gameOver = true;
            }
            else if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            {
                Console.WriteLine($"Player {currentPlayer} wins!");
                gameOver = true;
            }
        }

        static void CheckForTie()
        {
            int count = 0;
            foreach (char symbol in board)
            {
                if (symbol != '-')
                {
                    count++;
                }
            }
            if (count == 9)
            {
                Console.WriteLine("It's a tie!");
                gameOver = true;
            }
        }

        static void ChangePlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}
