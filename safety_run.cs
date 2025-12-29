using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator Program");
        bool continueCalculation = true;

        while (continueCalculation)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result;

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
                            Console.WriteLine("Error: Cannot divide by zero.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please try again.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    continueCalculation = false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }

        Console.WriteLine("Thank you for using the calculator. Goodbye!");
    }
}