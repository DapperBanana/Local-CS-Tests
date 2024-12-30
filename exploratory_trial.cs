
using System;

class Program
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
            for (int j = 0; j < cols; j++)
            {
                int dotProduct = 0;
                for (int k = 0; k < cols; k++)
                {
                    dotProduct += matrix[i, k] * matrix[k, j];
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
        int[,] matrix = { { 1, 0, 0 },
                          { 0, 1, 0 },
                          { 0, 0, 1 } };

        if (IsOrthogonalMatrix(matrix))
        {
            Console.WriteLine("The given matrix is orthogonal.");
        }
        else
        {
            Console.WriteLine("The given matrix is not orthogonal.");
        }
    }
}
