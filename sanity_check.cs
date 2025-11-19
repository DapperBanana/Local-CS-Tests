
using System;

class MatrixInvertibilityChecker
{
    static bool IsInvertible(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1))
        {
            return false;  // Matrix must be square to be invertible.
        }

        double det = Determinant(matrix);

        return det != 0;
    }

    static double Determinant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        double det = 0;
        double sign = 1;

        for (int i = 0; i < n; i++)
        {
            double[,] submatrix = new double[n - 1, n - 1];

            for (int row = 1; row < n; row++)
            {
                int submatrixCol = 0;
                for (int col = 0; col < n; col++)
                {
                    if (col != i)
                    {
                        submatrix[row - 1, submatrixCol] = matrix[row, col];
                        submatrixCol++;
                    }
                }
            }

            det += sign * matrix[0, i] * Determinant(submatrix);
            sign = -sign;
        }

        return det;
    }

    static void Main()
    {
        double[,] matrix = { { 2, 3, 1 },
                              { 0, 2, 4 },
                              { 3, 1, 2 } };

        if (IsInvertible(matrix))
        {
            Console.WriteLine("Given matrix is invertible.");
        }
        else
        {
            Console.WriteLine("Given matrix is not invertible.");
        }
    }
}
