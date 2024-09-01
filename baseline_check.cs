
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Calculator!");

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("Exiting the calculator...");
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
