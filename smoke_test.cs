
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char[,] maze = new char[,] {
            {'#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
            {'#', '#', '#', ' ', '#', ' ', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', ' ', '#', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#'}
        };

        if (SolveMaze(maze, 1, 1))
        {
            PrintMaze(maze);
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("No solution found");
        }
    }

    static bool SolveMaze(char[,] maze, int x, int y)
    {
        if (maze[x, y] == '#')
            return false;

        if (maze[x, y] == ' ')
            maze[x, y] = 'X';

        if (maze[x, y] == 'X')
        {
            if (x == maze.GetLength(0) - 2 && y == maze.GetLength(1) - 2)
                return true;

            if (SolveMaze(maze, x+1, y) || SolveMaze(maze, x-1, y) || SolveMaze(maze, x, y+1) || SolveMaze(maze, x, y-1))
                return true;

            maze[x, y] = ' ';
        }

        return false;
    }

    static void PrintMaze(char[,] maze)
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
