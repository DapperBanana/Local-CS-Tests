
using System;
using System.Drawing;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the input text for the QR code:");
        string input = Console.ReadLine();
        
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        
        Bitmap qrCodeImage = qrCode.GetGraphic(20); // Adjust the size of the QR code here
        
        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
        
        Console.WriteLine("QR code generated and saved as 'qrcode.png'");
    }
}
