
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
            nodes.Add(new Node { Character = kvp.Key, Frequency = kvp.Value });
        }

        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.Frequency - y.Frequency);
            Node left = nodes[0];
            Node right = nodes[1];
            if (left != null)
            {
                left.Left = right;
                left.Right = left;
                left.Frequency += right.Frequency;
                nodes.RemoveAt(1);
            }
        }

        Dictionary<char, string> encoding = new Dictionary<char, string>();
        EncodeHelper(nodes[0], "", encoding);
        return encoding;
    }

    private static void EncodeHelper(Node node, string prefix, Dictionary<char, string> encoding)
    {
        if (node != null)
        {
            if (node.Character != '\0')
            {
                encoding[node.Character] = prefix;
            }
            if (node.Left != null)
            {
                EncodeHelper(node.Left, prefix + "0", encoding);
            }
            if (node.Right != null)
            {
                EncodeHelper(node.Right, prefix + "1", encoding);
            }
        }
    }

    public static string Compress(string text, Dictionary<char, string> encoding)
    {
        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += encoding[c];
        }
        return compressedText;
    }

    public static void Main()
    {
        string text = "hello world";
        Dictionary<char, string> encoding = Encode(text);
        string compressedText = Compress(text, encoding);

        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Compressed text: " + compressedText);
    }
}
