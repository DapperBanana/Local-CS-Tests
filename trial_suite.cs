
using System;
using System.Collections.Generic;

class MazeGenerator
{
    public int Rows { get; }
    public int Cols { get; }

    private bool[,] maze;
    private bool[,] visited;

    private Random random = new Random();

    public MazeGenerator(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;

        maze = new bool[Rows, Cols];
        visited = new bool[Rows, Cols];
    }

    public void GenerateMaze()
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            (int row, int col) = stack.Peek();
            visited[row, col] = true;

            List<(int, int)> neighbors = GetUnvisitedNeighbors(row, col);

            if (neighbors.Count == 0)
            {
                stack.Pop();
            }
            else
            {
                (int nextRow, int nextCol) = neighbors[random.Next(neighbors.Count)];

                maze[2 * nextRow + 1, 2 * nextCol + 1] = true;
                maze[row + nextRow + 1, col + nextCol + 1] = true;

                stack.Push((row + nextRow, col + nextCol));
            }
        }
    }

    private List<(int, int)> GetUnvisitedNeighbors(int row, int col)
    {
        List<(int, int)> neighbors = new List<(int, int)>();

        if (row > 0 && !visited[row - 1, col])
        {
            neighbors.Add((-1, 0));
        }
        if (row < Rows - 1 && !visited[row + 1, col])
        {
            neighbors.Add((1, 0));
        }
        if (col > 0 && !visited[row, col - 1])
        {
            neighbors.Add((0, -1));
        }
        if (col < Cols - 1 && !visited[row, col + 1])
        {
            neighbors.Add((0, 1));
        }

        return neighbors;
    }

    public void SolveMaze()
    {
        bool[,] visited = new bool[Rows, Cols];

        bool IsSafe(int row, int col)
        {
            return row >= 0 && row < Rows && col >= 0 && col < Cols && !maze[row, col];
        }

        if (!SolveMazeUtil(0, 0, visited, IsSafe))
        {
            Console.WriteLine("No solution found");
        }
    }

    private bool SolveMazeUtil(int row, int col, bool[,] visited, Func<int, int, bool> IsSafe)
    {
        if (row == Rows - 1 && col == Cols - 1)
        {
            visited[row, col] = true;
            PrintSolution(visited);
            return true;
        }

        if (IsSafe(row, col))
        {
            visited[row, col] = true;

            if (SolveMazeUtil(row + 1, col, visited, IsSafe))
            {
                return true;
            }
            if (SolveMazeUtil(row, col + 1, visited, IsSafe))
            {
                return true;
            }

            visited[row, col] = false;
            return false;
        }

        return false;
    }

    private void PrintSolution(bool[,] visited)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (visited[i, j])
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 5;

        MazeGenerator mazeGenerator = new MazeGenerator(rows, cols);
        mazeGenerator.GenerateMaze();
        mazeGenerator.SolveMaze();
    }
}
