
using System;

class Matrix
{
    public static bool IsOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    if (matrix[i, j] != 1)
                    {
                        return false;
                    }
                }
                else
                {
                    if (matrix[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 0, 0 },
            { 0, 1, 0 },
            { 0, 0, 1 }
        };

        if (IsOrthogonal(matrix))
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }
}
