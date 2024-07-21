
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';
        static bool gameover = false;

        static void Main(string[] args)
        {
            while (!gameover)
            {
                Console.Clear();
                DrawBoard();

                int position;
                bool validMove = false;

                do
                {
                    Console.WriteLine($"Player {currentPlayer}'s turn. Enter position (1-9): ");
                    string input = Console.ReadLine();
                    validMove = Int32.TryParse(input, out position) && position >= 1 && position <= 9 && board[position - 1] != 'X' && board[position - 1] != 'O';
                } while (!validMove);

                board[position - 1] = currentPlayer;

                if (CheckWin())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    gameover = true;
                }
                else if (CheckDraw())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("It's a draw!");
                    gameover = true;
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        static bool CheckWin()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == currentPlayer && board[i * 3 + 1] == currentPlayer && board[i * 3 + 2] == currentPlayer)
                    return true;
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == currentPlayer && board[i + 3] == currentPlayer && board[i + 6] == currentPlayer)
                    return true;
            }

            // Check diagonals
            if ((board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
                (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer))
            {
                return true;
            }

            return false;
        }

        static bool CheckDraw()
        {
            foreach (char c in board)
            {
                if (c != 'X' && c != 'O')
                    return false;
            }
            return true;
        }
    }
}
