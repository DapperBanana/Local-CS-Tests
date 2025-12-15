using System;

class MatrixDeterminant
{
    public static void Main()
    {
        // Example matrix (3x3)
        double[,] matrix = {
            { 4, 3, 2 },
            { 3, 2, 1 },
            { 2, 1, 3 }
        };

        int n = matrix.GetLength(0);

        if (n != matrix.GetLength(1))
        {
            Console.WriteLine("Matrix must be square.");
            return;
        }

        double det = CalculateDeterminant(matrix);
        Console.WriteLine($"Determinant: {det}");
    }

    public static double CalculateDeterminant(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double[,] temp = (double[,])matrix.Clone();
        double determinant = 1;

        for (int i = 0; i < n; i++)
        {
            // Search for maximum in this column
            int maxRow = i;
            for (int k = i + 1; k < n; k++)
            {
                if (Math.Abs(temp[k, i]) > Math.Abs(temp[maxRow, i]))
                {
                    maxRow = k;
                }
            }

            // If pivot element is zero, determinant is zero
            if (Math.Abs(temp[maxRow, i]) < 1e-10)
                return 0;

            // Swap the maximum row with current row (if needed)
            if (maxRow != i)
            {
                SwapRows(temp, i, maxRow);
                determinant = -determinant;
            }

            // Multiply determinant by pivot element
            determinant *= temp[i, i];

            // Eliminate below
            for (int k = i + 1; k < n; k++)
            {
                double factor = temp[k, i] / temp[i, i];
                for (int j = i; j < n; j++)
                {
                    temp[k, j] -= factor * temp[i, j];
                }
            }
        }

        return determinant;
    }

    private static void SwapRows(double[,] matrix, int row1, int row2)
    {
        int n = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            double temp = matrix[row1, i];
            matrix[row1, i] = matrix[row2, i];
            matrix[row2, i] = temp;
        }
    }
}