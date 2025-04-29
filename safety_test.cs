
using System;
using QRCoder;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text for the QR code: ");
        string inputText = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.H);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20); // Adjust the size of the QR code here

        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);
        Console.WriteLine("QR code generated and saved as QRCode.png");
    }
}
