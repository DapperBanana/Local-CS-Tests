using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class LineChart : Form
{
    private Dictionary<string, double> data;

    public LineChart(Dictionary<string, double> data)
    {
        this.data = data;
        this.Text = "Simple Line Chart";
        this.Size = new Size(800, 600);
        this.Paint += LineChart_Paint;
    }

    private void LineChart_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        int width = this.ClientSize.Width;
        int height = this.ClientSize.Height;
        int margin = 50;

        // Draw axes
        Pen axisPen = Pens.Black;
        g.DrawLine(axisPen, margin, height - margin, margin, margin); // Y-axis
        g.DrawLine(axisPen, margin, height - margin, width - margin, height - margin); // X-axis

        if (data == null || data.Count == 0)
            return;

        // Find max value for scaling
        double maxValue = 0;
        foreach (var val in data.Values)
            if (val > maxValue)
                maxValue = val;

        int pointCount = data.Count;
        int chartWidth = width - 2 * margin;
        int chartHeight = height - 2 * margin;

        // Calculate spacing between points
        double xSpacing = (double)chartWidth / (pointCount - 1);

        // Convert data points to screen points
        PointF[] points = new PointF[pointCount];
        int index = 0;

        foreach (var kvp in data)
        {
            float x = (float)(margin + index * xSpacing);
            float y = (float)(margin + chartHeight - (kvp.Value / maxValue) * chartHeight);
            points[index] = new PointF(x, y);
            index++;
        }

        // Draw lines connecting data points
        Pen linePen = Pens.Blue;
        g.DrawLines(linePen, points);

        // Draw data points
        foreach (var point in points)
        {
            g.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
        }

        // Optional: Draw labels or gridlines here
    }

    [STAThread]
    public static void Main()
    {
        var sampleData = new Dictionary<string, double>
        {
            { "Jan", 10 },
            { "Feb", 20 },
            { "Mar", 15 },
            { "Apr", 30 },
            { "May", 25 },
            { "Jun", 40 }
        };

        Application.EnableVisualStyles();
        Application.Run(new LineChart(sampleData));
    }
}