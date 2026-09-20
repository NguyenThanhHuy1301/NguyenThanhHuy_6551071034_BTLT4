namespace bai15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dudColor = new System.Windows.Forms.DomainUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSampleText = new System.Windows.Forms.Label();
            var labelColor = new System.Windows.Forms.Label();
            var labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dudColor
            // 
            this.dudColor.Location = new System.Drawing.Point(120, 28);
            this.dudColor.Name = "dudColor";
            this.dudColor.Size = new System.Drawing.Size(120, 24);
            this.dudColor.TabIndex = 0;
            this.dudColor.Wrap = true;
            this.dudColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow"});
            this.dudColor.Text = "Green";
            this.dudColor.SelectedItemChanged += new System.EventHandler(this.dudColor_SelectedItemChanged);
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(120, 68);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(80, 27);
            this.nudSize.TabIndex = 1;
            this.nudSize.Minimum = 8;
            this.nudSize.Maximum = 40;
            this.nudSize.Value = 16;
            this.nudSize.DecimalPlaces = 0;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new System.Drawing.Point(40, 30);
            labelColor.Name = "labelColor";
            labelColor.Size = new System.Drawing.Size(48, 20);
            labelColor.TabIndex = 2;
            labelColor.Text = "Color:";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new System.Drawing.Point(40, 70);
            labelSize.Name = "labelSize";
            labelSize.Size = new System.Drawing.Size(38, 20);
            labelSize.TabIndex = 3;
            labelSize.Text = "Size:";
            // 
            // lblSampleText
            // 
            this.lblSampleText.Location = new System.Drawing.Point(40, 110);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(340, 60);
            this.lblSampleText.TabIndex = 4;
            this.lblSampleText.Text = "Sample Text";
            this.lblSampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSampleText.ForeColor = System.Drawing.Color.Green;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblSampleText);
            this.Controls.Add(labelSize);
            this.Controls.Add(labelColor);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.dudColor);
            this.Name = "Form1";
            this.Text = "StepByStep2_12";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DomainUpDown dudColor;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSampleText;
    }
}
