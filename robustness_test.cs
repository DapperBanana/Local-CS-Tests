
using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCoding
{
    class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    class HuffmanCoding
    {
        public static Dictionary<char, string> Encode(string input)
        {
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

            List<Node> nodes = frequencyTable.Select(kv => new Node { Symbol = kv.Key, Frequency = kv.Value }).ToList();

            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(n => n.Frequency).ToList();

                if (orderedNodes.Count >= 2)
                {
                    List<Node> taken = orderedNodes.Take(2).ToList();

                    Node parent = new Node
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes = nodes.Skip(2).ToList();
                    nodes.Add(parent);
                }
            }

            Node root = nodes.FirstOrDefault();

            Dictionary<char, string> encodingTable = new Dictionary<char, string>();
            EncodeNode(root, "", encodingTable);

            return encodingTable;
        }

        private static void EncodeNode(Node node, string encoding, Dictionary<char, string> encodingTable)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left == null && node.Right == null)
            {
                encodingTable[node.Symbol] = encoding;
            }

            EncodeNode(node.Left, encoding + "0", encodingTable);
            EncodeNode(node.Right, encoding + "1", encodingTable);
        }

        public static string CompressText(string input, Dictionary<char, string> encodingTable)
        {
            string compressedText = "";

            foreach (char c in input)
            {
                compressedText += encodingTable[c];
            }

            return compressedText;
        }

        static void Main(string[] args)
        {
            string text = "Hello, world!";
            Dictionary<char, string> encodingTable = Encode(text);
            string compressedText = CompressText(text, encodingTable);

            Console.WriteLine("Original text: " + text);
            Console.WriteLine("Compressed text: " + compressedText);
        }
    }
}
