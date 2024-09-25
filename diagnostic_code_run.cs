
using System;

class Program
{
    static void Main()
    {
        double[] x = { 1, 2, 3, 4, 5 }; // independent variable
        double[] y = { 2, 4, 5, 4, 5 }; // dependent variable
        
        // Calculate the mean of x and y
        double meanX = 0;
        double meanY = 0;
        
        for (int i = 0; i < x.Length; i++)
        {
            meanX += x[i];
            meanY += y[i];
        }
        
        meanX /= x.Length;
        meanY /= y.Length;
        
        // Calculate the numerator and denominator
        double numerator = 0;
        double denominator = 0;
        
        for (int i = 0; i < x.Length; i++)
        {
            numerator += (x[i] - meanX) * (y[i] - meanY);
            denominator += (x[i] - meanX) * (x[i] - meanX);
        }
        
        // Calculate the slope and intercept of the linear regression model
        double slope = numerator / denominator;
        double intercept = meanY - slope * meanX;
        
        Console.WriteLine("Slope: " + slope);
        Console.WriteLine("Intercept: " + intercept);
        
        // Predict the value of y for a new x
        double newX = 6;
        double newY = slope * newX + intercept;
        
        Console.WriteLine("Predicted value of y for x = " + newX + " is " + newY);
    }
}
