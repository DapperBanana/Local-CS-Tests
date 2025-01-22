
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Calculator!");

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Basic Calculator!");
                break;
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Enter the dividend: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the divisor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                        continue;
                    }

                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
