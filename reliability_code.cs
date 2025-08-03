
using System;
using System.IO;

class FileCompression
{
    static void Main()
    {
        string filePath = "input.txt";
        string compressedFilePath = "compressedOutput.txt";
        string decompressedFilePath = "decompressedOutput.txt";

        CompressFile(filePath, compressedFilePath);
        DecompressFile(compressedFilePath, decompressedFilePath);

        Console.WriteLine("File compression and decompression completed.");
    }

    static void CompressFile(string filePath, string compressedFilePath)
    {
        using (StreamWriter writer = new StreamWriter(compressedFilePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
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

    static void DecompressFile(string compressedFilePath, string decompressedFilePath)
    {
        using (StreamWriter writer = new StreamWriter(decompressedFilePath))
        {
            using (StreamReader reader = new StreamReader(compressedFilePath))
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
