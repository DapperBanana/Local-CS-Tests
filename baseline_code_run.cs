
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

class Program
{
    static void Main()
    {
        using (PdfDocument pdfDocument = new PdfDocument(new PdfReader("example.pdf")))
        {
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string text = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i), strategy);
                
                Console.WriteLine(text);
            }
        }
    }
}
