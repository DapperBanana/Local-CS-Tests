
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;

class Program
{
    static void Main()
    {
        string inputPdf = "example.pdf"; // Path to the PDF file
        string outputText = ExtractTextFromPdf(inputPdf);
        
        Console.WriteLine(outputText);
    }

    static string ExtractTextFromPdf(string pdfPath)
    {
        using (PdfReader reader = new PdfReader(pdfPath))
        {
            string text = "";

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i, new SimpleTextExtractionStrategy());
            }

            return text;
        }
    }
}
