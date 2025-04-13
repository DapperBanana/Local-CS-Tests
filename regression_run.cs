
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFile = "sample.txt";
        string compressedFile = "sample.txt.gz";
        string decompressedFile = "decompressed.txt";

        CompressFile(sourceFile, compressedFile);
        DecompressFile(compressedFile, decompressedFile);
    }

    static void CompressFile(string sourceFile, string compressedFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open))
        {
            using (FileStream targetStream = File.Create(compressedFile))
            {
                using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                {
                    sourceStream.CopyTo(compressionStream);
                }
            }
        }

        Console.WriteLine("File compressed successfully.");
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (FileStream sourceStream = new FileStream(compressedFile, FileMode.Open))
        {
            using (FileStream targetStream = File.Create(decompressedFile))
            {
                using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(targetStream);
                }
            }
        }

        Console.WriteLine("File decompressed successfully.");
    }
}
