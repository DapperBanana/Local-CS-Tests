
using System;
using System.Drawing;
using ZXing;
using ZXing.Common;

class Program
{
    static void Main()
    {
        Console.Write("Enter the input you want to encode as QR code: ");
        string input = Console.ReadLine();

        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new EncodingOptions
            {
                Height = 200,
                Width = 200
            }
        };

        Bitmap qrCode = writer.Write(input);

        qrCode.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine($"QR code generated and saved as QRCode.png");
    }
}
