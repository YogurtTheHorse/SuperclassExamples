namespace ClassesExamples {
    partial class ClassExampleForm {
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
            this.drawSquareButton = new System.Windows.Forms.Button();
            this.drawCircleButton = new System.Windows.Forms.Button();
            this.drawTriangleButton = new System.Windows.Forms.Button();
            this.canvasBox = new System.Windows.Forms.GroupBox();
            this.objectsCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawSquareButton
            // 
            this.drawSquareButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drawSquareButton.Location = new System.Drawing.Point(13, 275);
            this.drawSquareButton.Name = "drawSquareButton";
            this.drawSquareButton.Size = new System.Drawing.Size(100, 23);
            this.drawSquareButton.TabIndex = 0;
            this.drawSquareButton.Text = "Draw square";
            this.drawSquareButton.UseVisualStyleBackColor = true;
            this.drawSquareButton.Click += new System.EventHandler(this.DrawSquareEvent);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drawCircleButton.Location = new System.Drawing.Point(119, 275);
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(100, 23);
            this.drawCircleButton.TabIndex = 1;
            this.drawCircleButton.Text = "Draw circle";
            this.drawCircleButton.UseVisualStyleBackColor = true;
            this.drawCircleButton.Click += new System.EventHandler(this.DrawCircleEvent);
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drawTriangleButton.Location = new System.Drawing.Point(225, 275);
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(97, 23);
            this.drawTriangleButton.TabIndex = 2;
            this.drawTriangleButton.Text = "Draw triangle";
            this.drawTriangleButton.UseVisualStyleBackColor = true;
            this.drawTriangleButton.Click += new System.EventHandler(this.DrawTrianlgleEvent);
            // 
            // canvasBox
            // 
            this.canvasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasBox.Location = new System.Drawing.Point(12, 12);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(310, 244);
            this.canvasBox.TabIndex = 3;
            this.canvasBox.TabStop = false;
            this.canvasBox.Text = "Canvas";
            // 
            // objectsCountLabel
            // 
            this.objectsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsCountLabel.Location = new System.Drawing.Point(12, 259);
            this.objectsCountLabel.Name = "objectsCountLabel";
            this.objectsCountLabel.Size = new System.Drawing.Size(310, 13);
            this.objectsCountLabel.TabIndex = 4;
            this.objectsCountLabel.Text = "There is no objects";
            this.objectsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.objectsCountLabel);
            this.Controls.Add(this.canvasBox);
            this.Controls.Add(this.drawTriangleButton);
            this.Controls.Add(this.drawCircleButton);
            this.Controls.Add(this.drawSquareButton);
            this.MinimumSize = new System.Drawing.Size(350, 349);
            this.Name = "ClassExampleForm";
            this.Text = "``";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawSquareButton;
        private System.Windows.Forms.Button drawCircleButton;
        private System.Windows.Forms.Button drawTriangleButton;
        private System.Windows.Forms.GroupBox canvasBox;
        private System.Windows.Forms.Label objectsCountLabel;
    }
}

