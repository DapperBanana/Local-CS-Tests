// Note: PyPDF2 is a Python library and cannot be used directly in C#.
// For C#, a common library to extract text from PDFs is iTextSharp or PdfSharp.
// Here's an example using iTextSharp:

using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

class Program
{
    static void Main(string[] args)
    {
        string pdfPath = "example.pdf"; // Path to your PDF file
        string text = ExtractTextFromPdf(pdfPath);
        Console.WriteLine(text);
    }

    public static string ExtractTextFromPdf(string path)
    {
        using (PdfReader reader = new PdfReader(path))
        {
            StringBuilder text = new StringBuilder();

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                text.AppendLine(pageText);
            }

            return text.ToString();
        }
    }
}