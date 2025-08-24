
using System;

class MatrixInvertibilityChecker
{
    public static void Main()
    {
        int[][] matrix = {
            new int[] {1, 2},
            new int[] {3, 4}
        };

        Console.WriteLine("Matrix:");
        PrintMatrix(matrix);

        if (IsInvertible(matrix))
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    public static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    public static bool IsInvertible(int[][] matrix)
    {
        int det = matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        return det != 0;
    }
}
