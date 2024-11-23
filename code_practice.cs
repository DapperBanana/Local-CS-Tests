
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 17, 24,  1,  8, 15 },
            { 23,  5,  7, 14, 16 },
            {  4,  6, 13, 20, 22 },
            { 10, 12, 19, 21,  3 },
            { 11, 18, 25,  2,  9 }
        };

        bool isMagicTorus = CheckMagicTorus(matrix);

        if (isMagicTorus)
        {
            Console.WriteLine("The matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic torus.");
        }
    }

    static bool CheckMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate the sum of the first row
        int magicSum = matrix.GetRow(0).Sum();

        // Check rows
        foreach (var row in matrix)
        {
            if (row.Sum() != magicSum)
            {
                return false;
            }
        }

        // Check columns
        foreach (var col in Enumerable.Range(0, n).Select(i => matrix.GetCol(i)))
        {
            if (col.Sum() != magicSum)
            {
                return false;
            }
        }

        return true;
    }
}

public static class Extensions
{
    public static int[] GetRow(this int[,] matrix, int row)
    {
        return Enumerable.Range(0, matrix.GetLength(1))
                         .Select(i => matrix[row, i])
                         .ToArray();
    }

    public static int[] GetCol(this int[,] matrix, int col)
    {
        return Enumerable.Range(0, matrix.GetLength(0))
                         .Select(i => matrix[i, col])
                         .ToArray();
    }
}
