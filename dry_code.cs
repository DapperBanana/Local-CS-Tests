
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load the image
        Bitmap image = new Bitmap("input.jpg");

        // Convert the image to grayscale
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);
                int avg = (pixel.R + pixel.G + pixel.B) / 3;
                Color newPixel = Color.FromArgb(avg, avg, avg);
                image.SetPixel(x, y, newPixel);
            }
        }

        // Save the grayscale image
        image.Save("output.jpg");

        // Display success message
        Console.WriteLine("Grayscale conversion complete.");
    }
}
