
using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+ for addition, - for subtraction, * for multiplication, / for division):");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if(num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed");
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

    }
}
