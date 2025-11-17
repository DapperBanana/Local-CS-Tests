
using System;

class Program
{
    public static bool CheckForSymmetry(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false; // Not square matrix
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] testMatrix = {
            {1, 2, 3},
            {2, 4, 5},
            {3, 5, 6}
        };

        bool isSymmetric = CheckForSymmetry(testMatrix);

        if (isSymmetric)
        {
            Console.WriteLine("The matrix is symmetric.");
        }
        else
        {
            Console.WriteLine("The matrix is not symmetric.");
        }
    }
}
