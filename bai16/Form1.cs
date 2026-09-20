using System;
using System.IO;
using System.Windows.Forms;

namespace bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            // reset to defaults
            txtContent.ForeColor = System.Drawing.SystemColors.ControlText;
            txtContent.Font = new System.Drawing.Font(System.Drawing.SystemFonts.DefaultFont.FontFamily, 10);
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    txtContent.Text = File.ReadAllText(dlgOpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message, "Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlgSaveFile.FileName, txtContent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Save As", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFormatColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                txtContent.ForeColor = dlgColor.Color;
            }
        }

        private void mnuFormatFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = dlgFont.Font;
            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sample application: StepByStep2_19\nWindows Forms menus demo.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuContextCut_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void mnuContextCopy_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void mnuContextPaste_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }
    }
}
