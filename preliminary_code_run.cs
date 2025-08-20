
using QRCoder;
using System;
using System.Drawing;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text you want to encode into a QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20); // You can adjust the size here (20 is the default size)

        Console.WriteLine("QR Code generated successfully! Saving the image as 'qrcode.png' in the current directory.");

        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
    }
}
