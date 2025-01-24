
using System;

class Program
{
    static void Main()
    {
        // Define a square matrix
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Check if the matrix is invertible
        bool isInvertible = IsInvertible(matrix);

        if (isInvertible)
        {
            Console.WriteLine("The matrix is invertible.");
        }
        else
        {
            Console.WriteLine("The matrix is not invertible.");
        }
    }

    static bool IsInvertible(int[,] matrix)
    {
        // Get the determinant of the matrix
        int determinant = GetDeterminant(matrix);

        // Check if the determinant is non-zero
        return determinant != 0;
    }

    static int GetDeterminant(int[,] matrix)
    {
        // Check if the matrix is 2x2
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        // Calculate the determinant using cofactor expansion
        int determinant = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            determinant += matrix[0, i] * GetCofactor(matrix, 0, i);
        }
        
        return determinant;
    }

    static int GetCofactor(int[,] matrix, int row, int col)
    {
        int cofactorSign = (row + col) % 2 == 0 ? 1 : -1;
        int[,] subMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int subMatrixRow = 0;
        int subMatrixCol = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i != row && j != col)
                {
                    subMatrix[subMatrixRow, subMatrixCol] = matrix[i, j];
                    subMatrixCol++;
                    if (subMatrixCol == subMatrix.GetLength(1))
                    {
                        subMatrixRow++;
                        subMatrixCol = 0;
                    }
                }
            }
        }

        return cofactorSign * GetDeterminant(subMatrix);
    }
}
