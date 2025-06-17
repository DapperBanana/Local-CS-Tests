
using System;

class MatrixDeterminantCalculator
{
    public static double CalculateDeterminant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double determinant = 0;

        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        for (int i = 0; i < n; i++)
        {
            double[,] subMatrix = new double[n - 1, n - 1];
            for (int j = 1; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k < i)
                    {
                        subMatrix[j - 1, k] = matrix[j, k];
                    }
                    else if (k > i)
                    {
                        subMatrix[j - 1, k - 1] = matrix[j, k];
                    }
                }
            }

            determinant += Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(subMatrix);
        }

        return determinant;
    }

    static void Main()
    {
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double determinant = CalculateDeterminant(matrix);

        Console.WriteLine("Determinant of the matrix:");
        Console.WriteLine(determinant);
    }
}
