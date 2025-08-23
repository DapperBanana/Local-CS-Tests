
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.txt";
        string decompressedFile = "decompressed.txt";

        // Compress the input file
        Compress(inputFile, compressedFile);

        // Decompress the compressed file
        Decompress(compressedFile, decompressedFile);

        Console.WriteLine("File compression and decompression done.");
    }

    static void Compress(string inputFile, string compressedFile)
    {
        string inputText = File.ReadAllText(inputFile);
        using (StreamWriter writer = new StreamWriter(compressedFile))
        {
            int count = 1;
            char currentChar = inputText[0];
            for (int i = 1; i < inputText.Length; i++)
            {
                if (inputText[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    writer.Write($"{currentChar}{count}");
                    currentChar = inputText[i];
                    count = 1;
                }
            }
            writer.Write($"{currentChar}{count}");
        }
    }

    static void Decompress(string compressedFile, string decompressedFile)
    {
        string compressedText = File.ReadAllText(compressedFile);
        using (StreamWriter writer = new StreamWriter(decompressedFile))
        {
            for (int i = 0; i < compressedText.Length; i += 2)
            {
                char currentChar = compressedText[i];
                int count = int.Parse(compressedText[i + 1].ToString());
                for (int j = 0; j < count; j++)
                {
                    writer.Write(currentChar);
                }
            }
        }
    }
}
