
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        int width = 200;
        int height = 200;

        using (Bitmap bmp = new Bitmap(width, height))
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                        using (Brush brush = new SolidBrush(randomColor))
                        {
                            g.FillRectangle(brush, x, y, 1, 1);
                        }
                    }
                }
            }

            bmp.Save("random_image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        Console.WriteLine("Random image generated and saved as 'random_image.bmp'");
    }
}
