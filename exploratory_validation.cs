
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFile = "sample.txt";
        string compressedFile = "compressed.gz";

        CompressFile(sourceFile, compressedFile);

        DecompressFile(compressedFile, "decompressed.txt");

        Console.WriteLine("File compression and decompression complete.");
    }

    static void CompressFile(string sourceFile, string compressedFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open))
        {
            using (FileStream destinationStream = File.Create(compressedFile))
            {
                using (GZipStream compressStream = new GZipStream(destinationStream, CompressionMode.Compress))
                {
                    sourceStream.CopyTo(compressStream);
                }
            }
        }
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (FileStream sourceStream = new FileStream(compressedFile, FileMode.Open))
        {
            using (FileStream destinationStream = File.Create(decompressedFile))
            {
                using (GZipStream decompressStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                {
                    decompressStream.CopyTo(destinationStream);
                }
            }
        }
    }
}
