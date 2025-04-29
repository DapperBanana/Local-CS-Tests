
using QRCoder;
using System;
using System.Drawing;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text you want to generate a QR code for:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        Console.WriteLine("QR code generated successfully. Saving to file...");

        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code saved as qrcode.png");
    }
}
