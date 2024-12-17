
using System;
using System.Collections.Generic;

class Graph
{
    private int V; 
    private List<int>[] adj; 

    public Graph(int V)
    {
        this.V = V;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void addEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    private bool isCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                if (isCyclicUtil(i, visited, v))
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

    public bool isTree()
    {
        bool[] visited = new bool[V];

        if (isCyclicUtil(0, visited, -1))
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
    static void Main()
    {
        Graph g = new Graph(5);
        g.addEdge(1, 0);
        g.addEdge(0, 2);
        g.addEdge(0, 3);
        g.addEdge(3, 4);

        if (g.isTree())
        {
            Console.WriteLine("The given graph is a tree.");
        }
        else
        {
            Console.WriteLine("The given graph is not a tree.");
        }
    }
}
