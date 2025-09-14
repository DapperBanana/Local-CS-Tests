
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;

class Program
{
    static void Main()
    {
        string pdfFilePath = @"C:\example.pdf";

        using (PdfDocument document = PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Import))
        {
            for (int pageNumber = 0; pageNumber < document.PageCount; pageNumber++)
            {
                PdfPage page = document.Pages[pageNumber];
                string pageText = ExtractTextFromPage(page);
                Console.WriteLine(pageText);
            }
        }
    }

    static string ExtractTextFromPage(PdfPage page)
    {
        PdfSharp.Pdf.Advanced.PdfContentReader contentReader = new PdfSharp.Pdf.Advanced.PdfContentReader(page);
        string pageText = string.Empty;

        while (contentReader.ReadNextChar() > 0)
        {
            pageText += contentReader.Char;
        }

        return pageText;
    }
}
