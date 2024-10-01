
using System;
using System.Collections.Generic;

public class DijkstraShortestPath
{
    public static void Main()
    {
        int[,] graph = new int[,]
        {
            { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
        };

        int[] shortestDistances = Dijkstra(graph, 0);

        for (int i = 0; i < shortestDistances.Length; i++)
        {
            Console.WriteLine("Shortest distance from node 0 to node " + i + " is: " + shortestDistances[i]);
        }
    }

    public static int[] Dijkstra(int[,] graph, int startNode)
    {
        int n = graph.GetLength(0);
        int[] shortestDistances = new int[n];
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            shortestDistances[i] = int.MaxValue;
            visited[i] = false;
        }

        shortestDistances[startNode] = 0;

        for (int i = 0; i < n - 1; i++)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int j = 0; j < n; j++)
            {
                if (!visited[j] && shortestDistances[j] < minDistance)
                {
                    minDistance = shortestDistances[j];
                    minIndex = j;
                }
            }

            visited[minIndex] = true;

            for (int j = 0; j < n; j++)
            {
                if (!visited[j] && graph[minIndex, j] != 0 && shortestDistances[minIndex] + graph[minIndex, j] < shortestDistances[j])
                {
                    shortestDistances[j] = shortestDistances[minIndex] + graph[minIndex, j];
                }
            }
        }

        return shortestDistances;
    }
}
