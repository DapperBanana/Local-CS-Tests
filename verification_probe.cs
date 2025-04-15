
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.pdf";

        using (PdfReader reader = new PdfReader(filePath))
        {
            string text = "";

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }

            Console.WriteLine(text);
        }
    }
}
