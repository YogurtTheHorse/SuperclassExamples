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
    public delegate void OnResultDelegate(int param);

    public partial class ParamChooseForm : Form {
        private static int _oldValue = 15;
        private string _paramName;
        private OnResultDelegate _onResult;

        public ParamChooseForm() {
            InitializeComponent();
        }

        public ParamChooseForm(string paramName, OnResultDelegate onResult)
            : this() {
            _paramName = paramName;
            _onResult = onResult;

            this.paramValueTrackBar.Value = _oldValue;
            this.paramValueLabel.Text = _oldValue.ToString();

            this.paramNameLabel.Text = _paramName + ":";
        }

        private void OnValueChanged(object sender, EventArgs e) {
            this.paramValueLabel.Text = this.paramValueTrackBar.Value.ToString();
        }

        private void OnOk(object sender, EventArgs e) {
            _oldValue = this.paramValueTrackBar.Value;
            _onResult(_oldValue);
            this.Close();
        }
    }
}
