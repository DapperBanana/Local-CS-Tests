
using System;

class Program
{
    static bool IsOrthogonal(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is square
        if (rows != cols)
        {
            return false;
        }

        // Check if matrix is orthogonal
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double dotProduct = 0;

                for (int k = 0; k < rows; k++)
                {
                    dotProduct += matrix[i, k] * matrix[j, k];
                }

                if (i == j && Math.Abs(dotProduct - 1) > 0.0001)
                {
                    return false;
                }
                else if (i != j && Math.Abs(dotProduct) > 0.0001)
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
            { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) },
            { -1 / Math.Sqrt(2), 1 / Math.Sqrt(2) }
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
