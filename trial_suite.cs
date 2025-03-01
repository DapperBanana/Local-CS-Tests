
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private static Random random = new Random();

    private static int[,] maze;
    private static int width;
    private static int height;

    public static void Main(string[] args)
    {
        width = 10;
        height = 10;
        maze = GenerateMaze(width, height);
        PrintMaze(width, height);

        List<int[]> solution = SolveMaze(maze, width, height);
        PrintSolution(solution);
    }

    private static int[,] GenerateMaze(int width, int height)
    {
        int[,] maze = new int[width, height];

        // Initialize maze with walls
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = random.Next(2); // 0 represents wall, 1 represents empty space
            }
        }

        // Generate random maze using Depth First Search algorithm

        return maze;
    }

    private static void PrintMaze(int width, int height)
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Console.Write(maze[i, j] == 0 ? "X" : " ");
            }
            Console.WriteLine();
        }
    }

    private static List<int[]> SolveMaze(int[,] maze, int width, int height)
    {
        // Solve maze using Breadth First Search algorithm

        return new List<int[]>();
    }

    private static void PrintSolution(List<int[]> solution)
    {
        foreach (int[] point in solution)
        {
            Console.WriteLine($"({point[0]}, {point[1]})");
        }
    }
}
