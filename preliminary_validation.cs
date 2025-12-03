using System;
using System.Collections.Generic;

class Graph
{
    private readonly Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int u, int v)
    {
        if (!adjacencyList.ContainsKey(u))
            adjacencyList[u] = new List<int>();
        if (!adjacencyList.ContainsKey(v))
            adjacencyList[v] = new List<int>();

        adjacencyList[u].Add(v);
        adjacencyList[v].Add(u); // Assuming undirected graph
    }

    public List<int> FindShortestPath(int start, int end)
    {
        var visited = new HashSet<int>();
        var parent = new Dictionary<int, int>();
        var queue = new Queue<int>();

        visited.Add(start);
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == end)
            {
                // Reconstruct the path
                var path = new List<int>();
                while (current != start)
                {
                    path.Add(current);
                    current = parent[current];
                }
                path.Add(start);
                path.Reverse();
                return path;
            }

            if (adjacencyList.ContainsKey(current))
            {
                foreach (var neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        parent[neighbor] = current;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        // No path found
        return null;
    }
}

class Program
{
    static void Main()
    {
        var graph = new Graph();

        // Example graph edges
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(3, 6);

        int startNode = 1;
        int endNode = 5;
        var shortestPath = graph.FindShortestPath(startNode, endNode);

        if (shortestPath != null)
            Console.WriteLine("Shortest path: " + string.Join(" -> ", shortestPath));
        else
            Console.WriteLine("No path found between " + startNode + " and " + endNode);
    }
}