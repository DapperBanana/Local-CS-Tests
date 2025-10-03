
using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Enter the size of the square matrix: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        double[,] matrix = new double[n, n];
        
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double determinant = CalculateDeterminant(matrix);
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        int n = (int)Math.Sqrt(matrix.Length);
        
        if (n == 1)
        {
            return matrix[0, 0];
        }

        double det = 0;
        
        for (int i = 0; i < n; i++)
        {
            det += matrix[0, i] * CoFactor(matrix, 0, i) * Math.Pow(-1, i);
        }

        return det;
    }

    static double[,] SubMatrix(double[,] matrix, int row, int col)
    {
        int n = (int)Math.Sqrt(matrix.Length);
        double[,] subMatrix = new double[n - 1, n - 1];

        for (int i = 0, k = 0; i < n; i++)
        {
            if (i == row)
            {
                continue;
            }

            for (int j = 0, l = 0; j < n; j++)
            {
                if (j == col)
                {
                    continue;
                }

                subMatrix[k, l] = matrix[i, j];
                l++;
            }

            k++;
        }

        return subMatrix;
    }

    static double CoFactor(double[,] matrix, int row, int col)
    {
        double[,] subMatrix = SubMatrix(matrix, row, col);
        return Math.Pow(-1, row + col) * CalculateDeterminant(subMatrix);
    }
}
