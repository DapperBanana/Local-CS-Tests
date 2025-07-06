
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /):");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

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
                    Console.WriteLine("Division by zero is not allowed");
                }
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        Console.WriteLine("Result: " + result);
    }
}
