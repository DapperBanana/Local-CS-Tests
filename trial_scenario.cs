
using System;

class Program
{
    static void Main()
    {
        double[,] matrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        Console.WriteLine(IsOrthogonal(matrix));
    }

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
}
