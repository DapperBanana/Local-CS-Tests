
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Create a new Bitmap object with desired width and height
        Bitmap image = new Bitmap(500, 500);

        // Create a random number generator
        Random rand = new Random();

        // Loop through each pixel in the image
        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                // Generate random RGB values
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);

                // Set the pixel color
                Color color = Color.FromArgb(r, g, b);
                image.SetPixel(x, y, color);
            }
        }

        // Save the image to a file
        image.Save("random_image.png", ImageFormat.Png);
    }
}
