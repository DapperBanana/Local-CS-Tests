
using System;

class OrthogonalMatrixChecker
{
    public static bool IsOrthogonalMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
            return false;

        // Check if rows are orthogonal
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                if (DotProduct(matrix, i, j) != 0)
                    return false;
            }
        }

        return true;
    }

    private static int DotProduct(int[,] matrix, int row1, int row2)
    {
        int result = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            result += matrix[row1, i] * matrix[row2, i];
        }
        return result;
    }

    static void Main()
    {
        int[,] matrix = new int[,]
        {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        bool isOrthogonal = IsOrthogonalMatrix(matrix);

        if (isOrthogonal)
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }
}
