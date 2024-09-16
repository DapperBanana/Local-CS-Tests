
using System;

class MatrixInvertibilityChecker
{
    static void Main()
    {
        // Define the given matrix
        double[,] matrix = {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0},
            {7.0, 8.0, 9.0}
        };

        // Check if the matrix is square
        if (IsSquare(matrix))
        {
            // Check if the determinant of the matrix is nonzero
            double determinant = Determinant(matrix);
            if (determinant != 0)
            {
                Console.WriteLine("The matrix is invertible.");
            }
            else
            {
                Console.WriteLine("The matrix is not invertible.");
            }
        }
        else
        {
            Console.WriteLine("The matrix is not invertible as it is not square.");
        }
    }

    // Function to check if the matrix is square
    static bool IsSquare(double[,] matrix)
    {
        return matrix.GetLength(0) == matrix.GetLength(1);
    }

    // Function to calculate the determinant of a 2x2 matrix
    static double Determinant2x2(double[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Function to calculate the determinant of a matrix recursively
    static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2)
        {
            return Determinant2x2(matrix);
        }

        double det = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double sign = (i % 2 == 0) ? 1 : -1;
            double[,] subMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            int subI = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (j == i)
                    continue;
                for (int k = 1; k < matrix.GetLength(1); k++)
                {
                    subMatrix[subI, k - 1] = matrix[j, k];
                }
                subI++;
            }
            det += sign * matrix[i, 0] * Determinant(subMatrix);
        }
        return det;
    }
}
