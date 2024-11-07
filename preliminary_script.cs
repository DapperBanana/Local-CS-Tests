
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // Player 1 starts
        static int choice;
        static int flag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // whenever loop starts app screen will be clear
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Turn Player 2");
                }
                else
                {
                    Console.WriteLine("Turn Player 1");
                }
                Console.WriteLine("\n");
                Board();

                // if any player completes any row, column or cross
                flag = CheckWin();

                player++;

            } while (flag != 1 && flag != -1);

            // After Complete execution, we again asks to have another round
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        // board method which creates board 
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        // Checking that any player has won or not
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
            // If all columns or rows or diagonal elements have same content
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}
