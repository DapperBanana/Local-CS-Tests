using System;
using System.Collections.Generic;

class MazeGeneratorAndSolver
{
    static int width = 20;
    static int height = 10;
    static int[,] maze;
    static bool[,] visited;
    static Random rand = new Random();

    static void Main()
    {
        maze = new int[width, height];
        visited = new bool[width, height];

        GenerateMaze();
        Console.WriteLine("Generated Maze:");
        PrintMaze();

        // Reset visited for solving
        visited = new bool[width, height];

        var path = SolveMaze(1, 1);
        Console.WriteLine("\nMaze with solution path:");
        PrintMaze(path);
    }

    static void GenerateMaze()
    {
        // Initialize maze with walls (1)
        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
                maze[x, y] = 1;

        // Start carving from (1,1)
        CarvePassagesFrom(1, 1);
    }

    static void CarvePassagesFrom(int cx, int cy)
    {
        int[] dirsX = { 0, 0, -1, 1 };
        int[] dirsY = { -1, 1, 0, 0 };

        // Shuffle directions
        var directions = new List<int> { 0, 1, 2, 3 };
        Shuffle(directions);

        foreach (var direction in directions)
        {
            int nx = cx + dirsX[direction] * 2;
            int ny = cy + dirsY[direction] * 2;

            if (IsInBounds(nx, ny) && maze[nx, ny] == 1)
            {
                maze[cx + dirsX[direction], cy + dirsY[direction]] = 0;
                maze[nx, ny] = 0;
                CarvePassagesFrom(nx, ny);
            }
        }
    }

    static bool IsInBounds(int x, int y)
    {
        return x > 0 && x < width - 1 && y > 0 && y < height - 1;
    }

    static void Shuffle(List<int> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            int value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    static List<(int, int)> SolveMaze(int startX, int startY)
    {
        var path = new List<(int, int)>();
        if (DepthFirstSolve(startX, startY, path))
            return path;
        return null;
    }

    static bool DepthFirstSolve(int x, int y, List<(int, int)> path)
    {
        if (!IsInBounds(x, y) || maze[x, y] == 1 || visited[x, y])
            return false;

        visited[x, y] = true;
        path.Add((x, y));

        // Goal at bottom-right corner
        if (x == width - 2 && y == height - 2)
            return true;

        int[] dirsX = { 0, 0, -1, 1 };
        int[] dirsY = { -1, 1, 0, 0 };

        for (int i = 0; i < 4; i++)
        {
            int nx = x + dirsX[i];
            int ny = y + dirsY[i];
            if (DepthFirstSolve(nx, ny, path))
                return true;
        }

        // Backtrack
        path.RemoveAt(path.Count - 1);
        return false;
    }

    static void PrintMaze()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(maze[x, y] == 1 ? "#" : " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintMaze(List<(int, int)> path)
    {
        var mazeWithPath = new char[width, height];

        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
                mazeWithPath[x, y] = maze[x, y] == 1 ? '#' : ' ';

        if (path != null)
        {
            foreach (var (x, y) in path)
            {
                mazeWithPath[x, y] = '.';
            }
        }

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(mazeWithPath[x, y]);
            }
            Console.WriteLine();
        }
    }
}