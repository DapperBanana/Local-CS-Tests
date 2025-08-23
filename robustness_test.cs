
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile("random_image_generator.py", scope);

            dynamic randomImage = scope.GetVariable("random_image");
            randomImage();
        }
    }
}
