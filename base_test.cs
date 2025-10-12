
using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter an operation (+, -, *, /) or 'q' to quit:");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == 'q')
            {
                break;
            }

            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: division by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Result: " + result + "\n");
        }
    }
}
