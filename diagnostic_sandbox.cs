
using System;
using Python.Runtime;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic pillow = Py.Import("PIL");
                dynamic Image = pillow.Image;
                dynamic ImageDraw = pillow.ImageDraw;
                
                Random random = new Random();

                int width = 500;
                int height = 500;

                dynamic image = Image.new("RGB", new PyTuple(new dynamic[] { width, height }));
                dynamic draw = ImageDraw.Draw(image);

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int red = random.Next(0, 256);
                        int green = random.Next(0, 256);
                        int blue = random.Next(0, 256);

                        draw.point(new PyTuple(new dynamic[] { x, y }), new PyTuple(new dynamic[] { red, green, blue }));
                    }
                }

                image.show();
            }
        }
    }
}
