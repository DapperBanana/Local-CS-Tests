using System;
using System.Collections.Generic;

class MazeSolver
{
    static char[,] maze = {
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', ' ', '#', ' ', '#', ' ', '#', ' ', '#'},
        {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
        {'#', ' ', '#', '#', '#', ' ', '#', ' ', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', '#', '#', ' ', '#', '#', '#', ' ', '#'},
        {'#', 'S', ' ', ' ', ' ', ' ', ' ', 'E', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static int rows = maze.GetLength(0);
    static int cols = maze.GetLength(1);
    static bool[,] visited = new bool[rows, cols];

    static (int, int) start;
    static (int, int) end;

    static void Main()
    {
        // Find start (S) and end (E) positions
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (maze[i, j] == 'S')
                    start = (i, j);
                if (maze[i, j] == 'E')
                    end = (i, j);
            }
        }

        List<(int, int)> path = new List<(int, int)>();
        if (SolveMaze(start.Item1, start.Item2, path))
        {
            Console.WriteLine("Path found:");
            foreach (var step in path)
            {
                Console.WriteLine($"({step.Item1}, {step.Item2})");
            }
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }

    static bool SolveMaze(int row, int col, List<(int, int)> path)
    {
        // Out of bounds or wall or visited
        if (row < 0 || col < 0 || row >= rows || col >= cols)
            return false;
        if (maze[row, col] == '#' || visited[row, col])
            return false;

        // Mark current cell as visited
        visited[row, col] = true;
        path.Add((row, col));

        // Check if end found
        if (row == end.Item1 && col == end.Item2)
            return true;

        // Explore neighbors: Up, Right, Down, Left
        int[] dRow = { -1, 0, 1, 0 };
        int[] dCol = { 0, 1, 0, -1 };

        for (int dir = 0; dir < 4; dir++)
        {
            int newRow = row + dRow[dir];
            int newCol = col + dCol[dir];

            if (SolveMaze(newRow, newCol, path))
                return true;
        }

        // Backtrack
        path.RemoveAt(path.Count - 1);
        return false;
    }
}