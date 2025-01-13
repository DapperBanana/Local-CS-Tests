
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load the image file
        Bitmap image = new Bitmap("input.jpg");

        // Convert the image to grayscale
        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int gray = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                Color newPixel = Color.FromArgb(gray, gray, gray);
                image.SetPixel(x, y, newPixel);
            }
        }

        // Save the grayscale image
        image.Save("output.jpg");
    }
}
