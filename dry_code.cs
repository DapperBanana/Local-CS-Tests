
using System;
using System.Collections.Generic;

class Program
{
    static char[,] maze = {
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', '#', '#', ' ', '#', ' ', '#', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static int startRow = 1;
    static int startCol = 1;

    static int endRow = 3;
    static int endCol = 7;

    static List<Tuple<int, int>> directions = new List<Tuple<int, int>>()
    {
        new Tuple<int, int>(-1, 0), // Up
        new Tuple<int, int>(1, 0), // Down
        new Tuple<int, int>(0, -1), // Left
        new Tuple<int, int>(0, 1) // Right
    };

    static void Main()
    {
        SolveMaze(startRow, startCol);
    }

    static void SolveMaze(int row, int col)
    {
        if (row == endRow && col == endCol)
        {
            PrintMaze();
            return;
        }

        maze[row, col] = '.';

        foreach (var dir in directions)
        {
            int newRow = row + dir.Item1;
            int newCol = col + dir.Item2;

            if (IsValidMove(newRow, newCol))
            {
                SolveMaze(newRow, newCol);
            }
        }

        maze[row, col] = ' ';
    }

    static bool IsValidMove(int row, int col)
    {
        if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1) || maze[row, col] != ' ')
        {
            return false;
        }

        return true;
    }

    static void PrintMaze()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
