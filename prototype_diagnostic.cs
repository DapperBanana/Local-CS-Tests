
using IronPython.Hosting;
using IronPython.Modules;
using Microsoft.Scripting.Hosting;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile("random_walk_plot.py", scope);
        }
    }
}
