using System;
using System.Collections.Generic;

class MazeGeneratorAndSolver
{
    static int width = 20;  // number of columns
    static int height = 10; // number of rows
    static char[,] maze;
    static bool[,] visited;

    static Random rand = new Random();

    static void Main()
    {
        maze = new char[height * 2 + 1, width * 2 + 1];
        visited = new bool[height * 2 + 1, width * 2 + 1];

        InitializeMaze();
        GenerateMaze(1, 1);
        AddEntranceAndExit();

        Console.WriteLine("Generated Maze:");
        PrintMaze();

        var path = FindPath(1, 1, height * 2 - 1, width * 2 - 1);
        if (path != null)
        {
            foreach (var cell in path)
            {
                maze[cell.Item1, cell.Item2] = '*';  // Mark solution path
            }
            Console.WriteLine("\nMaze Solution:");
            PrintMaze();
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static void InitializeMaze()
    {
        for (int r = 0; r < maze.GetLength(0); r++)
        {
            for (int c = 0; c < maze.GetLength(1); c++)
            {
                maze[r, c] = '#';
            }
        }
    }

    static void GenerateMaze(int r, int c)
    {
        visited[r, c] = true;
        maze[r, c] = ' ';

        var directions = new List<(int dr, int dc)> { (0, 2), (0, -2), (2, 0), (-2, 0) };
        Shuffle(directions);

        foreach (var (dr, dc) in directions)
        {
            int nr = r + dr;
            int nc = c + dc;
            if (IsInBounds(nr, nc) && !visited[nr, nc])
            {
                maze[r + dr / 2, c + dc / 2] = ' ';
                GenerateMaze(nr, nc);
            }
        }
    }

    static void AddEntranceAndExit()
    {
        maze[1, 0] = ' '; // Entrance
        maze[maze.GetLength(0) - 2, maze.GetLength(1) - 1] = ' '; // Exit
    }

    static bool IsInBounds(int r, int c)
    {
        return r > 0 && c > 0 && r < maze.GetLength(0) - 1 && c < maze.GetLength(1) - 1;
    }

    static void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    static void PrintMaze()
    {
        for (int r = 0; r < maze.GetLength(0); r++)
        {
            for (int c = 0; c < maze.GetLength(1); c++)
            {
                Console.Write(maze[r, c]);
            }
            Console.WriteLine();
        }
    }

    static List<(int, int)> FindPath(int startR, int startC, int endR, int endC)
    {
        var cameFrom = new Dictionary<(int, int), (int, int)>();
        var visitedPath = new bool[maze.GetLength(0), maze.GetLength(1)];
        var queue = new Queue<(int, int)>();
        queue.Enqueue((startR, startC));
        visitedPath[startR, startC] = true;

        var directions = new List<(int dr, int dc)> { (0, 1), (1, 0), (0, -1), (-1, 0) };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current.Item1 == endR && current.Item2 == endC)
            {
                // Reconstruct path
                var path = new List<(int, int)>();
                while (current != (startR, startC))
                {
                    path.Add(current);
                    current = cameFrom[current];
                }
                path.Add((startR, startC));
                path.Reverse();
                return path;
            }

            foreach (var (dr, dc) in directions)
            {
                int nr = current.Item1 + dr;
                int nc = current.Item2 + dc;
                if (IsInBounds(nr, nc) && !visitedPath[nr, nc] && maze[nr, nc] == ' ')
                {
                    visitedPath[nr, nc] = true;
                    cameFrom[(nr, nc)] = current;
                    queue.Enqueue((nr, nc));
                }
            }
        }
        return null;
    }
}