
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency List

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public void BFS(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] distance = new int[V];
        int[] parent = new int[V];

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < V; i++)
        {
            distance[i] = int.MaxValue;
        }

        visited[start] = true;
        distance[start] = 0;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    distance[neighbor] = distance[current] + 1;
                    parent[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        if (!visited[end])
        {
            Console.WriteLine("No path exists between start and end nodes.");
            return;
        }

        Console.WriteLine("Shortest path length: " + distance[end]);

        Console.Write("Shortest path: ");
        int currentVertex = end;
        while (currentVertex != start)
        {
            Console.Write(currentVertex + " ");
            currentVertex = parent[currentVertex];
        }
        Console.WriteLine(start);
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(8);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 2);
        graph.AddEdge(3, 4);
        graph.AddEdge(3, 7);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 6);
        graph.AddEdge(4, 7);
        graph.AddEdge(5, 6);
        graph.AddEdge(6, 7);

        int start = 0;
        int end = 7;

        graph.BFS(start, end);
    }
}
