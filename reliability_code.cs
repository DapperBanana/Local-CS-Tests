
using System;
using System.Collections.Generic;
using System.Linq;

class Node
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Program
{
    static void Main()
    {
        string input = "hello world";
        Dictionary<char, int> frequencies = GetFrequencies(input);
        List<Node> nodes = frequencies.Select(pair => new Node { Symbol = pair.Key, Frequency = pair.Value }).ToList();

        while (nodes.Count > 1)
        {
            nodes = nodes.OrderBy(node => node.Frequency).ToList();
            Node left = nodes[0];
            Node right = nodes[1];
            Node parent = new Node { Symbol = '\0', Frequency = left.Frequency + right.Frequency, Left = left, Right = right };

            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(parent);
        }

        Node root = nodes.FirstOrDefault();
        Dictionary<char, string> encoding = new Dictionary<char, string>();
        GenerateEncoding(root, "", encoding);

        string encodedText = string.Join("", input.Select(character => encoding[character]));
        Console.WriteLine("Encoded text: " + encodedText);

        string decodedText = DecodeText(root, encodedText);
        Console.WriteLine("Decoded text: " + decodedText);
    }

    static Dictionary<char, int> GetFrequencies(string input)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char character in input)
        {
            if (frequencies.ContainsKey(character))
            {
                frequencies[character]++;
            }
            else
            {
                frequencies[character] = 1;
            }
        }

        return frequencies;
    }

    static void GenerateEncoding(Node node, string encoding, Dictionary<char, string> encodings)
    {
        if (node.Left == null && node.Right == null)
        {
            encodings[node.Symbol] = encoding;
        }

        if (node.Left != null)
        {
            GenerateEncoding(node.Left, encoding + "0", encodings);
        }

        if (node.Right != null)
        {
            GenerateEncoding(node.Right, encoding + "1", encodings);
        }
    }

    static string DecodeText(Node root, string encodedText)
    {
        Node current = root;
        string decodedText = "";

        foreach (char bit in encodedText)
        {
            if (bit == '0')
            {
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }

            if (current.Left == null && current.Right == null)
            {
                decodedText += current.Symbol;
                current = root;
            }
        }

        return decodedText;
    }
}
