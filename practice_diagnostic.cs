
using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    private static int V = 9;

    private int FindMinDistance(int[] distance, bool[] shortestPathTreeSet)
    {
        int min = int.MaxValue;
        int minIndex = 0;

        for (int v = 0; v < V; v++)
        {
            if (!shortestPathTreeSet[v] && distance[v] <= min)
            {
                min = distance[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] distance)
    {
        Console.WriteLine("Vertex \t\t Distance from Source");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t\t " + distance[i]);
        }
    }

    private void Dijkstra(int[,] graph, int source)
    {
        int[] distance = new int[V];
        bool[] shortestPathTreeSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            distance[i] = int.MaxValue;
            shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = FindMinDistance(distance, shortestPathTreeSet);

            shortestPathTreeSet[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!shortestPathTreeSet[v] && graph[u, v] != 0 && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                {
                    distance[v] = distance[u] + graph[u, v];
                }
            }
        }

        PrintSolution(distance);
    }

    public static void Main(string[] args)
    {
        int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                    { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        
        DijkstraAlgorithm d = new DijkstraAlgorithm();
        d.Dijkstra(graph, 0);
    }
}
