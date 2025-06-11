
using System;

class MatrixMultiplication
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };

        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return resultMatrix;
    }
}
