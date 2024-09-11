
using System;

class MainClass {
    static void Main() {
        int[,] matrix = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        bool isMagicSquare = IsMagicSquare(matrix);

        if (isMagicSquare) {
            Console.WriteLine("The given matrix is a magic square.");
        } else {
            Console.WriteLine("The given matrix is not a magic square.");
        }
    }

    static void PrintMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsMagicSquare(int[,] matrix) {
        int n = matrix.GetLength(0);
        int magicSum = n * (n * n + 1) / 2;

        // Check rows
        for (int i = 0; i < n; i++) {
            int rowSum = 0;
            for (int j = 0; j < n; j++) {
                rowSum += matrix[i, j];
            }
            if (rowSum != magicSum) {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < n; j++) {
            int colSum = 0;
            for (int i = 0; i < n; i++) {
                colSum += matrix[i, j];
            }
            if (colSum != magicSum) {
                return false;
            }
        }

        // Check diagonal from top-left to bottom-right
        int diag1Sum = 0;
        for (int i = 0; i < n; i++) {
            diag1Sum += matrix[i, i];
        }
        if (diag1Sum != magicSum) {
            return false;
        }

        // Check diagonal from top-right to bottom-left
        int diag2Sum = 0;
        for (int i = 0; i < n; i++) {
            diag2Sum += matrix[i, n - i - 1];
        }
        if (diag2Sum != magicSum) {
            return false;
        }

        return true;
    }
}
