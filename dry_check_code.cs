
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {{1, 0, 0},
                        {0, 1, 0},
                        {0, 0, 1}};

        bool isOrthogonal = IsOrthogonal(matrix);

        Console.WriteLine("Is matrix orthogonal: " + isOrthogonal);
    }

    static bool IsOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            return false;
        }

        // Check if the transpose of the matrix is equal to its inverse
        int[,] transpose = new int[rows, cols];
        int[,] inverse = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                inverse[i, j] = matrix[j, i];
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (transpose[i, j] != inverse[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
