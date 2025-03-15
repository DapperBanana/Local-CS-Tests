
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Space Exploration Game!");
            Console.WriteLine("Choose a planet to explore:");
            Console.WriteLine("1. Mercury");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Earth");
            Console.WriteLine("4. Mars");
            Console.WriteLine("5. Jupiter");
            Console.WriteLine("6. Saturn");
            Console.WriteLine("7. Uranus");
            Console.WriteLine("8. Neptune");
            Console.WriteLine("9. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You have reached Mercury!");
                    break;
                case "2":
                    Console.WriteLine("You have reached Venus!");
                    break;
                case "3":
                    Console.WriteLine("You have reached Earth!");
                    break;
                case "4":
                    Console.WriteLine("You have reached Mars!");
                    break;
                case "5":
                    Console.WriteLine("You have reached Jupiter!");
                    break;
                case "6":
                    Console.WriteLine("You have reached Saturn!");
                    break;
                case "7":
                    Console.WriteLine("You have reached Uranus!");
                    break;
                case "8":
                    Console.WriteLine("You have reached Neptune!");
                    break;
                case "9":
                    Console.WriteLine("Thank you for playing the Space Exploration Game!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine("Do you want to continue exploring? (Y/N)");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() != "y")
            {
                Console.WriteLine("Thank you for playing the Space Exploration Game!");
                break;
            }
        }
    }
}
