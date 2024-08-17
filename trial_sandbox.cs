
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 },
                          { 4, 5, 6 },
                          { 7, 8, 9 } };

        if(IsInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    static bool IsInvertible(int[,] matrix)
    {
        if(matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false; // Only square matrices can be invertible
        }

        double determinant = GetDeterminant(matrix);

        return determinant != 0;
    }

    static double GetDeterminant(int[,] matrix)
    {
        // Assuming a 3x3 matrix for simplicity
        double determinant = 0;

        determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                    - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                    + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        return determinant;
    }
}
