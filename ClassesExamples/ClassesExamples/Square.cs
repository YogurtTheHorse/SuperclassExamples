using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExamples {
    public class Square : Shape {

        protected int _side;
        public int Side {
            get { return _side; }
            set { _side = value; Update(); }
        }

        public Square(int side)
            : base() {

            Side = side;
        }

        private void Update() {
            _points = new Point[] { 
                    new Point(_side, _side),      // Right up
                    new Point(_side, -_side),     // Right down
                    new Point(-_side, -_side),    // Left down
                    new Point(-_side, _side)      // Left up
            };
        }
    }
}
