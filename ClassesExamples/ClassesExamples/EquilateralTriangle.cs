using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExamples {
    public class EquilateralTriangle : Shape {
        protected int _side;

        public int Side {
            get { return _side; }
            set { _side = value; Update(); }
        }

        public EquilateralTriangle(int side)
            : base() {

            Side = side;
        }

        private void Update() {
            double R = Math.Sqrt(3) / 3 * _side;

            _points = new Point[] { 
                    new Point(0, (int)R),                                                                  // Up
                    new Point((int)(Math.Sin(2 * Math.PI / 3) * R), (int)(Math.Cos(2 * Math.PI / 3) * R)), // Right
                    new Point((int)(Math.Sin(4 * Math.PI / 3) * R), (int)(Math.Cos(4 * Math.PI / 3) * R)), // Left
            };
        }
    }
}
