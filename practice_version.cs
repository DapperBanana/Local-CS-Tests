
using System;
using System.Collections.Generic;

class Node
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Huffman
{
    public static Dictionary<char, string> Compress(string text)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (frequencies.ContainsKey(c))
            {
                frequencies[c]++;
            }
            else
            {
                frequencies[c] = 1;
            }
        }

        List<Node> nodes = new List<Node>();
        foreach (var kvp in frequencies)
        {
            nodes.Add(new Node { Symbol = kvp.Key, Frequency = kvp.Value });
        }

        while (nodes.Count > 1)
        {
            nodes.Sort((a, b) => a.Frequency.CompareTo(b.Frequency));

            Node newNode = new Node
            {
                Left = nodes[0],
                Right = nodes[1],
                Frequency = nodes[0].Frequency + nodes[1].Frequency
            };

            nodes.RemoveRange(0, 2);
            nodes.Add(newNode);
        }

        Dictionary<char, string> encodingTable = new Dictionary<char, string>();
        BuildEncodingTable(nodes[0], "", encodingTable);

        return encodingTable;
    }

    private static void BuildEncodingTable(Node node, string code, Dictionary<char, string> encodingTable)
    {
        if (node.Left == null && node.Right == null)
        {
            encodingTable[node.Symbol] = code;
            return;
        }

        BuildEncodingTable(node.Left, code + "0", encodingTable);
        BuildEncodingTable(node.Right, code + "1", encodingTable);
    }
}

class Program
{
    static void Main()
    {
        string text = "Hello, World!";
        Dictionary<char, string> encodingTable = Huffman.Compress(text);

        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += encodingTable[c];
        }

        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Compressed text: " + compressedText);
    }
}
