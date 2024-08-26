
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<Tuple<int, int>>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<Tuple<int, int>>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int u, int v, int w)
    {
        adj[u].Add(new Tuple<int, int>(v, w));
        adj[v].Add(new Tuple<int, int>(u, w));
    }

    public void Dijkstra(int src)
    {
        bool[] visited = new bool[V];
        int[] dist = new int[V];
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
        }
        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = FindMinDistance(dist, visited);
            visited[u] = true;

            foreach (var edge in adj[u])
            {
                int v = edge.Item1;
                int w = edge.Item2;

                if (!visited[v] && dist[u] != int.MaxValue && dist[u] + w < dist[v])
                {
                    dist[v] = dist[u] + w;
                }
            }
        }

        PrintSolution(dist);
    }

    private int FindMinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < V; i++)
        {
            if (!visited[i] && dist[i] <= min)
            {
                min = dist[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex \t\t Distance from Source");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t\t " + dist[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(9);
        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 7, 8);
        graph.AddEdge(1, 2, 8);
        graph.AddEdge(1, 7, 11);
        graph.AddEdge(2, 3, 7);
        graph.AddEdge(2, 8, 2);
        graph.AddEdge(2, 5, 4);
        graph.AddEdge(3, 4, 9);
        graph.AddEdge(3, 5, 14);
        graph.AddEdge(4, 5, 10);
        graph.AddEdge(5, 6, 2);
        graph.AddEdge(6, 7, 1);
        graph.AddEdge(6, 8, 6);
        graph.AddEdge(7, 8, 7);

        graph.Dijkstra(0);
    }
}
