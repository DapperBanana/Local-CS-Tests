
using System;

class Program
{
    static double Determinant(double[,] matrix)
    {
        double det = 0;
        if (matrix.GetLength(0) == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[,] m = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (k < i)
                        {
                            m[j - 1, k] = matrix[j, k];
                        }
                        else if (k > i)
                        {
                            m[j - 1, k - 1] = matrix[j, k];
                        }
                    }
                }
                det += Math.Pow(-1, i) * matrix[0, i] * Determinant(m);
            }
        }
        return det;
    }

    static bool IsInvertible(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false;
        }
        double det = Determinant(matrix);
        return det != 0;
    }

    static void Main()
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };

        if (IsInvertible(matrix))
        {
            Console.WriteLine("Matrix is invertible");
        }
        else
        {
            Console.WriteLine("Matrix is not invertible");
        }
    }
}
