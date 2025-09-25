
using IronPython.Hosting;

class Program
{
    static void Main(string[] args)
    {
        var engine = Python.CreateEngine();
        var scope = engine.CreateScope();

        // Execute the Python script
        engine.ExecuteFile("random_walk.py", scope);
    }
}
