
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        char op = Convert.ToChar(Console.ReadLine());

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
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
