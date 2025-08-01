
using System;
using System.Collections.Generic;

public class Node
{
    public char Character { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

public class HuffmanCoding
{
    public static Dictionary<char, string> Encode(string text)
    {
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (frequencyMap.ContainsKey(c))
            {
                frequencyMap[c]++;
            }
            else
            {
                frequencyMap[c] = 1;
            }
        }

        List<Node> nodes = new List<Node>();
        foreach (var entry in frequencyMap)
        {
            nodes.Add(new Node { Character = entry.Key, Frequency = entry.Value });
        }

        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.Frequency.CompareTo(y.Frequency));
            Node left = nodes[0];
            Node right = nodes[1];

            nodes.Remove(left);
            nodes.Remove(right);

            Node parent = new Node
            {
                Character = '\0',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            nodes.Add(parent);
        }

        Dictionary<char, string> encodingMap = new Dictionary<char, string>();
        Encode(nodes[0], "", encodingMap);

        return encodingMap;
    }

    private static void Encode(Node node, string encoding, Dictionary<char, string> encodingMap)
    {
        if (node.Left == null && node.Right == null)
        {
            encodingMap[node.Character] = encoding;
        }
        else
        {
            Encode(node.Left, encoding + "0", encodingMap);
            Encode(node.Right, encoding + "1", encodingMap);
        }
    }

    public static string Compress(string text, Dictionary<char, string> encodingMap)
    {
        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += encodingMap[c];
        }
        return compressedText;
    }

    static void Main(string[] args)
    {
        string text = "hello world";
        Dictionary<char, string> encodingMap = Encode(text);

        string compressedText = Compress(text, encodingMap);

        Console.WriteLine("Original Text: " + text);
        Console.WriteLine("Compressed Text: " + compressedText);
    }
}
