
using System;
using System.Collections.Generic;
using System.Linq;

public class Node
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

public class HuffmanCoding
{
    public static void Main()
    {
        string input = "hello world";
        Dictionary<char, int> frequencyTable = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequencyTable.ContainsKey(c))
            {
                frequencyTable[c]++;
            }
            else
            {
                frequencyTable[c] = 1;
            }
        }

        List<Node> nodes = new List<Node>();
        foreach (var item in frequencyTable)
        {
            nodes.Add(new Node() { Symbol = item.Key, Frequency = item.Value });
        }

        while(nodes.Count > 1)
        {
            nodes = nodes.OrderBy(n => n.Frequency).ToList();

            Node left = nodes[0];
            Node right = nodes[1];

            Node parent = new Node()
            {
                Symbol = '\0',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(parent);
        }

        Node root = nodes.FirstOrDefault();

        Dictionary<char, string> huffmanTable = new Dictionary<char, string>();

        BuildHuffmanTable(root, "", huffmanTable);

        string compressed = "";
        foreach (char c in input)
        {
            compressed += huffmanTable[c];
        }

        Console.WriteLine("Compressed data: " + compressed);
    }

    public static void BuildHuffmanTable(Node node, string code, Dictionary<char, string> table)
    {
        if (node == null)
            return;

        if (node.Symbol != '\0')
        {
            table[node.Symbol] = code;
        }

        BuildHuffmanTable(node.Left, code + "0", table);
        BuildHuffmanTable(node.Right, code + "1", table);
    }
}
