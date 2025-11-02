
using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Calculator!");
            bool calculate = true;

            while (calculate)
            {
                Console.WriteLine("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operation (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
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
                            Console.WriteLine("Error: Division by zero!");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation entered.");
                        continue;
                }

                Console.WriteLine("Result: " + result);

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    calculate = false;
                }
            }
        }
    }
}
