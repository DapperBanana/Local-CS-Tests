
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            bool gameEnded = false;

            while (!gameEnded)
            {
                Console.Clear();
                DrawBoard();

                int choice = GetPlayerChoice();

                if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    board[choice - 1] = currentPlayer;
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                }

                char winner = CheckForWinner();
                if (winner != '-')
                {
                    gameEnded = true;
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Player {winner} wins!");
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        static int GetPlayerChoice()
        {
            Console.WriteLine($"Player {currentPlayer}'s turn (1-9): ");
            return int.Parse(Console.ReadLine());
        }

        static char CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    return board[i];
                }
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 2])
                {
                    return board[i * 3];
                }
            }

            if (board[0] == board[4] && board[0] == board[8])
            {
                return board[0];
            }
            if (board[2] == board[4] && board[2] == board[6])
            {
                return board[2];
            }

            return '-';
        }
    }
}
