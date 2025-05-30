
using System;
using System.Collections.Generic;

class Program
{
    static char[,] maze = {
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', '#', '#', ' ', '#', ' ', '#', ' ', '#'},
        {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
        {'#', ' ', '#', '#', '#', '#', '#', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static bool IsInMaze(int x, int y)
    {
        return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1);
    }

    static bool IsPath(int x, int y)
    {
        if (!IsInMaze(x, y))
            return false;

        return maze[x, y] != '#';
    }

    static bool SolveMaze(int x, int y)
    {
        if (!IsInMaze(x, y))
            return false;

        if (maze[x, y] == ' ')
        {
            maze[x, y] = 'X';

            if (x == maze.GetLength(0) - 1 && y == maze.GetLength(1) - 1)
                return true;

            if (SolveMaze(x + 1, y) || SolveMaze(x, y + 1) || SolveMaze(x - 1, y) || SolveMaze(x, y - 1))
                return true;

            maze[x, y] = ' ';
        }

        return false;
    }

    static void Main(string[] args)
    {
        if (SolveMaze(1, 1))
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
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
