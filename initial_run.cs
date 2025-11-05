
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image file
        Bitmap image = new Bitmap("input.jpg");

        // Convert each pixel to grayscale
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color color = image.GetPixel(x, y);
                int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                Color grayColor = Color.FromArgb(gray, gray, gray);
                image.SetPixel(x, y, grayColor);
            }
        }

        // Save the grayscale image
        image.Save("output.jpg");

        Console.WriteLine("Image processed successfully! Grayscale conversion done.");
    }
}
