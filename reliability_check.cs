
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adjList; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adjList = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adjList[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adjList[u].Add(v);
        adjList[v].Add(u);
    }

    public List<int> ShortestPath(int start, int end)
    {
        bool[] visited = new bool[V];
        int[] distance = new int[V];
        int[] parent = new int[V];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        
        while(queue.Count > 0)
        {
            int current = queue.Dequeue();
            foreach (int neighbor in adjList[current])
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

        // Reconstruct the path from start to end
        List<int> path = new List<int>();
        int currentVertex = end;
        while (currentVertex != start)
        {
            path.Add(currentVertex);
            currentVertex = parent[currentVertex];
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
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);
        g.AddEdge(4, 5);

        List<int> shortestPath = g.ShortestPath(0, 5);

        Console.WriteLine("Shortest Path: ");
        foreach (int vertex in shortestPath)
        {
            Console.Write(vertex + " ");
        }
    }
}
