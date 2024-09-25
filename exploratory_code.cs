
using System;

class Program
{
    static void Main()
    {
        char[,] board = {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        char player = 'X';
        int moves = 0;

        while (true)
        {
            Console.Clear();
            PrintBoard(board);

            Console.WriteLine($"Player {player}'s turn. Choose a position (1-9):");
            int position = Convert.ToInt32(Console.ReadLine()) - 1;

            int row = position / 3;
            int col = position % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("Invalid move. Position already taken. Try again.");
                Console.ReadKey();
                continue;
            }

            board[row, col] = player;
            moves++;

            if (CheckWin(board, player))
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Player {player} wins!");
                break;
            }

            if (moves == 9)
            {
                Console.WriteLine("It's a tie!");
                break;
            }

            player = (player == 'X') ? 'O' : 'X';
        }
    }

    static void PrintBoard(char[,] board)
    {
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"| {board[i, j]} ");
            }
            Console.WriteLine("|");
            Console.WriteLine("-------------");
        }
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

        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        {
            return true;
        }

        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        {
            return true;
        }

        return false;
    }
}
