
using System;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.pdf";

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath));

            for (int pageNum = 1; pageNum <= pdfDoc.GetNumberOfPages(); pageNum++)
            {
                string text = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(pageNum));
                Console.WriteLine("Page " + pageNum + ": " + text);
            }

            pdfDoc.Close();
        }
    }
}
