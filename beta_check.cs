
using System;
using System.IO;

class FileCompression
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.txt";
        string decompressedFile = "decompressed.txt";

        // Compress the input file
        CompressFile(inputFile, compressedFile);

        // Decompress the compressed file
        DecompressFile(compressedFile, decompressedFile);
        
        Console.WriteLine("File compression and decompression complete.");
    }

    static void CompressFile(string inputFile, string compressedFile)
    {
        using (StreamWriter writer = new StreamWriter(compressedFile))
        {
            using (StreamReader reader = new StreamReader(inputFile))
            {
                char currentChar = (char)reader.Read();
                char nextChar;
                int count = 1;

                while (!reader.EndOfStream)
                {
                    nextChar = (char)reader.Read();

                    if (nextChar == currentChar)
                    {
                        count++;
                    }
                    else
                    {
                        writer.Write($"{currentChar}{count}");
                        currentChar = nextChar;
                        count = 1;
                    }
                }

                writer.Write($"{currentChar}{count}");
            }
        }
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (StreamWriter writer = new StreamWriter(decompressedFile))
        {
            using (StreamReader reader = new StreamReader(compressedFile))
            {
                while (!reader.EndOfStream)
                {
                    char currentChar = (char)reader.Read();
                    int count = int.Parse(reader.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        writer.Write(currentChar);
                    }
                }
            }
        }
    }
}
