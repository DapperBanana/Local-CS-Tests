
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;

        static void Main(string[] args)
        {
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

                // check for valid input
                bool validInput = false;
                do
                {
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the row {0} is already marked with an {1}.", choice, board[choice - 1]);
                    }
                } while (!validInput);

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
                flag = CheckWin();
            } while (flag != 1 && flag != -1);

            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw!");
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
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            # Check for horizontal win
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

            # Check for vertical win
            if (board[0] == board[3] && board[3] == board[6])
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

            # Check for diagonal win
            if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }

            # Check for draw
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3'
                  && board[3] != '4' && board[4] != '5' && board[5] != '6'
                  && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return -1;
            }

            return 0;
        }
    }
}
