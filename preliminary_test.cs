
using QRCoder;
using System;
using System.Drawing;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text to generate QR code for:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        using (MemoryStream ms = new MemoryStream())
        {
            qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = ms.ToArray();

            string base64 = Convert.ToBase64String(imageBytes);
            Console.WriteLine($"QR Code generated for '{input}':");

            // display the QR code image as base64 string
            Console.WriteLine(base64);
        }
        
    }
}
