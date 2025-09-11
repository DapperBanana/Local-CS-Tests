
using System;

class Program
{
    static void Main()
    {
        char[,] maze = {
            {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
            {'#', '#', '#', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

        SolveMaze(maze, 1, 1);

        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
    }

    static bool SolveMaze(char[,] maze, int row, int col)
    {
        if (maze[row, col] == 'X')
            return false;

        if (maze[row, col] == '#')
            return false;

        if (maze[row, col] == ' ')
        {
            maze[row, col] = 'X';

            if (row == maze.GetLength(0) - 2 && col == maze.GetLength(1) - 2)
            {
                maze[row, col] = '!';
                return true;
            }

            if (SolveMaze(maze, row + 1, col) || SolveMaze(maze, row, col + 1) || SolveMaze(maze, row - 1, col) || SolveMaze(maze, row, col - 1))
            {
                maze[row, col] = '!';
                return true;
            }

            maze[row, col] = ' ';
            return false;
        }

        return false;
    }
}
