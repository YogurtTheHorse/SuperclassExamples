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
                shape.Draw(this.canvasBox, colorDialog.Color);
            }

            if (Shape.ObjectsCount == 1) {
                objectsCountLabel.Text = "There is 1 object";
            } else {
                objectsCountLabel.Text = String.Format("There are {0} object", Shape.ObjectsCount);
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
