
using System;

class Program
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
        { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#' },
        { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', ' ', '#', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int startRow = 1;
    static int startCol = 1;
    static int endRow = 5;
    static int endCol = 7;

    static bool SolveMaze(int row, int col)
    {
        if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
        {
            return false;
        }

        if (maze[row, col] == '#')
        {
            return false;
        }

        if (maze[row, col] == 'X')
        {
            return false;
        }

        if (row == endRow && col == endCol)
        {
            return true;
        }

        maze[row, col] = 'X';

        if (SolveMaze(row, col + 1) || SolveMaze(row + 1, col) || SolveMaze(row, col - 1) || SolveMaze(row - 1, col))
        {
            return true;
        }

        maze[row, col] = ' ';
        return false;
    }

    static void Main()
    {
        if (SolveMaze(startRow, startCol))
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("Maze cannot be solved.");
        }

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
