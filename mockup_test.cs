
using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

class Program
{
    static void Main()
    {
        ScriptEngine pythonEngine = Python.CreateEngine();
        ScriptScope pythonScope = pythonEngine.CreateScope();

        pythonEngine.ExecuteFile("path_to_your_python_script_using_scapy.py", pythonScope);

        Console.WriteLine("Network traffic analysis complete.");
    }
}
