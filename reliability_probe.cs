
using Python.Runtime;

class Program
{
    static void Main()
    {
        // Initialize Python engine
        using (Py.GIL())
        {
            dynamic plt = Py.Import("matplotlib.pyplot");
            
            // Read data from CSV file
            dynamic pandas = Py.Import("pandas");
            dynamic data = pandas.read_csv("sample_data.csv");
            
            // Plot bar chart
            plt.bar(data["x"], data["y"]);
            plt.xlabel("X Axis");
            plt.ylabel("Y Axis");
            plt.title("Bar Chart");
            plt.show();
        }
    }
}
