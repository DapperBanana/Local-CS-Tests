
using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        bool gameEnded = false;

        while (!gameEnded)
        {
            PrintBoard();

            int choice = GetPlayerChoice();

            if (board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = currentPlayer;
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }

            gameEnded = CheckForWinner() || CheckForTie();
        }

        PrintBoard();

        if (CheckForWinner())
        {
            Console.WriteLine($"Player {currentPlayer} has won!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    }

    static int GetPlayerChoice()
    {
        int choice = 0;
        while (true)
        {
            Console.Write($"Player {currentPlayer}, enter your choice (1-9): ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            else
            {
                return choice - 1;
            }
        }
    }

    static bool CheckForWinner()
    {
        return (board[0] == board[1] && board[1] == board[2]) ||
               (board[3] == board[4] && board[4] == board[5]) ||
               (board[6] == board[7] && board[7] == board[8]) ||
               (board[0] == board[3] && board[3] == board[6]) ||
               (board[1] == board[4] && board[4] == board[7]) ||
               (board[2] == board[5] && board[5] == board[8]) ||
               (board[0] == board[4] && board[4] == board[8]) ||
               (board[2] == board[4] && board[4] == board[6]);
    }

    static bool CheckForTie()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
            {
                return false;
            }
        }
        return true;
    }
}
