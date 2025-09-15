
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.gz";
        string decompressedFile = "decompressed.txt";

        Console.WriteLine("Compressing file...");
        CompressFile(inputFile, compressedFile);

        Console.WriteLine("Decompressing file...");
        DecompressFile(compressedFile, decompressedFile);

        Console.WriteLine("File compression and decompression completed successfully.");
    }

    static void CompressFile(string inputFile, string compressedFile)
    {
        using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
        {
            using (FileStream compressedFileStream = File.Create(compressedFile))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    inputStream.CopyTo(compressionStream);
                }
            }
        }
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (FileStream compressedFileStream = new FileStream(compressedFile, FileMode.Open))
        {
            using (FileStream decompressedFileStream = File.Create(decompressedFile))
            {
                using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
        }
    }
}
