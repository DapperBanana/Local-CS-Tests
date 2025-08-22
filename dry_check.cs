
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // number of vertices
    private List<int>[] adj; // adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
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
        int[] parent = new int[V];
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            parent[i] = -1;
        }

        visited[source] = true;
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == destination)
            {
                PrintPath(parent, current);
                return;
            }

            foreach (int neighbour in adj[current])
            {
                if (!visited[neighbour])
                {
                    visited[neighbour] = true;
                    queue.Enqueue(neighbour);
                    parent[neighbour] = current;
                }
            }
        }

        Console.WriteLine("Path not found.");
    }

    private void PrintPath(int[] parent, int current)
    {
        if (parent[current] == -1)
        {
            Console.Write(current + " ");
            return;
        }

        PrintPath(parent, parent[current]);
        Console.Write(current + " ");
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(6);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);
        g.AddEdge(4, 5);

        Console.WriteLine("Shortest path from 0 to 5:");
        g.BFS(0, 5);
    }
}
