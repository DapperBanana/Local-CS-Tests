
using System;
using System.Collections.Generic;

class Program
{
    static int width = 10;
    static int height = 10;
    static int[,] maze = new int[width, height];
    static bool[,] visited = new bool[width, height];

    static void Main()
    {
        GenerateMaze();
        PrintMaze();

        if (SolveMaze(0, 0))
        {
            Console.WriteLine("Maze solved!");
            PrintMaze();
        }
        else
        {
            Console.WriteLine("No solution found!");
        }
    }

    static void GenerateMaze()
    {
        Random rand = new Random();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = rand.Next(0, 2);
            }
        }
        maze[0, 0] = 2; // start point
        maze[width - 1, height - 1] = 3; // end point
    }

    static void PrintMaze()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool SolveMaze(int x, int y)
    {
        visited[x, y] = true;

        if (x == width - 1 && y == height - 1)
        {
            return true; // reached the end
        }

        // possible moves: up, down, left, right
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

        // shuffle directions
        List<int> directions = new List<int> { 0, 1, 2, 3 };
        directions.Sort((a, b) => rand.Next(3) - 1);

        foreach (int direction in directions)
        {
            int nx = x + dx[direction];
            int ny = y + dy[direction];

            if (nx >= 0 && nx < width && ny >= 0 && ny < height && maze[nx, ny] != 0 && !visited[nx, ny])
            {
                if (SolveMaze(nx, ny))
                {
                    maze[x, y] = 4; // path taken
                    return true;
                }
            }
        }

        return false;
    }
}
