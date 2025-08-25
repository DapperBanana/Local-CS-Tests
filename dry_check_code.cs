
using System;

class Calculator
{
    static void Main()
    {
        int num1, num2;
        char operation;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /):");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                break;
            
            case '-':
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                break;
            
            case '*':
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                break;
            
            case '/':
                if(num2 != 0)
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            
            default:
                Console.WriteLine("Invalid operation entered.");
                break;
        }
    }
}
