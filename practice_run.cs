
using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace CSVPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var source = engine.CreateScriptSourceFromFile("plotter.py");

            var scope = engine.ExecuteFile("plotter.py");

            dynamic method = scope.GetVariable("plot_csv");

            method("data.csv");
        }
    }
}
