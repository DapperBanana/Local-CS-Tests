
using System;

class Calculator
{
    static void Main()
    {
        int num1, num2;
        char operation;
        
        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        switch(operation)
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
                if(num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation");
                break;
        }
    }
}
