
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

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public List<int> ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] parent = new int[V];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                // Reconstruct the path
                List<int> path = new List<int>();
                for (int i = end; i != start; i = parent[i])
                {
                    path.Add(i);
                }
                path.Add(start);
                path.Reverse();
                return path;
            }

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    parent[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        return null; // No path found
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
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 6);
        graph.AddEdge(5, 7);
        graph.AddEdge(6, 7);

        List<int> shortestPath = graph.ShortestPath(0, 7);
        if (shortestPath != null)
        {
            Console.WriteLine("Shortest path: " + string.Join(" -> ", shortestPath));
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }
}
