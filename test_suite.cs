
using System;
using QRCoder;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.Write("Enter the text for the QR code: ");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        Console.WriteLine("QR Code generated successfully!");

        // Save QR code image to file
        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
    }
}
