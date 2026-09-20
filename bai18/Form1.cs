using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace bai18
{
    public partial class Form1 : Form
    {
        private int newDocumentCount = 0;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            // Only run runtime-only UI code when not in designer
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                // Create simple custom toolbar icons at runtime (small colored bitmaps)
                CreateToolbarIcons();
                // Update status when active MDI child changes
                this.MdiChildActivate += Form1_MdiChildActivate;
            }
        }

        private void Form1_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild is frmChild child)
            {
                this.toolStripStatusLabel1.Text = $"Active: {child.Text.TrimEnd('*')}    Open: {this.MdiChildren.Length}";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Ready";
            }
        }

        private void CreateToolbarIcons()
        {
            try
            {
                // New icon: green plus on transparent
                var bmpNew = new System.Drawing.Bitmap(16, 16);
                using (var g = System.Drawing.Graphics.FromImage(bmpNew))
                {
                    g.Clear(System.Drawing.Color.Transparent);
                    using var pen = new System.Drawing.Pen(System.Drawing.Color.DarkGreen, 2);
                    g.DrawLine(pen, 8, 2, 8, 14);
                    g.DrawLine(pen, 2, 8, 14, 8);
                }
                this.toolStripButtonNew.Image = bmpNew;

                // Open icon: blue folder-like rectangle
                var bmpOpen = new System.Drawing.Bitmap(16, 16);
                using (var g = System.Drawing.Graphics.FromImage(bmpOpen))
                {
                    g.Clear(System.Drawing.Color.Transparent);
                    using var brush = new System.Drawing.SolidBrush(System.Drawing.Color.SteelBlue);
                    g.FillRectangle(brush, 2, 5, 12, 8);
                    using var pen = new System.Drawing.Pen(System.Drawing.Color.Black);
                    g.DrawRectangle(pen, 2, 5, 12, 8);
                    g.FillRectangle(System.Drawing.Brushes.LightSteelBlue, 3, 3, 6, 3);
                }
                this.toolStripButtonOpen.Image = bmpOpen;

                // Save icon: floppy-like square
                var bmpSave = new System.Drawing.Bitmap(16, 16);
                using (var g = System.Drawing.Graphics.FromImage(bmpSave))
                {
                    g.Clear(System.Drawing.Color.Transparent);
                    using var brush = new System.Drawing.SolidBrush(System.Drawing.Color.Goldenrod);
                    g.FillRectangle(brush, 2, 3, 12, 10);
                    using var pen = new System.Drawing.Pen(System.Drawing.Color.Brown);
                    g.DrawRectangle(pen, 2, 3, 12, 10);
                    g.FillRectangle(System.Drawing.Brushes.Bisque, 4, 5, 8, 4);
                }
                this.toolStripButtonSave.Image = bmpSave;
            }
            catch
            {
                // ignore icon creation failures
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDocumentCount++;
            var child = new frmChild();
            child.MdiParent = this;
            child.Text = $"New Document {newDocumentCount}";
            child.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dlg.Title = "Open document";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var child = new frmChild();
                        child.MdiParent = this;
                        child.LoadFile(dlg.FileName);
                        child.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveAllAndExit())
                this.Close();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!ConfirmSaveAllAndExit())
                e.Cancel = true;
        }

        private bool ConfirmSaveAllAndExit()
        {
            // Iterate children and prompt to save if modified
            foreach (var childBase in this.MdiChildren)
            {
                if (childBase is frmChild child && child.IsModified)
                {
                    var res = MessageBox.Show($"Do you want to save changes to {child.Text.TrimEnd('*')}?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Cancel)
                        return false;
                    if (res == DialogResult.Yes)
                    {
                        if (!child.Save())
                            return false; // save failed or cancelled
                    }
                }
            }
            return true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = this.ActiveMdiChild as frmChild;
            if (child != null)
                child.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = this.ActiveMdiChild as frmChild;
            if (child != null)
                child.SaveAs();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = this.ActiveMdiChild;
            child?.Close();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                var child = this.ActiveMdiChild as frmChild;
                if (child != null)
                    child.rtbEditor.WordWrap = item.Checked;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = this.ActiveMdiChild as frmChild;
            if (child == null) return;
            using (var dlg = new FontDialog())
            {
                dlg.Font = child.rtbEditor.Font;
                if (dlg.ShowDialog() == DialogResult.OK)
                    child.rtbEditor.Font = dlg.Font;
            }
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
