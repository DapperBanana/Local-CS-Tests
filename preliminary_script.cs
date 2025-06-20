
using Python.Runtime;

class Program
{
    static void Main()
    {
        using (Py.GIL())
        {
            dynamic plt = Py.Import("matplotlib.pyplot");
            dynamic random = Py.Import("numpy.random");

            int numSteps = 1000;
            dynamic x = random.randn(numSteps).cumsum();
            dynamic y = random.randn(numSteps).cumsum();

            plt.plot(x, y);
            plt.xlabel("X");
            plt.ylabel("Y");
            plt.title("Random Walk Plot");
            plt.show();
        }
    }
}
