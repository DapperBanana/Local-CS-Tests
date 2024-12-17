
using System;
using System.Collections.Generic;

class HuffmanNode
{
    public char Character { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }
}

class HuffmanComparator : IComparer<HuffmanNode>
{
    public int Compare(HuffmanNode x, HuffmanNode y)
    {
        return x.Frequency - y.Frequency;
    }
}

class HuffmanCoding
{
    public static void Main(string[] args)
    {
        string text = "hello world";
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

        List<HuffmanNode> nodes = new List<HuffmanNode>();

        foreach (var pair in frequencies)
        {
            nodes.Add(new HuffmanNode { Character = pair.Key, Frequency = pair.Value });
        }

        SortedSet<HuffmanNode> queue = new SortedSet<HuffmanNode>(new HuffmanComparator());

        foreach (HuffmanNode node in nodes)
        {
            queue.Add(node);
        }

        while (queue.Count > 1)
        {
            HuffmanNode left = queue.Min;
            queue.Remove(left);
            HuffmanNode right = queue.Min;
            queue.Remove(right);

            HuffmanNode parent = new HuffmanNode { Character = '\0', Frequency = left.Frequency + right.Frequency, Left = left, Right = right };
            queue.Add(parent);
        }

        HuffmanNode root = queue.Min;

        Dictionary<char, string> codes = new Dictionary<char, string>();
        GenerateCodes(root, "", codes);

        foreach (var pair in codes)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        string encodedText = Encode(text, codes);
        Console.WriteLine($"Encoded Text: {encodedText}");

        string decodedText = Decode(encodedText, root);
        Console.WriteLine($"Decoded Text: {decodedText}");
    }

    public static void GenerateCodes(HuffmanNode node, string code, Dictionary<char, string> codes)
    {
        if (node.Character != '\0')
        {
            codes[node.Character] = code;
        }
        else
        {
            GenerateCodes(node.Left, code + "0", codes);
            GenerateCodes(node.Right, code + "1", codes);
        }
    }

    public static string Encode(string text, Dictionary<char, string> codes)
    {
        string encodedText = "";

        foreach (char c in text)
        {
            encodedText += codes[c];
        }

        return encodedText;
    }

    public static string Decode(string encodedText, HuffmanNode root)
    {
        string decodedText = "";
        HuffmanNode current = root;

        foreach (char bit in encodedText)
        {
            if (bit == '0')
            {
                current = current.Left;
            }
            else if (bit == '1')
            {
                current = current.Right;
            }

            if (current.Character != '\0')
            {
                decodedText += current.Character;
                current = root;
            }
        }

        return decodedText;
    }
}
