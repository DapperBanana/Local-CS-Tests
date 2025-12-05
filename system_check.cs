using System;
using System.Collections.Generic;

class Program
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
        { '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
        { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#' },
        { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', ' ', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int rows = maze.GetLength(0);
    static int cols = maze.GetLength(1);

    static (int, int) start = (1,1);
    static (int, int) end = (8,8);

    static List<(int, int)> path = new List<(int, int)>();
    static bool[,] visited = new bool[rows, cols];

    static void Main()
    {
        if (SolveMaze(start.Item1, start.Item2))
        {
            Console.WriteLine("Path found:");
            PrintMaze();
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }

    static bool SolveMaze(int x, int y)
    {
        if (x < 0 || y < 0 || x >= rows || y >= cols)
            return false;

        if (maze[x, y] == '#' || visited[x, y])
            return false;

        visited[x, y] = true;
        path.Add((x, y));

        if (x == end.Item1 && y == end.Item2)
            return true;

        // Explore neighbors: Up, Right, Down, Left
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        for (int dir = 0; dir < 4; dir++)
        {
            int newX = x + dx[dir];
            int newY = y + dy[dir];

            if (SolveMaze(newX, newY))
                return true;
        }

        // Backtrack
        path.RemoveAt(path.Count - 1);
        return false;
    }

    static void PrintMaze()
    {
        char[,] mazeCopy = (char[,])maze.Clone();

        foreach (var (x, y) in path)
        {
            if ((x, y) != start && (x, y) != end)
                mazeCopy[x, y] = '.';
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mazeCopy[i, j]);
            }
            Console.WriteLine();
        }
    }
}