
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
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
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}
