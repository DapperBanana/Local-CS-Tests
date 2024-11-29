
using System;

class MatrixOrthogonalChecker
{
    static bool IsMatrixOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        // Check if each column is orthogonal to every other column
        for (int i = 0; i < cols; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                double dotProduct = 0;
                for (int k = 0; k < rows; k++)
                {
                    dotProduct += matrix[k, i] * matrix[k, j];
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
        double[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
        };

        if (IsMatrixOrthogonal(matrix))
        {
            Console.WriteLine("The matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The matrix is not orthogonal.");
        }
    }
}
