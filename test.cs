
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load the image file
        Bitmap original = new Bitmap("input.jpg");

        // Convert the image to grayscale
        Bitmap grayscale = new Bitmap(original.Width, original.Height);
        for (int x = 0; x < original.Width; x++)
        {
            for (int y = 0; y < original.Height; y++)
            {
                Color pixel = original.GetPixel(x, y);
                int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                grayscale.SetPixel(x, y, grayPixel);
            }
        }

        // Save the grayscale image
        grayscale.Save("output.jpg");
    }
}
