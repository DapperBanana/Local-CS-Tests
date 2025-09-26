
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFilePath = "example.txt";
        string compressedFilePath = "compressed.txt";

        CompressFile(sourceFilePath, compressedFilePath);

        DecompressFile(compressedFilePath, "decompressed.txt");

        Console.WriteLine("File compression and decompression complete.");
    }

    static void CompressFile(string sourceFilePath, string compressedFilePath)
    {
        using (FileStream sourceFile = File.OpenRead(sourceFilePath))
        {
            using (FileStream compressedFile = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFile, CompressionMode.Compress))
                {
                    sourceFile.CopyTo(compressionStream);
                }
            }
        }
    }

    static void DecompressFile(string compressedFilePath, string decompressedFilePath)
    {
        using (FileStream compressedFile = File.OpenRead(compressedFilePath))
        {
            using (FileStream decompressedFile = File.Create(decompressedFilePath))
            {
                using (GZipStream decompressionStream = new GZipStream(compressedFile, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFile);
                }
            }
        }
    }
}
