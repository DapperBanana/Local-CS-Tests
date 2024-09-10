
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
            Random rnd = new Random();
            int width = 500;
            int height = 500;

            Bitmap bmp = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    bmp.SetPixel(x, y, randomColor);
                }
            }

            bmp.Save("random_image.bmp", ImageFormat.Bmp);
            Console.WriteLine("Random image generated and saved as random_image.bmp");
        }
    }
}
