
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string compressedFile = "compressed.gz";
        string decompressedFile = "decompressed.txt";

        CompressFile(sourceFile, compressedFile);
        DecompressFile(compressedFile, decompressedFile);

        Console.WriteLine("File compression and decompression complete.");
    }

    static void CompressFile(string sourceFile, string compressedFile)
    {
        using (FileStream fs = new FileStream(sourceFile, FileMode.Open))
        {
            using (FileStream compressedFileStream = File.Create(compressedFile))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    fs.CopyTo(compressionStream);
                }
            }
        }
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (FileStream fs = new FileStream(compressedFile, FileMode.Open))
        {
            using (FileStream decompressedFileStream = File.Create(decompressedFile))
            {
                using (GZipStream decompressionStream = new GZipStream(fs, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
        }
    }
}
