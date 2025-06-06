
using System;

class MatrixDeterminantCalculator
{
    public static double CalculateDeterminant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        
        double determinant = 0;
        for (int i = 0; i < n; i++)
        {
            determinant += Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(GetSubMatrix(matrix, i));
        }

        return determinant;
    }

    public static double[,] GetSubMatrix(double[,] matrix, int colToRemove)
    {
        int n = matrix.GetLength(0);
        double[,] subMatrix = new double[n - 1, n - 1];
        int r = 0, c = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j != colToRemove)
                {
                    subMatrix[r, c++] = matrix[i, j];
                }
            }
            r++;
            c = 0;
        }
        return subMatrix;
    }

    public static void Main()
    {
        double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double determinant = CalculateDeterminant(matrix);
        Console.WriteLine($"Determinant of the matrix is: {determinant}");
    }
}
