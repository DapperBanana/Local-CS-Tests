
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

class Program
{
    static void Main()
    {
        int width = 500;
        int height = 500;

        using (Image<Rgba32> image = new Image<Rgba32>(width, height))
        {
            var random = new Random();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    byte red = (byte)random.Next(256);
                    byte green = (byte)random.Next(256);
                    byte blue = (byte)random.Next(256);

                    image[x, y] = new Rgba32(red, green, blue);
                }
            }

            image.Save("random_image.png");
        }
    }
}
