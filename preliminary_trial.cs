
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int determinant = CalculateDeterminant(matrix);
        
        Console.WriteLine($"The determinant of the matrix is: {determinant}");
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("Matrix is not square.");
        }

        if (matrix.GetLength(0) == 1)
        {
            return matrix[0, 0];
        }

        int det = 0;
        int sign = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[,] subMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            
            for (int j = 1; j < matrix.GetLength(0); j++)
            {
                for (int k = 0, l = 0; k < matrix.GetLength(1); k++)
                {
                    if (k == i)
                    {
                        continue;
                    }
                    subMatrix[j - 1, l] = matrix[j, k];
                    l++;
                }
            }

            det += sign * matrix[0, i] * CalculateDeterminant(subMatrix);
            
            sign = -sign;
        }

        return det;
    }
}
