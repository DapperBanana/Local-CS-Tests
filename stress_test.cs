
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string compressedFilePath = "output.gz";
        string decompressedFilePath = "decompressed.txt";

        // Compress the input file
        CompressFile(inputFilePath, compressedFilePath);

        // Decompress the compressed file
        DecompressFile(compressedFilePath, decompressedFilePath);
    }

    static void CompressFile(string inputFilePath, string compressedFilePath)
    {
        using (FileStream inputStream = File.OpenRead(inputFilePath))
        {
            using (FileStream compressedStream = File.Create(compressedFilePath))
            {
                using (GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Compress))
                {
                    inputStream.CopyTo(gzipStream);
                }
            }
        }

        Console.WriteLine("File compressed successfully.");
    }

    static void DecompressFile(string compressedFilePath, string decompressedFilePath)
    {
        using (FileStream compressedStream = File.OpenRead(compressedFilePath))
        {
            using (FileStream decompressedStream = File.Create(decompressedFilePath))
            {
                using (GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    gzipStream.CopyTo(decompressedStream);
                }
            }
        }

        Console.WriteLine("File decompressed successfully.");
    }
}
