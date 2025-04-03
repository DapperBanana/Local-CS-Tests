
using System;
using System.Drawing;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.Write("Enter text to encode in QR code: ");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        qrCodeImage.Save("QRCode.png"); 
        Console.WriteLine("QR code image has been saved as QRCode.png");
    }
}
