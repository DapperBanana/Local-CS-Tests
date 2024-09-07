
using System;

class Program
{
    static double Determinant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double det = 0;

        if (n == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                double[,] submatrix = new double[n - 1, n - 1];
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (k < i)
                        {
                            submatrix[j - 1, k] = matrix[j, k];
                        }
                        else if (k > i)
                        {
                            submatrix[j - 1, k - 1] = matrix[j, k];
                        }
                    }
                }
                det += Math.Pow(-1, i) * matrix[0, i] * Determinant(submatrix);
            }
        }

        return det;
    }

    static void Main()
    {
        double[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double det = Determinant(matrix);

        Console.WriteLine($"Determinant of the matrix is: {det}");
    }
}
