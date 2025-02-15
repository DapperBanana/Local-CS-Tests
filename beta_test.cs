
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 0},
            {0, -1}
        };

        bool isOrthogonal = IsMatrixOrthogonal(matrix);

        if (isOrthogonal)
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }

    static bool IsMatrixOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                int dotProduct = 0;
                for (int k = 0; k < cols; k++)
                {
                    dotProduct += matrix[i, k] * matrix[j, k];
                }

                if (dotProduct != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
