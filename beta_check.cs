
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int vertices)
    {
        V = vertices;
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

    public List<int> ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] prev = new int[V];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                break;
            }

            foreach (int neighbor in adj[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    prev[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        List<int> path = new List<int>();
        for (int at = end; at != start; at = prev[at])
        {
            if (at == 0)
            {
                return null; // No path exists
            }
            path.Add(at);
        }
        path.Add(start);
        path.Reverse();
        return path;
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
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        List<int> shortestPath = graph.ShortestPath(0, 5);

        if (shortestPath != null)
        {
            Console.WriteLine("Shortest path from 0 to 5:");
            foreach (int vertex in shortestPath)
            {
                Console.Write(vertex + " ");
            }
        }
        else
        {
            Console.WriteLine("No path exists from 0 to 5");
        }
    }
}
