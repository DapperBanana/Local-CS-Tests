
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
                Console.WriteLine("Player1: X and Player2: O");
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
                    Console.WriteLine("Sorry the row {0} is already marked with an {1}", choice, board[choice - 1]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second the board is loading...");
                    System.Threading.Thread.Sleep(2000);
                }
                flag = CheckWin(); 
            } while (flag != 1 && flag != -1);

            Console.Clear(); // clearing console
            Board(); // getting filled board again
            if (flag == 1) // if flag value is 1
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else // if flag value is -1
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("-------------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("-------------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            # checking whether Player 1 has won or player 2
            # checking horizontally
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
            # checking vertically
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
            # checking 2 main diagonals
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            # Checking for draw
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' 
                     && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' 
                     && board[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
