using System;
using System.IO;
using System.Windows.Forms;

namespace bai18
{
    public class frmChild : Form
    {
        public RichTextBox rtbEditor = null!;
        public string FilePath { get; private set; } = string.Empty;
        public bool IsModified { get; private set; }

        public frmChild()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rtbEditor = new RichTextBox();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Dock = DockStyle.Fill;
            this.rtbEditor.HideSelection = false;
            this.rtbEditor.Multiline = true;
            this.rtbEditor.AcceptsTab = true;
            this.rtbEditor.TextChanged += RtbEditor_TextChanged;
            this.FormClosing += FrmChild_FormClosing;
            // 
            // frmChild
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.rtbEditor);
            this.Text = "New Document";
            this.ResumeLayout(false);
        }

        private void RtbEditor_TextChanged(object? sender, EventArgs e)
        {
            if (!IsModified)
            {
                IsModified = true;
                UpdateTitle();
            }
        }

        private void FrmChild_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!IsModified) return;

            var result = MessageBox.Show($"Do you want to save changes to {this.Text}?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            if (result == DialogResult.Yes)
            {
                // Try save; if save cancelled, cancel closing
                if (!Save())
                    e.Cancel = true;
            }
        }

        private void UpdateTitle()
        {
            if (IsModified)
            {
                if (!this.Text.EndsWith("*"))
                    this.Text = this.Text + "*";
            }
            else
            {
                if (this.Text.EndsWith("*"))
                    this.Text = this.Text.TrimEnd('*');
            }
        }

        public void LoadFile(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
                return;

            var ext = Path.GetExtension(path).ToLowerInvariant();
            if (ext == ".rtf")
                this.rtbEditor.LoadFile(path, RichTextBoxStreamType.RichText);
            else
                this.rtbEditor.LoadFile(path, RichTextBoxStreamType.PlainText);

            this.Text = Path.GetFileName(path);
            this.FilePath = path;
            this.IsModified = false;
        }

        public bool Save()
        {
            if (string.IsNullOrEmpty(this.FilePath))
                return SaveAs();

            try
            {
                SaveFileTo(this.FilePath);
                IsModified = false;
                UpdateTitle();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
                return false;
            }
        }

        public bool SaveAs()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dlg.Title = "Save document as";
                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;

                try
                {
                    SaveFileTo(dlg.FileName);
                    this.FilePath = dlg.FileName;
                    this.IsModified = false;
                    this.Text = Path.GetFileName(this.FilePath);
                    UpdateTitle();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                    return false;
                }
            }
        }

        private void SaveFileTo(string path)
        {
            var ext = Path.GetExtension(path).ToLowerInvariant();
            if (ext == ".rtf")
                this.rtbEditor.SaveFile(path, RichTextBoxStreamType.RichText);
            else
                this.rtbEditor.SaveFile(path, RichTextBoxStreamType.PlainText);
        }
    }
}
