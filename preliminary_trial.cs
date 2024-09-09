
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image file
        Bitmap img = new Bitmap("input.jpg");

        // Perform grayscale conversion
        for (int y = 0; y < img.Height; y++)
        {
            for (int x = 0; x < img.Width; x++)
            {
                Color pixel = img.GetPixel(x, y);
                int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(gray, gray, gray);
                img.SetPixel(x, y, newPixel);
            }
        }

        // Save the processed image
        img.Save("output.jpg");

        Console.WriteLine("Image processing complete. Please check the output.jpg file.");
    }
}
