
using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Basic Calculator");
        
        double number1, number2, result = 0;
        char operation;
        
        Console.Write("Enter first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());
        
        switch(operation)
        {
            case '+':
                result = number1 + number2;
                break;
                
            case '-':
                result = number1 - number2;
                break;
                
            case '*':
                result = number1 * number2;
                break;
                
            case '/':
                if (number2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                result = number1 / number2;
                break;
                
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
        
        Console.WriteLine("Result: {0}", result);
    }
}
