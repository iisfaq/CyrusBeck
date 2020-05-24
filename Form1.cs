using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyrusBeckLineClipping
{
    public partial class Form1 : Form
    {
        int pointIndex = 2;
        PointF start = new PointF(50, 80);
        PointF end =  new PointF(400, 200);

        PointF trimmedStart;
        PointF trimmedEnd;
        CyrusBeck.CyrusBeckResult result;

        Point[] points = new Point[] {
            new Point( 200,50),
                new Point( 250,100),
                new Point( 200,150),
                new Point( 100,150),
                new Point( 50,100),
                new Point( 100,50)
            };
        public Form1()
        {
            InitializeComponent();
            CalculateClipping();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPolygon(Pens.Red, points);

            if (pointIndex == 2)
            {
                e.Graphics.DrawLine(Pens.Lime, start, end);

                if (result != CyrusBeck.CyrusBeckResult.DoesNotIntersect)
                {
                    e.Graphics.DrawLine(Pens.Blue, trimmedStart, trimmedEnd);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pointIndex != 1)
            {
                start = e.Location;
                pointIndex = 1;
            }
            else
            {
                end = e.Location;
                pointIndex = 2;

                CalculateClipping();
            }
        }

        private void CalculateClipping()
        {
            List<Vector3> clipRectangle = new List<Vector3>();
            foreach (Point p in points)
            {
                clipRectangle.Add(new Vector3(p.X, p.Y, 0));
            }

            Vector3 startVector = new Vector3(start.X, start.Y, 0);
            Vector3 endVector = new Vector3(end.X, end.Y, 0);

            Vector3 startVectorTrimmed;
            Vector3 endVectorTrimmed;
           
            bool IntersectsWithRectangle = CyrusBeck.LineClipping(clipRectangle, startVector, endVector, out startVectorTrimmed, out endVectorTrimmed, out result);

            lblIntersectsValue.Text = IntersectsWithRectangle ?  "Yes / " + result : "No";

            lblLineStartValue.Text = $"{start.X},{start.Y}";
            lblLineEndValue.Text = $"{end.X},{end.Y}";

            lblTrimmedLineStartValue.Text = $"{startVectorTrimmed.X},{startVectorTrimmed.Y}";
            lblTrimmedLineEndValue.Text = $"{endVectorTrimmed.X},{endVectorTrimmed.Y}";

            trimmedStart = new PointF((float)startVectorTrimmed.X, (float)startVectorTrimmed.Y);
            trimmedEnd = new PointF((float)endVectorTrimmed.X, (float)endVectorTrimmed.Y);

            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = new Point(0, 75);
            end = new Point(300,75);
            CalculateClipping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start = new Point(0,0);
            end = new Point(500,500);
            CalculateClipping();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start = new Point(250, 0);
            end = new Point(0, 250);
            CalculateClipping();
        }
    }
}
