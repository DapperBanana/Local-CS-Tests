
using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

class Program
{
    static void Main()
    {
        string pdfFilePath = "sample.pdf";
        
        using (PdfReader reader = new PdfReader(pdfFilePath))
        {
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string text = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                Console.WriteLine($"Page {page}: {text}");
            }
        }
    }
}
