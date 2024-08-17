
using System;
using System.Collections.Generic;

class MazeSolver
{
    static char[,] maze = {
        {'#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
        {'#', '#', '#', ' ', '#', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', '#', '#', '#'},
        {'#', ' ', '#', '#', ' ', '#', ' ', '#'},
        {'#', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static int[,] directions = {
        {-1, 0}, // Up
        {1, 0}, // Down
        {0, -1}, // Left
        {0, 1} // Right
    };

    static Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();

    static void Main()
    {
        Tuple<int, int> start = FindStart();
        SolveMaze(start.Item1, start.Item2);
    }

    static Tuple<int, int> FindStart()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                if (maze[i, j] == ' ')
                {
                    return Tuple.Create(i, j);
                }
            }
        }
        return Tuple.Create(-1, -1);
    }

    static void SolveMaze(int row, int col)
    {
        path.Push(Tuple.Create(row, col));

        while (true)
        {
            if (maze[row, col] == ' ')
            {
                maze[row, col] = 'X'; // Mark path
            }
            
            if (maze[row, col] == '#') // Hit a wall
            {
                path.Pop();
                maze[row, col] = ' ';
            }

            if (row == 0 || row == maze.GetLength(0) - 1 || col == 0 || col == maze.GetLength(1) - 1) // Reach the end
            {
                break;
            }

            bool moved = false;
            foreach (var direction in directions)
            {
                int newRow = row + direction[0];
                int newCol = col + direction[1];
                if (maze[newRow, newCol] == ' ')
                {
                    row = newRow;
                    col = newCol;
                    moved = true;
                    break;
                }
            }

            if (!moved)
            {
                path.Pop();
                if (path.Count == 0)
                {
                    Console.WriteLine("No path found.");
                    break;
                }
                var lastPos = path.Peek();
                row = lastPos.Item1;
                col = lastPos.Item2;
            }
        }

        PrintMaze();
    }

    static void PrintMaze()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
    }
}
