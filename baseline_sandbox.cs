
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile("C:\\Python27\\Lib\\site-packages\\numpy\\__init__.py", scope);
            engine.ExecuteFile("C:\\Python27\\Lib\\site-packages\\matplotlib\\__init__.py", scope);

            var random = engine.Operations.GetMember(scope.GetVariable("numpy"), "random");

            var x = random.InvokeMethod(engine.Operations.GetMember(scope.GetVariable("numpy"), "cumsum"), 0.1 * random.InvokeMethod("randn", 1000));
            var y = random.InvokeMethod(engine.Operations.GetMember(scope.GetVariable("numpy"), "cumsum"), 0.1 * random.InvokeMethod("randn", 1000));

            engine.Execute("import matplotlib.pyplot as plt");
            engine.SetVariable("x", x);
            engine.SetVariable("y", y);
            engine.Execute("plt.plot(x, y)");
            engine.Execute("plt.show()");
        }
    }
}
