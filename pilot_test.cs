
using System;
using System.Collections.Generic;
using System.Linq;

class HuffmanNode
{
    public char Character { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }
}

class HuffmanCoding
{
    public static void Main()
    {
        string text = "hello world";
        Dictionary<char, int> frequencyMap = CalculateFrequency(text);
        List<HuffmanNode> nodes = CreateNodes(frequencyMap);
        HuffmanNode root = BuildHuffmanTree(nodes);
        Dictionary<char, string> encodingMap = GenerateEncodingMap(root);
        string encodedText = Encode(text, encodingMap);
        
        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Encoded text: " + encodedText);
    }

    public static Dictionary<char, int> CalculateFrequency(string text)
    {
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (!frequencyMap.ContainsKey(c))
                frequencyMap[c] = 0;
            frequencyMap[c]++;
        }

        return frequencyMap;
    }

    public static List<HuffmanNode> CreateNodes(Dictionary<char, int> frequencyMap)
    {
        return frequencyMap.Select(kv => new HuffmanNode
        {
            Character = kv.Key,
            Frequency = kv.Value
        }).ToList();
    }

    public static HuffmanNode BuildHuffmanTree(List<HuffmanNode> nodes)
    {
        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.Frequency.CompareTo(y.Frequency));

            HuffmanNode left = nodes[0];
            HuffmanNode right = nodes[1];
            HuffmanNode parent = new HuffmanNode
            {
                Character = '\0',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(parent);
        }

        return nodes.FirstOrDefault();
    }

    public static Dictionary<char, string> GenerateEncodingMap(HuffmanNode node, string encoding = "")
    {
        Dictionary<char, string> encodingMap = new Dictionary<char, string>();

        if (node.Left == null && node.Right == null)
        {
            encodingMap[node.Character] = encoding;
        }
        else
        {
            encodingMap = GenerateEncodingMap(node.Left, encoding + "0");
            encodingMap = encodingMap.Concat(GenerateEncodingMap(node.Right, encoding + "1")).ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        return encodingMap;
    }

    public static string Encode(string text, Dictionary<char, string> encodingMap)
    {
        string encodedText = "";

        foreach (char c in text)
        {
            encodedText += encodingMap[c];
        }

        return encodedText;
    }
}
