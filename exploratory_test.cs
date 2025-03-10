
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static char[,] maze = new char[rows, cols];
    static bool[,] visited = new bool[rows, cols];
    static int startRow = 0;
    static int startCol = 0;
    static int endRow = rows - 1;
    static int endCol = cols - 1;
    static Random rand = new Random();
    static int[] dx = { 0, 0, -1, 1 };
    static int[] dy = { -1, 1, 0, 0 };

    static void Main()
    {
        GenerateMaze();
        PrintMaze();
        Console.WriteLine();

        SolveMaze(startRow, startCol);

        Console.WriteLine();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2) == 0 ? '#' : ' ';
                visited[i, j] = false;
            }
        }
        maze[startRow, startCol] = 'S';
        maze[endRow, endCol] = 'E';
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsValidMove(int x, int y)
    {
        return x >= 0 && x < rows && y >= 0 && y < cols && !visited[x,y] && maze[x,y] != '#';
    }

    static void SolveMaze(int row, int col)
    {
        if (row == endRow && col == endCol)
        {
            return;
        }

        visited[row, col] = true;

        for (int i = 0; i < 4; i++)
        {
            int nextRow = row + dx[i];
            int nextCol = col + dy[i];

            if (IsValidMove(nextRow, nextCol))
            {
                SolveMaze(nextRow, nextCol);
            }
        }

        if (row != startRow || col != startCol)
        {
            maze[row, col] = '.';
        }
    }
}
