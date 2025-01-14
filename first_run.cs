
using Python.Runtime;

class Program
{
    static void Main()
    {
        using (Py.GIL()) // Acquire the Python GIL (Global Interpreter Lock) to use Python objects
        {
            dynamic plt = Py.Import("matplotlib.pyplot");
            dynamic numpy = Py.Import("numpy");

            int num_points = 100;
            double[] x = new double[num_points];
            double[] y = new double[num_points];

            Random random = new Random();
            x[0] = 0;
            y[0] = 0;

            for (int i = 1; i < num_points; i++)
            {
                x[i] = x[i - 1] + random.Next(-1, 2);
                y[i] = y[i - 1] + random.Next(-1, 2);
            }

            plt.plot(numpy.array(x), numpy.array(y));
            plt.show();
        }
    }
}
