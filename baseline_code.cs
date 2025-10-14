
using System;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the input for which you want to generate a QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code saved as QRCode.png in the current directory.");
    }
}
