
using System;

class OrthogonalMatrixChecker
{
    static bool IsOrthogonal(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            return false;
        }

        // Check if the matrix is orthogonal
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                int dotProduct = 0;
                for (int k = 0; k < cols; k++)
                {
                    dotProduct += matrix[i, k] * matrix[j, k];
                }
                if (i == j && dotProduct != 1)
                {
                    return false;
                }
                else if (i != j && dotProduct != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

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
