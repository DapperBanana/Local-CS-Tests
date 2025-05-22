
using System;

class OrthogonalMatrixChecker
{
    static void Main()
    {
        int[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        bool isOrthogonal = IsOrthogonal(matrix);

        if (isOrthogonal)
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }

    static bool IsOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != columns)
        {
            return false;
        }

        // Check if the transpose of the matrix is equal to its inverse
        int[,] transpose = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        int[,] result = MultiplyMatrices(matrix, transpose);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == j && result[i, j] != 1)
                {
                    return false;
                }

                if (i != j && result[i, j] != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int columns2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
