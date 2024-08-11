
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

    // Function to add an edge to the graph
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    // A recursive function that uses visited[] and parent to check
    // whether the graph contains a cycle or not
    private bool IsCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                if (IsCyclicUtil(i, visited, v))
                {
                    return true;
                }
            }
            else if (i != parent)
            {
                return true;
            }
        }

        return false;
    }

    // The function returns true if the graph is a tree and false otherwise
    public bool IsTree()
    {
        bool[] visited = new bool[V];
        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
        }

        if (IsCyclicUtil(0, visited, -1))
        {
            return false;
        }

        for (int i = 0; i < V; i++)
        {
            if (!visited[i])
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 4);

        if (graph.IsTree())
        {
            Console.WriteLine("The graph is a tree.");
        }
        else
        {
            Console.WriteLine("The graph is not a tree.");
        }
    }
}
