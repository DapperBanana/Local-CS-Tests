
using System;

class Program
{
    static void Main()
    {
        // Two lists of numbers
        double[] numbers1 = { 2, 4, 6, 8, 10 };
        double[] numbers2 = { 3, 6, 9, 12, 15 };

        // Calculate the mean of the numbers
        double mean1 = CalculateMean(numbers1);
        double mean2 = CalculateMean(numbers2);

        // Calculate the correlation coefficient
        double correlationCoefficient = CalculateCorrelationCoefficient(numbers1, numbers2, mean1, mean2);

        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateMean(double[] numbers)
    {
        double sum = 0;

        foreach (double number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

    static double CalculateCorrelationCoefficient(double[] numbers1, double[] numbers2, double mean1, double mean2)
    {
        double sum = 0;
        double sumX = 0;
        double sumY = 0;

        for (int i = 0; i < numbers1.Length; i++)
        {
            sum += (numbers1[i] - mean1) * (numbers2[i] - mean2);
            sumX += Math.Pow(numbers1[i] - mean1, 2);
            sumY += Math.Pow(numbers2[i] - mean2, 2);
        }

        return sum / Math.Sqrt(sumX * sumY);
    }
}
