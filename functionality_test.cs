
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Create a new bitmap with random dimensions
        int width = rand.Next(100, 500);
        int height = rand.Next(100, 500);
        Bitmap bitmap = new Bitmap(width, height);

        // Fill the bitmap with random colors
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                bitmap.SetPixel(x, y, color);
            }
        }

        // Save the bitmap as a PNG image
        bitmap.Save("random_image.png", ImageFormat.Png);

        Console.WriteLine("Random image generated and saved as 'random_image.png'");
    }
}
