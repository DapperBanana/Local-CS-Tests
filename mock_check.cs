
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int source, int destination)
    {
        bool[] visited = new bool[V];
        int[] distance = new int[V];
        int[] parent = new int[V];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(source);
        visited[source] = true;
        distance[source] = 0;
        parent[source] = -1;

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();

            foreach (int v in adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue(v);
                    distance[v] = distance[u] + 1;
                    parent[v] = u;
                }
            }
        }

        if (!visited[destination])
        {
            Console.WriteLine("No path exists from source to destination.");
        }
        else
        {
            Console.WriteLine("Shortest path from source to destination:");
            PrintPath(parent, destination);
        }
    }

    private void PrintPath(int[] parent, int destination)
    {
        if (destination == -1)
        {
            return;
        }

        PrintPath(parent, parent[destination]);
        Console.Write(destination + " ");
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(7);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 5);
        g.AddEdge(2, 6);

        int source = 0;
        int destination = 6;

        g.BFS(source, destination);
    }
}
