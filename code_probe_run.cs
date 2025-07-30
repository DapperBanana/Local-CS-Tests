
using System;

class MatrixInvertibility
{
    static bool IsMatrixInvertible(int[,] matrix)
    {
        int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        return determinant != 0;
    }

    static void Main()
    {
        int[,] matrix = {
            {1, 2},
            {3, 4}
        };

        if (IsMatrixInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }
}
