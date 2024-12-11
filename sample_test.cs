
using System;
using System.Numerics;
using SciSharp.Matplotlib.Plot;

class Program
{
    static void Main()
    {
        var rnd = new Random();
        var points = new List<Vector2> { new Vector2(0, 0) };
        
        for (int i = 0; i < 100; i++)
        {
            var lastPoint = points[points.Count - 1];
            var x = lastPoint.X + rnd.Next(-1, 2);
            var y = lastPoint.Y + rnd.Next(-1, 2);
            points.Add(new Vector2(x, y));
        }

        var plt = new plt();
        plt.plot(points.Select(p => p.X), points.Select(p => p.Y));
        plt.show();
    }
}
