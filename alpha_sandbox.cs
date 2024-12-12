
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image
        Bitmap originalImage = new Bitmap("image.jpg");
        
        // Create a new image for storing grayscale version
        Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);

        // Convert each pixel to grayscale
        for (int x = 0; x < originalImage.Width; x++)
        {
            for (int y = 0; y < originalImage.Height; y++)
            {
                Color pixel = originalImage.GetPixel(x, y);
                int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(grayscale, grayscale, grayscale);
                grayImage.SetPixel(x, y, newPixel);
            }
        }

        // Save the grayscale image
        grayImage.Save("grayscale_image.jpg");

        Console.WriteLine("Grayscale conversion successful.");
    }
}
