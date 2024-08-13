
using QRCoder;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Get input from user
        Console.WriteLine("Enter text to generate QR code:");
        string input = Console.ReadLine();

        // Generate QR code
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        // Save QR code as image
        qrCodeImage.Save("qrcode.png");
        Console.WriteLine("QR code generated and saved as 'qrcode.png'.");
    }
}
