
using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1;
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

                // Test for a winner
                flag = CheckWin();

                // If the board is full, it's a tie
                if (flag == 1)
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }

                // Changing player
                if (player % 2 == 0)
                {
                    player = 1;
                }
                else
                {
                    player = 2;
                }

                Console.WriteLine("Player {0}, enter your choice: ", player);
                choice = Int32.Parse(Console.ReadLine());

                // Marking the player's choice on the board
                if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    if (player == 1)
                    {
                        board[choice - 1] = 'X';
                        player++;
                    }
                    else
                    {
                        board[choice - 1] = 'O';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with an {1}", choice, board[choice - 1]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 seconds for the board to load again");
                    Console.WriteLine("\n");
                    System.Threading.Thread.Sleep(2000);
                }
                flag = 0;
            } while (flag != 1);

            // Print the board
            Board();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", player);
            }

            Console.ReadLine();
        }

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

        private static int CheckWin()
        {
            # Check for a win across rows
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }

            # Check for a win across columns
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }

            # Check for a win diagonally
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }

            # Check for a tie
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
