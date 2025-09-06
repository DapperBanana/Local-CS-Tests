
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

    // Function to add an edge to the graph
    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    // Function to find the shortest path using BFS
    public void ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] distance = new int[V];
        int[] parent = new int[V];
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            distance[i] = int.MaxValue;
            parent[i] = -1;
        }

        visited[start] = true;
        distance[start] = 0;
        queue.Enqueue(start);

        while (queue.Count != 0)
        {
            int u = queue.Dequeue();
            foreach (int v in adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    distance[v] = distance[u] + 1;
                    parent[v] = u;
                    queue.Enqueue(v);
                }
            }
        }

        Console.Write("Shortest path from " + start + " to " + end + " is: ");
        PrintPath(start, end, parent);
    }

    // Function to print the path recursively
    private void PrintPath(int start, int end, int[] parent)
    {
        if (end == -1 || start == end)
        {
            Console.Write(end + " ");
            return;
        }
        PrintPath(start, parent[end], parent);
        Console.Write(end + " ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);

        int start = 0;
        int end = 5;

        graph.ShortestPath(start, end);
    }
}
