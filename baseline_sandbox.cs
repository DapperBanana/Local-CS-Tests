
using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Basic Calculator");

        while (true)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Available operations:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.WriteLine("Choose an operation:");
            int choice = Convert.ToInt32(Console.ReadLine());

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
                    break;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            string anotherCalculation = Console.ReadLine();

            if (anotherCalculation.ToUpper() != "Y")
            {
                break;
            }
        }
    }
}
