using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClassesExamples {
    public class Shape {
        protected Point[] _points;
        public Point[] Points {
            get { return _points; }
            set { _points = value; }
        }

        public Shape() {
            _points = new Point[0];
        }

        public Shape(Point[] points) {
            _points = new Point[points.Length];

            Array.Copy(points, _points, points.Length);
        }
    }
}
