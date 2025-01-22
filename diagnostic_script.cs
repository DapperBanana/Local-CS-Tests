
using System;

class OrthogonalMatrixChecker
{
    static bool IsOrthogonalMatrix(int[,] matrix)
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
                for (int k = 0; k < rows; k++)
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

    static void Main()
    {
        int[,] matrix = {
            {1, 0, 0},
            {0, 0, 1},
            {0, -1, 0}
        };

        bool isOrthogonal = IsOrthogonalMatrix(matrix);

        if (isOrthogonal)
        {
            Console.WriteLine("Given matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("Given matrix is not orthogonal.");
        }
    }
}
