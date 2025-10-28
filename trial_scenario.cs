
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char op;

        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                if(num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                }
                else
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
