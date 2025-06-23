
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Python engine
            var engine = Python.CreateEngine();

            // Create the script source
            var source = engine.CreateScriptSourceFromFile("random_walk_plot.py");

            // Execute the script
            source.Execute();
        }
    }
}
