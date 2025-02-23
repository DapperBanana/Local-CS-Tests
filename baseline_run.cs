
using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter an operation (+, -, *, /) or 'q' to quit: ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == 'q')
            {
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

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
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
