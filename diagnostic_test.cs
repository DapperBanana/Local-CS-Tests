
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the text to generate QR code: ");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        using (MemoryStream ms = new MemoryStream())
        {
            qrCodeImage.Save(ms, ImageFormat.Png);
            byte[] qrCodeBytes = ms.ToArray();

            Console.WriteLine("QR code generated successfully!");

            File.WriteAllBytes("qrcode.png", qrCodeBytes);

            Console.WriteLine("QR code saved as 'qrcode.png'");
        }
    }
}
