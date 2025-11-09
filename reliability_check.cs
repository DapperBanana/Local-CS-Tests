
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.txt";
        string decompressedFile = "decompressed.txt";

        Console.WriteLine("Compressing file...");
        CompressFile(inputFile, compressedFile);
        Console.WriteLine("File compressed successfully.");

        Console.WriteLine("Decompressing file...");
        DecompressFile(compressedFile, decompressedFile);
        Console.WriteLine("File decompressed successfully.");
    }

    static void CompressFile(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(inputFilePath))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
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
                    writer.Write(count);
                    writer.Write(currentChar);
                    currentChar = nextChar;
                    count = 1;
                }
            }

            writer.Write(count);
            writer.Write(currentChar);
        }
    }

    static void DecompressFile(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(inputFilePath))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            while (!reader.EndOfStream)
            {
                int count = int.Parse(reader.ReadLine());
                char character = (char)reader.Read();

                for (int i = 0; i < count; i++)
                {
                    writer.Write(character);
                }
            }
        }
    }
}
