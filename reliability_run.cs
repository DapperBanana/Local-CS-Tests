
using System;
using System.IO;

class MazeSolver
{
    static char[,] maze;
    static int startRow, startCol;
    static int endRow, endCol;

    static void Main()
    {
        LoadMaze("maze.txt");
        PrintMaze();
        SolveMaze(startRow, startCol);
        PrintMaze();
    }

    static void LoadMaze(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        maze = new char[lines.Length, lines[0].Length];

        for (int row = 0; row < lines.Length; row++)
        {
            for (int col = 0; col < lines[0].Length; col++)
            {
                maze[row, col] = lines[row][col];

                if (maze[row, col] == 'S')
                {
                    startRow = row;
                    startCol = col;
                }
                else if (maze[row, col] == 'E')
                {
                    endRow = row;
                    endCol = col;
                }
            }
        }
    }

    static void PrintMaze()
    {
        for (int row = 0; row < maze.GetLength(0); row++)
        {
            for (int col = 0; col < maze.GetLength(1); col++)
            {
                Console.Write(maze[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool SolveMaze(int row, int col)
    {
        if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1) || maze[row, col] == '#')
        {
            return false;
        }

        if (maze[row, col] == 'E')
        {
            return true;
        }

        if (maze[row, col] == ' ' || maze[row, col] == 'S')
        {
            maze[row, col] = '.';

            if (SolveMaze(row + 1, col) || SolveMaze(row - 1, col) || SolveMaze(row, col + 1) || SolveMaze(row, col - 1))
            {
                return true;
            }

            maze[row, col] = ' ';
        }

        return false;
    }
}
