
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result = 0;
        char operation;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
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
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation");
                break;
        }

        Console.WriteLine("Result: " + result);
    }
}
