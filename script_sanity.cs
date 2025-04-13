
using System;

public class Calculator
{
    public static void Main()
    {
        Console.WriteLine("Basic Calculator");
        
        while (true)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());
            
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
                    if(num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    continue;
            }
            
            Console.WriteLine("Result: {0}", result);
            
            Console.WriteLine("Do you want to perform another calculation? (y/n)");
            char choice = char.Parse(Console.ReadLine());
            
            if (choice == 'n')
            {
                break;
            }
        }
    }
}
