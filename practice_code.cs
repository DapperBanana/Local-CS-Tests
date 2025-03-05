
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Set the size of the image
        int width = 200;
        int height = 200;

        // Create a new bitmap
        Bitmap bmp = new Bitmap(width, height);

        // Create a random number generator
        Random rand = new Random();

        // Generate random colors for each pixel in the image
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                bmp.SetPixel(x, y, color);
            }
        }

        // Save the image to file
        bmp.Save("random_image.png", System.Drawing.Imaging.ImageFormat.Png);

        // Display a message to the user
        Console.WriteLine("Random image generated and saved to 'random_image.png'");
    }
}
