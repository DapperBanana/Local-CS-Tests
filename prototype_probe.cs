
using Python.Runtime; // Matplotlib.NET requires Python.Runtime

namespace CSVPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Python
            PythonEngine.Initialize();

            // Import necessary libraries
            dynamic plt = Py.Import("matplotlib.pyplot");
            dynamic np = Py.Import("numpy");
            dynamic csv = Py.Import("csv");

            // Read data from CSV file
            dynamic data = new List<dynamic>();
            using (var reader = new StreamReader("data.csv"))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<dynamic>();
                foreach (var record in records)
                {
                    data.Add(record);
                }
            }

            // Extract x and y values
            dynamic x = new List<dynamic>();
            dynamic y = new List<dynamic>();
            foreach (var record in data)
            {
                x.Add(record.X);
                y.Add(record.Y);
            }

            // Create a bar chart
            plt.bar(np.arange(data.Count), y);
            plt.xticks(np.arange(data.Count), x);

            // Show the plot
            plt.show();

            // Cleanup
            PythonEngine.Shutdown();
        }
    }
}
