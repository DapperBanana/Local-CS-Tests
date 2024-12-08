
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Calculator!");

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
