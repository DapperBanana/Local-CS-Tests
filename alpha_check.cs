
using System;

class Calendar
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calendar Program!\n");

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View Calendar");
            Console.WriteLine("2. Quit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nJanuary 2022\n");
                Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                Console.WriteLine("               1   2   3");
                Console.WriteLine("  4   5   6   7   8   9  10");
                Console.WriteLine(" 11  12  13  14  15  16  17");
                Console.WriteLine(" 18  19  20  21  22  23  24");
                Console.WriteLine(" 25  26  27  28  29  30  31\n");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
            }
        }
    }
}
