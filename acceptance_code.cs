
using System;

class MainClass {
    public static void Main (string[] args) {
        int number = 153; // Change this number to check different numbers

        if (IsNarcissisticNumber(number)) {
            Console.WriteLine($"{number} is a narcissistic number.");
        } else {
            Console.WriteLine($"{number} is not a narcissistic number.");
        }
    }

    public static bool IsNarcissisticNumber(int n) {
        int numDigits = n.ToString().Length;
        int sum = 0;
        int originalNumber = n;

        while (n > 0) {
            int digit = n % 10;
            sum += (int)Math.Pow(digit, numDigits);
            n /= 10;
        }

        return sum == originalNumber;
    }
}
