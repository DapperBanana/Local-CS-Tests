
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int width = 500;
            int height = 500;

            Bitmap image = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    image.SetPixel(x, y, randomColor);
                }
            }

            string outputPath = "random_image.png";
            image.Save(outputPath, ImageFormat.Png);

            Console.WriteLine($"Random image generated and saved at {outputPath}");
        }
    }
}
