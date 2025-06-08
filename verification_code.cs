
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic pillow = Py.Import("PIL.Image");

                Random random = new Random();
                int width = 200;
                int height = 200;

                dynamic image = pillow.new("RGB", new PyTuple(new List<int> { width, height }));

                byte[] pixel = new byte[3];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            pixel[i] = (byte)random.Next(256);
                        }

                        image.putpixel(new PyTuple(new List<int> { x, y }), new PyTuple(pixel));
                    }
                }

                image.show();
            }
        }
    }
}
