
using System;

class Program
{
    static bool IsOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
            return false;

        // Check if the columns are orthogonal to each other
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                double dotProduct = 0;
                for (int k = 0; k < rows; k++)
                {
                    dotProduct += matrix[k, i] * matrix[k, j];
                }
                if (dotProduct != 0)
                    return false;
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        if (IsOrthogonal(matrix))
        {
            Console.WriteLine("The given matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The given matrix is not orthogonal.");
        }
    }
}
