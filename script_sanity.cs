using System;
using System.Collections.Generic;

class Program
{
    // Method to find the shortest path using BFS
    static List<int> BFSShortestPath(Dictionary<int, List<int>> graph, int start, int end)
    {
        var visited = new HashSet<int>();
        var queue = new Queue<(int node, List<int> path)>();
        queue.Enqueue((start, new List<int> { start }));
        visited.Add(start);

        while (queue.Count > 0)
        {
            var (currentNode, path) = queue.Dequeue();

            if (currentNode == end)
            {
                return path;
            }

            if (graph.ContainsKey(currentNode))
            {
                foreach (var neighbor in graph[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        var newPath = new List<int>(path) { neighbor };
                        queue.Enqueue((neighbor, newPath));
                    }
                }
            }
        }

        return null; // No path found
    }

    static void Main()
    {
        // Example graph represented as adjacency list
        var graph = new Dictionary<int, List<int>>
        {
            { 1, new List<int> { 2, 3 } },
            { 2, new List<int> { 4 } },
            { 3, new List<int> { 4, 5 } },
            { 4, new List<int> { 6 } },
            { 5, new List<int> { 6 } },
            { 6, new List<int>() }
        };

        int startNode = 1;
        int endNode = 6;

        var shortestPath = BFSShortestPath(graph, startNode, endNode);

        if (shortestPath != null)
        {
            Console.WriteLine("Shortest path: " + string.Join(" -> ", shortestPath));
        }
        else
        {
            Console.WriteLine("No path found from {0} to {1}.", startNode, endNode);
        }
    }
}