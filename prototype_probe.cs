
using System;
using System.Collections.Generic;

namespace HuffmanCoding
{
    class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }

    class HuffmanCoding
    {
        public static void Main(string[] args)
        {
            string inputText = "hello world";
            Dictionary<char, int> frequencyTable = new Dictionary<char, int>();

            foreach (char c in inputText)
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
            foreach (var entry in frequencyTable)
            {
                nodes.Add(new Node { Symbol = entry.Key, Frequency = entry.Value });
            }

            while (nodes.Count > 1)
            {
                nodes.Sort((x, y) => x.Frequency.CompareTo(y.Frequency));
                Node left = nodes[0];
                Node right = nodes[1];
                nodes.Remove(left);
                nodes.Remove(right);

                Node parent = new Node { Symbol = '\0', Frequency = left.Frequency + right.Frequency, LeftChild = left, RightChild = right };
                nodes.Add(parent);
            }

            Node root = nodes[0];
            Dictionary<char, string> codes = new Dictionary<char, string>();
            GenerateCodes(root, "", codes);

            string compressed = "";
            foreach (char c in inputText)
            {
                compressed += codes[c];
            }

            Console.WriteLine("Input Text: " + inputText);
            Console.WriteLine("Compressed Text: " + compressed);
        }

        static void GenerateCodes(Node node, string code, Dictionary<char, string> codes)
        {
            if (node.Symbol != '\0')
            {
                codes[node.Symbol] = code;
            }
            else
            {
                GenerateCodes(node.LeftChild, code + "0", codes);
                GenerateCodes(node.RightChild, code + "1", codes);
            }
        }
    }
}
