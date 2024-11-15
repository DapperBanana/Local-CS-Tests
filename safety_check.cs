
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Bitmap image = new Bitmap("example.jpg");

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);
                int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(gray, gray, gray);
                image.SetPixel(x, y, newPixel);
            }
        }

        image.Save("grayscale.jpg");
        Console.WriteLine("Image converted to grayscale successfully.");
    }
}
