
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Basic Calculator");
        
        while (true)
        {
            Console.WriteLine("Enter the operation you want to perform (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double result = 0;
            
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    continue;
            }
            
            Console.WriteLine($"Result: {result}");
            
            Console.WriteLine("Do you want to perform another operation? (Y/N)");
            char choice = Convert.ToChar(Console.ReadLine());
            
            if (char.ToUpper(choice) != 'Y')
            {
                break;
            }
        }
    }
}
