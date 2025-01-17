
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.gz";

        CompressFile(inputFilePath, outputFilePath);

        Console.WriteLine("File compressed successfully.");
    }

    static void CompressFile(string inputFilePath, string outputFilePath)
    {
        using (FileStream inputFile = File.OpenRead(inputFilePath))
        {
            using (FileStream outputFile = File.Create(outputFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(outputFile, CompressionMode.Compress))
                {
                    inputFile.CopyTo(compressionStream);
                }
            }
        }
    }

    static void DecompressFile(string inputFilePath, string outputFilePath)
    {
        using (FileStream inputFile = File.OpenRead(inputFilePath))
        {
            using (FileStream outputFile = File.Create(outputFilePath))
            {
                using (GZipStream decompressionStream = new GZipStream(inputFile, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(outputFile);
                }
            }
        }
    }
}
