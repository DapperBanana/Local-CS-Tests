
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string pdfFilePath = "sample.pdf";

        try
        {
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                    Console.WriteLine($"Page {page}:");
                    Console.WriteLine(text);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
