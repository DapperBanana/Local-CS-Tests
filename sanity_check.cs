
using System;
using ZedGraph;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            GraphPane pane = new GraphPane(new System.Drawing.RectangleF(0, 0, 800, 600), "Random Walk Plot", "X", "Y");
            LineItem line = pane.AddCurve("", null, null, System.Drawing.Color.Blue);
            
            PointPairList points = new PointPairList();
            double x = 0, y = 0;
            points.Add(x, y);
            
            for (int i = 0; i < 1000; i++)
            {
                x += rand.NextDouble() * 2 - 1;
                y += rand.NextDouble() * 2 - 1;
                points.Add(x, y);
            }
            
            line.Points = points;
            
            ZedGraphControl zedGraphControl = new ZedGraphControl();
            zedGraphControl.GraphPane = pane;
            zedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            form.Controls.Add(zedGraphControl);
            form.Size = new System.Drawing.Size(800, 600);
            form.ShowDialog();
        }
    }
}
