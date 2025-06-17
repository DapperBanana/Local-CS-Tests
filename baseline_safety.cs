
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int determinant = CalculateDeterminant(matrix);
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("The matrix must be square.");
        }

        if (matrix.GetLength(0) == 1)
        {
            return matrix[0, 0];
        }

        int determinant = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            determinant += matrix[0, i] * (int)Math.Pow(-1, i) * CalculateDeterminant(GetSubMatrix(matrix, 0, i));
        }

        return determinant;
    }

    static int[,] GetSubMatrix(int[,] matrix, int rowToRemove, int colToRemove)
    {
        int size = matrix.GetLength(0) - 1;
        int[,] subMatrix = new int[size, size];
        for (int i = 0, m = 0; i < matrix.GetLength(0); i++)
        {
            if (i == rowToRemove) continue;
            for (int j = 0, n = 0; j < matrix.GetLength(0); j++)
            {
                if (j == colToRemove) continue;
                subMatrix[m, n] = matrix[i, j];
                n++;
            }
            m++;
        }
        return subMatrix;
    }
}
