
using System;

class MatrixOrthogonalChecker
{
    static bool IsOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                double dotProduct = 0;
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
        double[,] matrix = {
            {1, 0, 0},
            {0, 1, 0},
            {0, 0, 1}
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
