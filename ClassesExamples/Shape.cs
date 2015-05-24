using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClassesExamples {
    public class Shape {
        public static int ObjectsCount = 0;

        protected Point[] _points;
        public Point[] Points {
            get { return _points; }
            set { _points = value; }
        }

        public Shape() {
            ObjectsCount++;
            _points = new Point[0];
        }

        public Shape(Point[] points) : this() {
            _points = new Point[points.Length];

            Array.Copy(points, _points, points.Length);
        }

        public void Draw(Control c, Color color) {
            Graphics g = c.CreateGraphics();
            Pen pen = new Pen(color, 1);


            Size offset = new Size(c.Width / 2, c.Height / 2);

            for (int i = 0; i < _points.Length - 1; i++) {
                g.DrawLine(pen, _points[i] + offset, _points[i + 1] + offset);
            }

            g.DrawLine(pen, _points[0] + offset, _points[_points.Length - 1] + offset);

            g.Dispose();
            pen.Dispose();
        }
    }
}
