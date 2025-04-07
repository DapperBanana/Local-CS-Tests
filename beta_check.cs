
using System;
using System.IO;
using iText.Kernel.Pdf;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = "example.pdf";

            PdfReader reader = new PdfReader(pdfFilePath);
            PdfDocument pdfDoc = new PdfDocument(reader);

            string textContent = "";
            for (int pageNum = 1; pageNum <= pdfDoc.GetNumberOfPages(); pageNum++)
            {
                var page = pdfDoc.GetPage(pageNum);
                textContent += PdfTextExtractor.GetTextFromPage(page) + Environment.NewLine;
            }

            Console.WriteLine(textContent);

            pdfDoc.Close();
            reader.Close();
        }
    }
}
