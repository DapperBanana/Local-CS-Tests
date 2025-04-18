
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        CompressFile(inputFile, outputFile);
        DecompressFile(outputFile, "decompressed.txt");

        Console.WriteLine("File compression and decompression completed.");
    }

    static void CompressFile(string inputFile, string outputFile)
    {
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            using (StreamReader reader = new StreamReader(inputFile))
            {
                char currentChar = (char)reader.Read();
                int count = 1;

                while (!reader.EndOfStream)
                {
                    char nextChar = (char)reader.Read();

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

    static void DecompressFile(string inputFile, string outputFile)
    {
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            using (StreamReader reader = new StreamReader(inputFile))
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
