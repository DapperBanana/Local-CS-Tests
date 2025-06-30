
using System;
using System.Collections.Generic;
using System.Linq;

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
        public static void Main()
        {
            string input = "hello world";
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            foreach (char c in input)
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

            List<Node> nodes = frequencyMap.Select(x => new Node { Symbol = x.Key, Frequency = x.Value }).ToList();

            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(x => x.Frequency).ToList();
                Node left = nodes[0];
                Node right = nodes[1];
                Node parent = new Node
                {
                    Symbol = '\0',
                    Frequency = left.Frequency + right.Frequency,
                    LeftChild = left,
                    RightChild = right
                };

                nodes.Remove(left);
                nodes.Remove(right);
                nodes.Add(parent);
            }

            Node root = nodes.FirstOrDefault();

            Dictionary<char, string> encodingMap = new Dictionary<char, string>();
            GenerateCodes(root, "", encodingMap);

            Console.WriteLine("Huffman Codes:");
            foreach (var item in encodingMap)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            string compressedText = "";
            foreach (char c in input)
            {
                compressedText += encodingMap[c];
            }

            Console.WriteLine("Compressed Text:");
            Console.WriteLine(compressedText);
        }

        public static void GenerateCodes(Node node, string code, Dictionary<char, string> encodingMap)
        {
            if (node.Symbol != '\0')
            {
                encodingMap[node.Symbol] = code;
            }
            else
            {
                GenerateCodes(node.LeftChild, code + "0", encodingMap);
                GenerateCodes(node.RightChild, code + "1", encodingMap);
            }
        }
    }
}
