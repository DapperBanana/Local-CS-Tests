
using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1; // Player 1 starts
            int choice = 0;
            int flag = 0;

            do
            {
                Console.Clear();
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

                choice = int.Parse(Console.ReadLine());
                

                if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        board[choice - 1] = 'O';
                        player++;
                    }
                    else
                    {
                        board[choice - 1] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with an {1}", choice, board[choice - 1]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Wait for the next turn");
                    Console.ReadKey();
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            Board();
            
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        // Check win
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
            else if (board[1] == board[4] && board[4] == board[7] )
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
            else if (board[0] == 'O' && board[4] == 'O' && board[8] == 'O')
            {
                return 1;
            }
            // Winning Condition For Diagonal
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            #endregion

            #region If any of the Row is crossed with the same player
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

        // The game board
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
    }
}
