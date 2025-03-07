
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;

        Console.WriteLine("Welcome to the Basic Calculator");
        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case 4:
                if(num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else 
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
