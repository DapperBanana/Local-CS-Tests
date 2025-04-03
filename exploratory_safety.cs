
using System;

class Program
{
    static void Main()
    {
        // Square matrix
        int[,] matrix = 
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int determinant = CalculateDeterminant(matrix);
        Console.WriteLine("Determinant: " + determinant);
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int result = 0;

        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        for (int i = 0; i < n; i++)
        {
            int[,] subMatrix = new int[n - 1, n - 1];
            for (int j = 1; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k < i)
                    {
                        subMatrix[j - 1, k] = matrix[j, k];
                    }
                    else if (k > i)
                    {
                        subMatrix[j - 1, k - 1] = matrix[j, k];
                    }
                }
            }
            result += matrix[0, i] * (i % 2 == 0 ? 1 : -1) * CalculateDeterminant(subMatrix);
        }

        return result;
    }
}
