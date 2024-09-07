
using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // Player 1 starts
    static int choice;
    static int flag = 0;

    static void Main()
    {
        do
        {
            Console.Clear(); // Whenever loop will restart, screen will be cleared
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0) // Checking the chance of the player
            {
                Console.WriteLine("Turn Player 2");
            }
            else
            {
                Console.WriteLine("Turn Player 1");
            }
            Console.WriteLine("\n");
            Board();

            // Checking the input pos by the user
            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput || choice < 1 || choice > 9 || board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                Console.WriteLine("Invalid input! Please enter a valid position.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            else
            {
                if (player % 2 == 0) // If chance is of player 2 then mark O
                {
                    board[choice - 1] = 'O';
                    player++;
                }
                else  // If chance is of player 1 then mark X
                {
                    board[choice - 1] = 'X';
                    player++;
                }
                flag = CheckWin();
            }
        } while (flag != 1 && flag != -1); // Loop will run until the flag value because if flag == 1 or flag = -1 the game will terminate

        Console.Clear(); // clearing console
        Board();

        if (flag == 1) // If flag value is 1 then some one has win or means who has last turn that player has won
        {
            Console.WriteLine("Player {0} has won!", (player % 2) + 1);
        }
        else // If flag value is -1 the game will be draw and no one's win
        {
            Console.WriteLine("Draw");
        }

        Console.ReadLine();
    }

    // Board method to create board
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    // Check win method to check the winning condition of the game
    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        // Winning Condition For First Row
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        // Winning Condition For Second Row
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        // Winning Condition For Third Row
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        // Winning Condition For First Column
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        // Winning Condition For Second Column
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        // Winning Condition For Third Column
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        // If all the cells or values filled with X or O then any player has won the match
        if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        return 0;
    }
}
