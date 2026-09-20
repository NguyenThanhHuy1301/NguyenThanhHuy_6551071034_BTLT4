using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;
            // Change color of lblSampleText to selected color
            var c = Color.FromName(dudColor.Text);
            if (!c.IsEmpty)
                lblSampleText.ForeColor = c;
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;
            // Change the font size of lblSampleText
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }
    }
}
