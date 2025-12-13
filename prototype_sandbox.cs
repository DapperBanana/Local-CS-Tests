// Note: Pillow library is a Python library. 
// For C#, the equivalent library is System.Drawing or SkiaSharp.
// Here's a C# program using System.Drawing to generate a random image.

using System;
using System.Drawing;

class RandomImageGenerator
{
    static void Main()
    {
        int width = 800;
        int height = 600;
        var random = new Random();

        // Create a new bitmap
        using (Bitmap bmp = new Bitmap(width, height))
        {
            // Loop through each pixel
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Generate random color
                    Color randomColor = Color.FromArgb(
                        random.Next(256),
                        random.Next(256),
                        random.Next(256));

                    // Set pixel color
                    bmp.SetPixel(x, y, randomColor);
                }
            }

            // Save the image to a file
            bmp.Save("random_image.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        Console.WriteLine("Random image generated and saved as 'random_image.png'.");
    }
}