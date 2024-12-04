
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the basic calculator program!");

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
