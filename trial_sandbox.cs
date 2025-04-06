
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<Tuple<int, int>>[] adjList;

    public Graph(int vertices)
    {
        V = vertices;
        adjList = new List<Tuple<int, int>>[V];
        for (int i = 0; i < V; i++)
        {
            adjList[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int u, int v, int weight)
    {
        adjList[u].Add(new Tuple<int, int>(v, weight));
    }

    public int[] Dijkstra(int source)
    {
        int[] distance = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }

        distance[source] = 0;

        for (int i = 0; i < V - 1; i++)
        {
            int u = MinDistance(distance, visited);
            visited[u] = true;

            foreach (var edge in adjList[u])
            {
                int v = edge.Item1;
                int weight = edge.Item2;

                if (!visited[v] && distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                {
                    distance[v] = distance[u] + weight;
                }
            }
        }

        return distance;
    }

    private int MinDistance(int[] distance, bool[] visited)
    {
        int minDist = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < V; i++)
        {
            if (!visited[i] && distance[i] <= minDist)
            {
                minDist = distance[i];
                minIndex = i;
            }
        }

        return minIndex;
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6);

        graph.AddEdge(0, 1, 5);
        graph.AddEdge(0, 2, 10);
        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 3, 9);
        graph.AddEdge(2, 4, 1);
        graph.AddEdge(3, 4, 6);
        graph.AddEdge(3, 5, 2);
        graph.AddEdge(4, 5, 4);

        int[] distances = graph.Dijkstra(0);

        Console.WriteLine("Shortest distances from source 0:");
        for (int i = 0; i < distances.Length; i++)
        {
            Console.WriteLine("Vertex {0}: {1}", i, distances[i]);
        }
    }
}
