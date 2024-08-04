
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    // Add an edge to the graph
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    // Find the shortest path using BFS
    public void ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] distance = new int[V];
        int[] parent = new int[V];

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            distance[i] = int.MaxValue;
            parent[i] = -1;
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        distance[start] = 0;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
                    distance[neighbor] = distance[current] + 1;
                    parent[neighbor] = current;
                }
            }
        }

        if (visited[end])
        {
            Console.WriteLine("Shortest Path from " + start + " to " + end + ":");
            int current = end;
            while (parent[current] != -1)
            {
                Console.Write(current + " ");
                current = parent[current];
            }
            Console.WriteLine(start);
            Console.WriteLine("Shortest Path length: " + distance[end]);
        }
        else
        {
            Console.WriteLine("No path exists from " + start + " to " + end);
        }
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);
        graph.AddEdge(4, 5);

        graph.ShortestPath(0, 5);
    }
}
