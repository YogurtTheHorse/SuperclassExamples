using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesExamples {
    public partial class ClassExampleForm : Form {
        public ClassExampleForm() {
            InitializeComponent();
        }

        private void ShowForm(string paramName, OnResultDelegate onResult) {
            ParamChooseForm paramForm = new ParamChooseForm(paramName, onResult);

            paramForm.ShowDialog();
        }

        private void DrawShape(Shape shape) {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                Pen pen = new Pen(colorDialog.Color, 1);
                Graphics g = this.canvasBox.CreateGraphics();

                Size offset = new Size(this.canvasBox.Width / 2, this.canvasBox.Height / 2);

                for (int i = 0; i < shape.Points.Length - 1; i++) {
                    g.DrawLine(pen, shape.Points[i] + offset, shape.Points[i + 1] + offset);
                }

                g.DrawLine(pen, shape.Points[0] + offset, shape.Points[shape.Points.Length - 1] + offset);

                g.Dispose();
                pen.Dispose();
            }
        }

        private void DrawSquareEvent(object sender, EventArgs e) {
            ShowForm("Square side", delegate(int param) { DrawShape(new Square(param)); });
        }

        private void DrawCircleEvent(object sender, EventArgs e) {
            ShowForm("Circle radius", delegate(int param) { DrawShape(new Circle(param)); });
        }

        private void DrawTrianlgleEvent(object sender, EventArgs e) {
            ShowForm("Triangle side", delegate(int param) { DrawShape(new EquilateralTriangle(param)); });
        }
    }
}
