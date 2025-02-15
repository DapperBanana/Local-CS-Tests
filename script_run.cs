
using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

            bool player1Turn = true;
            bool gameover = false;
            char currentPlayer = 'X';

            while (!gameover)
            {
                PrintBoard(board);

                int[] move = GetMove(player1Turn);
                int row = move[0];
                int col = move[1];

                if (board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;
                    gameover = CheckWin(board, currentPlayer);
                    if (!gameover)
                    {
                        player1Turn = !player1Turn;
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move, try again.");
                }
            }

            PrintBoard(board);
            if (currentPlayer == 'X')
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("  -----");
                }
            }
        }

        static int[] GetMove(bool player1Turn)
        {
            int[] move = new int[2];
            string player = player1Turn ? "Player 1" : "Player 2";

            Console.WriteLine(player + "'s turn. Enter row and column numbers separated by a space:");
            string[] input = Console.ReadLine().Split(' ');

            move[0] = int.Parse(input[0]);
            move[1] = int.Parse(input[1]);

            return move;
        }

        static bool CheckWin(char[,] board, char player)
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

            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            {
                return true;
            }

            return false;
        }
    }
}
