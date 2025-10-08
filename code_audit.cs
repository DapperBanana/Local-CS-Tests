
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
            string extractedText = ExtractTextFromPDF(pdfFilePath);

            Console.WriteLine("Extracted text from PDF:");
            Console.WriteLine(extractedText);
        }

        public static string ExtractTextFromPDF(string pdfFilePath)
        {
            PdfReader reader = new PdfReader(pdfFilePath);
            string text = "";

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page, new SimpleTextExtractionStrategy());
            }

            reader.Close();
            return text;
        }
    }
}
