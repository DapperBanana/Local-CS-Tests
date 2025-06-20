
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<List<int>> adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<List<int>>();
        for(int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }
    }

    // Function to add an edge to the graph
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    // Function to check if the graph is tree
    public bool IsTree()
    {
        // Array to keep track of visited vertices
        bool[] visited = new bool[V];

        // Check if the graph has cycles
        if(IsCyclic(0, -1, visited))
        {
            return false;
        }

        // Check if all vertices are connected
        for(int i = 0; i < V; i++)
        {
            if(!visited[i])
            {
                return false;
            }
        }

        return true;
    }

    bool IsCyclic(int u, int parent, bool[] visited)
    {
        visited[u] = true;

        foreach(int v in adj[u])
        {
            if(!visited[v])
            {
                if(IsCyclic(v, u, visited))
                {
                    return true;
                }
            }
            else if(v != parent)
            {
                return true;
            }
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(5);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(3, 4);

        if(g.IsTree())
        {
            Console.WriteLine("The graph is a tree.");
        }
        else
        {
            Console.WriteLine("The graph is not a tree.");
        }
    }
}
