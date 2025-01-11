
using System;
using Python.Runtime;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
			// Initialize the Python runtime
            using (Py.GIL())
            {
                // Import the necessary Python libraries
                dynamic plt = Py.Import("matplotlib.pyplot");
                dynamic np = Py.Import("numpy");

                // Generate random RGB values for the image
                dynamic random_pixels = np.random.randint(0, 256, new int[] { 100, 100, 3 });

                // Create a figure and display the random image
                plt.imshow(random_pixels);
                plt.axis("off");
                plt.show();
            }
        }
    }
}
