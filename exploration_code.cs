
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFileName = "input.txt";
        string compressedFileName = "compressed.bin";
        string decompressedFileName = "decompressed.txt";

        // Compress file
        CompressFile(inputFileName, compressedFileName);

        // Decompress file
        DecompressFile(compressedFileName, decompressedFileName);
    }

    static void CompressFile(string inputFileName, string compressedFileName)
    {
        using (FileStream inputFile = File.OpenRead(inputFileName))
        using (FileStream compressedFile = File.Create(compressedFileName))
        using (GZipStream compressionStream = new GZipStream(compressedFile, CompressionMode.Compress))
        {
            inputFile.CopyTo(compressionStream);
        }
        Console.WriteLine("File compressed successfully.");
    }

    static void DecompressFile(string compressedFileName, string decompressedFileName)
    {
        using (FileStream compressedFile = File.OpenRead(compressedFileName))
        using (FileStream decompressedFile = File.Create(decompressedFileName))
        using (GZipStream decompressionStream = new GZipStream(compressedFile, CompressionMode.Decompress))
        {
            decompressionStream.CopyTo(decompressedFile);
        }
        Console.WriteLine("File decompressed successfully.");
    }
}
