
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.pdf";
        ExtractTextFromPDF(path);
    }

    public static void ExtractTextFromPDF(string path)
    {
        using (PdfReader reader = new PdfReader(path))
        {
            string text = "";
            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i);
            }
            Console.WriteLine(text);
        }
    }
}
