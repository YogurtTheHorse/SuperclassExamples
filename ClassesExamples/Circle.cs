using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExamples {
    public class  Circle : Shape {
        protected int _radius;

        public int Radius {
            get { return _radius; }
            set { _radius = value; Update(); }
        }

        public Circle(int side)
            : base() {

            Radius = side;
        }

        private void Update() {
            int dots = (int)(Math.PI * _radius);

            _points = new Point[dots];

            for (int i = 0; i < dots; ++i) {
                double angle = 2 * i * Math.PI / dots;

                _points[i] = new Point((int)(Math.Sin(angle) * _radius), (int)(Math.Cos(angle) * _radius));
            }
        }
    }
}
