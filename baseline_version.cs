
using System;
using ZXing;
using ZXing.Common;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text for which you want to generate QR code:");
        string text = Console.ReadLine();
        
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new EncodingOptions
            {
                Height = 250,
                Width = 250
            }
        };

        var bitmap = writer.Write(text);
        bitmap.Save("qrcode.png");
        
        Console.WriteLine("QR code generated successfully and saved as 'qrcode.png'.");
    }
}
