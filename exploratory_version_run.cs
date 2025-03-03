
using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string op;

            Console.WriteLine("Welcome to the Basic Calculator!");

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
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

            Console.WriteLine("Result: {0}", result);
        }
    }
}
