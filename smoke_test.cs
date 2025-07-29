
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[,] matrix = {
            { 10, 3, 7 },
            { 5, 8, 2 },
            { 6, 13, 9 }
        };

        if (IsMagicTorus(matrix))
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }       
    }

    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;

        // Calculate the sum of the first row
        for (int i = 0; i < n; i++)
        {
            sum += matrix[0, i];
        }

        for (int i = 1; i < n; i++)
        {
            int currentSum = 0;

            // Check rows
            for (int j = 0; j < n; j++)
            {
                currentSum += matrix[i, j];
            }

            if (currentSum != sum)
            {
                return false;
            }

            currentSum = 0;

            // Check columns
            for (int j = 0; j < n; j++)
            {
                currentSum += matrix[j, i];
            }

            if (currentSum != sum)
            {
                return false;
            }
        }

        return true;
    }
}
