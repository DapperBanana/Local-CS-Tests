
using System;
using System.Collections.Generic;

class Node
{
    public char character;
    public int frequency;
    public Node left, right;
}

class Huffman
{
    private static Dictionary<char, int> GetFrequencies(string text)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (!frequencies.ContainsKey(c))
            {
                frequencies[c] = 0;
            }
            frequencies[c]++;
        }

        return frequencies;
    }

    private static Node BuildTree(Dictionary<char, int> frequencies)
    {
        List<Node> nodes = new List<Node>();

        foreach (var kvp in frequencies)
        {
            nodes.Add(new Node { character = kvp.Key, frequency = kvp.Value });
        }

        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.frequency.CompareTo(y.frequency));

            Node left = nodes[0];
            Node right = nodes[1];

            Node parent = new Node { character = '\0', frequency = left.frequency + right.frequency, left = left, right = right };

            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(parent);
        }

        return nodes[0];
    }

    private static Dictionary<char, string> BuildCodes(Node tree)
    {
        Dictionary<char, string> codes = new Dictionary<char, string>();
        BuildCodesRecursive(tree, "", codes);

        return codes;
    }

    private static void BuildCodesRecursive(Node node, string code, Dictionary<char, string> codes)
    {
        if (node.character != '\0')
        {
            codes[node.character] = code;
        }
        else
        {
            BuildCodesRecursive(node.left, code + "0", codes);
            BuildCodesRecursive(node.right, code + "1", codes);
        }
    }

    public static string Compress(string text)
    {
        Dictionary<char, int> frequencies = GetFrequencies(text);
        Node tree = BuildTree(frequencies);
        Dictionary<char, string> codes = BuildCodes(tree);

        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += codes[c];
        }

        return compressedText;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text = "hello world";
        string compressedText = Huffman.Compress(text);

        Console.WriteLine("Original Text: " + text);
        Console.WriteLine("Compressed Text: " + compressedText);
        Console.WriteLine("Compression Ratio: " + (double)compressedText.Length / text.Length);
    }
}
