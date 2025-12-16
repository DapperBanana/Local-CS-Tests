using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class LineChart : Form
{
    private Dictionary<string, double> data;
    private int padding = 50;
    private int pointRadius = 4;

    public LineChart(Dictionary<string, double> data)
    {
        this.data = data;
        this.Text = "Line Chart";
        this.Size = new Size(800, 600);
        this.BackColor = Color.White;
        this.Paint += new PaintEventHandler(DrawChart);
    }

    private void DrawChart(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // Draw axes
        Pen axisPen = new Pen(Color.Black, 2);
        g.DrawLine(axisPen, padding, ClientSize.Height - padding, padding, padding);
        g.DrawLine(axisPen, padding, ClientSize.Height - padding, ClientSize.Width - padding, ClientSize.Height - padding);

        if (data == null || data.Count == 0)
            return;

        // Determine max value for Y axis scaling
        double maxVal = 0;
        foreach (var val in data.Values)
            if (val > maxVal)
                maxVal = val;

        int nPoints = data.Count;
        var keys = new List<string>(data.Keys);
        double xStep = (double)(ClientSize.Width - 2 * padding) / (nPoints - 1);
        double yScale = (double)(ClientSize.Height - 2 * padding) / (maxVal > 0 ? maxVal : 1);

        // Plot points
        PointF[] points = new PointF[nPoints];
        for (int i = 0; i < nPoints; i++)
        {
            double x = padding + i * xStep;
            double y = ClientSize.Height - padding - data[keys[i]] * yScale;
            points[i] = new PointF((float)x, (float)y);
        }

        // Draw lines
        Pen linePen = new Pen(Color.Blue, 2);
        g.DrawLines(linePen, points);

        // Draw points
        Brush pointBrush = Brushes.Red;
        foreach (var pt in points)
        {
            g.FillEllipse(pointBrush, pt.X - pointRadius, pt.Y - pointRadius, pointRadius * 2, pointRadius * 2);
        }

        // Draw X labels
        for (int i = 0; i < nPoints; i++)
        {
            var label = keys[i];
            float x = (float)(padding + i * xStep);
            g.DrawString(label, Font, Brushes.Black, x - 10, ClientSize.Height - padding + 5);
        }
    }

    [STAThread]
    public static void Main()
    {
        var sampleData = new Dictionary<string, double>
        {
            {"Jan", 50},
            {"Feb", 70},
            {"Mar", 40},
            {"Apr", 90},
            {"May", 60}
        };

        Application.EnableVisualStyles();
        Application.Run(new LineChart(sampleData));
    }
}