
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string compressedFile = "output.gz";

        Console.WriteLine("Compressing file...");
        CompressFile(sourceFile, compressedFile);
        Console.WriteLine("File compressed successfully.");

        string decompressedFile = "output.txt";

        Console.WriteLine("Decompressing file...");
        DecompressFile(compressedFile, decompressedFile);
        Console.WriteLine("File decompressed successfully.");
    }

    public static void CompressFile(string sourceFile, string compressedFile)
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
    }

    public static void DecompressFile(string compressedFile, string decompressedFile)
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
    }
}
