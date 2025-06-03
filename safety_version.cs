
using System;

namespace TicTacToe
{
    class Program
    {
        private static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            bool gameOver = false;

            while (!gameOver)
            {
                DisplayBoard();
                int move = GetMove();
                if (IsValidMove(move))
                {
                    MakeMove(move);
                    if (CheckForWin())
                    {
                        DisplayBoard();
                        Console.WriteLine($"Player {currentPlayer} wins!");
                        gameOver = true;
                    }
                    else if (CheckForTie())
                    {
                        DisplayBoard();
                        Console.WriteLine("It's a tie!");
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        private static int GetMove()
        {
            Console.Write($"Player {currentPlayer}'s turn. Enter your move (1-9): ");
            return Convert.ToInt32(Console.ReadLine()) - 1;
        }

        private static bool IsValidMove(int move)
        {
            return move >= 0 && move < 9 && board[move] != 'X' && board[move] != 'O';
        }

        private static void MakeMove(int move)
        {
            board[move] = currentPlayer;
        }

        private static bool CheckForWin()
        {
            return (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
                   (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
                   (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
                   (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
                   (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) ||
                   (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) ||
                   (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
                   (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer);
        }

        private static bool CheckForTie()
        {
            return !Array.Exists(board, element => element != 'X' && element != 'O');
        }
    }
}
