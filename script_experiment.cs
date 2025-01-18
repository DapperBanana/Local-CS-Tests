
using System;

class Program
{
    static void Main()
    {
        // Input matrix size
        Console.Write("Enter the size of the square matrix: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Initialize the matrix
        double[,] matrix = new double[n, n];

        // Input the elements of the matrix
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter element [{0}, {1}]: ", i, j);
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Calculate the determinant of the matrix
        double determinant = CalculateDeterminant(matrix);
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        int n = (int)Math.Sqrt(matrix.Length);
        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        double det = 0;
        for (int i = 0; i < n; i++)
        {
            det += matrix[0, i] * GetMinor(matrix, 0, i) * Math.Pow(-1, i);
        }

        return det;
    }

    static double GetMinor(double[,] matrix, int x, int y)
    {
        int n = (int)Math.Sqrt(matrix.Length);
        double[,] minor = new double[n - 1, n - 1];
        int minorRow = 0, minorCol = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == x)
            {
                continue;
            }
            minorCol = 0;
            for (int j = 0; j < n; j++)
            {
                if (j == y)
                {
                    continue;
                }
                minor[minorRow, minorCol] = matrix[i, j];
                minorCol++;
            }
            minorRow++;
        }

        return CalculateDeterminant(minor);
    }
}
