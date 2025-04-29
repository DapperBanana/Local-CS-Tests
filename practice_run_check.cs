
using System;

class Program
{
    static bool IsSymmetric(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                    return false;
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {2, 4, 5},
            {3, 5, 6}
        };

        if (IsSymmetric(matrix))
        {
            Console.WriteLine("The matrix is symmetric.");
        }
        else
        {
            Console.WriteLine("The matrix is not symmetric.");
        }
    }
}
