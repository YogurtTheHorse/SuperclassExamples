namespace ClassesExamples {
    partial class ParamChooseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.paramNameLabel = new System.Windows.Forms.Label();
            this.paramValueTrackBar = new System.Windows.Forms.TrackBar();
            this.paramValueLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paramValueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // paramNameLabel
            // 
            this.paramNameLabel.AutoSize = true;
            this.paramNameLabel.Location = new System.Drawing.Point(13, 13);
            this.paramNameLabel.Name = "paramNameLabel";
            this.paramNameLabel.Size = new System.Drawing.Size(64, 13);
            this.paramNameLabel.TabIndex = 0;
            this.paramNameLabel.Text = "paramName";
            // 
            // paramValueTrackBar
            // 
            this.paramValueTrackBar.Location = new System.Drawing.Point(12, 30);
            this.paramValueTrackBar.Maximum = 50;
            this.paramValueTrackBar.Minimum = 5;
            this.paramValueTrackBar.Name = "paramValueTrackBar";
            this.paramValueTrackBar.Size = new System.Drawing.Size(260, 45);
            this.paramValueTrackBar.TabIndex = 1;
            this.paramValueTrackBar.Value = 15;
            this.paramValueTrackBar.Scroll += new System.EventHandler(this.OnValueChanged);
            // 
            // paramValueLabel
            // 
            this.paramValueLabel.AutoSize = true;
            this.paramValueLabel.Location = new System.Drawing.Point(236, 13);
            this.paramValueLabel.Name = "paramValueLabel";
            this.paramValueLabel.Size = new System.Drawing.Size(19, 13);
            this.paramValueLabel.TabIndex = 2;
            this.paramValueLabel.Text = "15";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(196, 82);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnOk);
            // 
            // ParamChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.paramValueLabel);
            this.Controls.Add(this.paramValueTrackBar);
            this.Controls.Add(this.paramNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ParamChooseForm";
            this.Text = "Choose parameter";
            ((System.ComponentModel.ISupportInitialize)(this.paramValueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paramNameLabel;
        private System.Windows.Forms.TrackBar paramValueTrackBar;
        private System.Windows.Forms.Label paramValueLabel;
        private System.Windows.Forms.Button okButton;
    }
}