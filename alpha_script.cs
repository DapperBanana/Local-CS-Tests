
using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = "sample.pdf";

            PdfReader reader = new PdfReader(pdfFilePath);

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string text = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                Console.WriteLine(text);
            }

            reader.Close();
        }
    }
}
