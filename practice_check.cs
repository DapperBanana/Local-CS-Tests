
using System;
using System.Collections.Generic;

class MazeSolver
{
    private char[,] maze;
    private int[,] directions = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
    private int rows, cols;

    public MazeSolver(char[,] maze)
    {
        this.maze = maze;
        this.rows = maze.GetLength(0);
        this.cols = maze.GetLength(1);
    }

    public void SolveMaze(int startX, int startY)
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(startX, startY));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (maze[x, y] == 'E')
            {
                Console.WriteLine("Maze solved!");
                return;
            }

            maze[x, y] = 'V'; // mark as visited

            for (int i = 0; i < directions.GetLength(0); i++)
            {
                int newX = x + directions[i, 0];
                int newY = y + directions[i, 1];

                if (IsSafe(newX, newY))
                {
                    stack.Push(new Tuple<int, int>(newX, newY));
                }
            }
        }

        Console.WriteLine("No solution found.");
    }

    private bool IsSafe(int x, int y)
    {
        return x >= 0 && x < rows && y >= 0 && y < cols && (maze[x, y] == ' ' || maze[x, y] == 'E');
    }
}

class Program
{
    static void Main()
    {
        char[,] maze = {
            {'S', ' ', 'X', 'X', 'X'},
            {'X', ' ', 'X', 'X', 'X'},
            {'X', ' ', 'X', 'E', 'X'},
            {'X', ' ', 'X', 'X', 'X'},
            {'X', ' ', 'X', 'X', 'X'}
        };
        
        MazeSolver solver = new MazeSolver(maze);
        solver.SolveMaze(0, 0);
    }
}
