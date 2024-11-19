
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static char[,] maze = new char[rows, cols];
    static int[,] visited = new int[rows, cols];
    static Random rand = new Random();

    static void Main()
    {
        GenerateMaze();
        PrintMaze();

        Console.WriteLine("Solving maze using Depth-First Search...");
        SolveMaze(0, 0);
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2) == 0 ? '#' : '.';
                visited[i, j] = 0;
            }
        }

        maze[0, 0] = '.';
        maze[rows - 1, cols - 1] = '.';
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void SolveMaze(int row, int col)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols || maze[row, col] == '#' || visited[row, col] == 1)
            return;

        visited[row, col] = 1;

        if (row == rows - 1 && col == cols - 1)
        {
            maze[row, col] = '*';
            return;
        }

        // Randomize the order in which the directions are checked
        List<int[]> directions = new List<int[]>() {
            new int[] {1, 0},
            new int[] {0, 1},
            new int[] {-1, 0},
            new int[] {0, -1}
        };
        directions = Shuffle(directions);

        foreach (var direction in directions)
        {
            int newRow = row + direction[0];
            int newCol = col + direction[1];

            SolveMaze(newRow, newCol);

            if (maze[newRow, newCol] == '*')
            {
                maze[row, col] = '*';
                return;
            }
        }
    }

    static List<T> Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            T temp = list[j];
            list[j] = list[i];
            list[i] = temp;
        }

        return list;
    }
}
