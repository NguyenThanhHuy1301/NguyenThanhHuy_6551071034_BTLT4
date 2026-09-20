namespace bai16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatColor;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatFont;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPlaceholder;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilePlaceholder;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCut;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuContextPaste;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.RichTextBox txtContent;

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
            components = new System.ComponentModel.Container();
            mnuMainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            toolStripTextBoxFilePlaceholder = new ToolStripTextBox();
            formatToolStripMenuItem = new ToolStripMenuItem();
            mnuFormatColor = new ToolStripMenuItem();
            mnuFormatFont = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            toolStripTextBoxPlaceholder = new ToolStripTextBox();
            mnuContext = new ContextMenuStrip(components);
            mnuContextCut = new ToolStripMenuItem();
            mnuContextCopy = new ToolStripMenuItem();
            mnuContextPaste = new ToolStripMenuItem();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            txtContent = new RichTextBox();
            mnuMainMenu.SuspendLayout();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.ImageScalingSize = new Size(20, 20);
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem, toolStripTextBoxPlaceholder });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(800, 31);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSaveAs, toolStripSeparator1, mnuFileExit, toolStripTextBoxFilePlaceholder });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(224, 26);
            mnuFileNew.Text = "New";
            mnuFileNew.Click += mnuFileNew_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(224, 26);
            mnuFileOpen.Text = "Open...";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(224, 26);
            mnuFileSaveAs.Text = "Save As...";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(224, 26);
            mnuFileExit.Text = "Exit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // toolStripTextBoxFilePlaceholder
            // 
            toolStripTextBoxFilePlaceholder.Name = "toolStripTextBoxFilePlaceholder";
            toolStripTextBoxFilePlaceholder.Size = new Size(140, 27);
            toolStripTextBoxFilePlaceholder.Text = "Type Here";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFormatColor, mnuFormatFont });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 27);
            formatToolStripMenuItem.Text = "Format";
            // 
            // mnuFormatColor
            // 
            mnuFormatColor.Name = "mnuFormatColor";
            mnuFormatColor.Size = new Size(128, 26);
            mnuFormatColor.Text = "Color";
            mnuFormatColor.Click += mnuFormatColor_Click;
            // 
            // mnuFormatFont
            // 
            mnuFormatFont.Name = "mnuFormatFont";
            mnuFormatFont.Size = new Size(128, 26);
            mnuFormatFont.Text = "Font";
            mnuFormatFont.Click += mnuFormatFont_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(133, 26);
            mnuHelpAbout.Text = "About";
            mnuHelpAbout.Click += mnuHelpAbout_Click;
            // 
            // toolStripTextBoxPlaceholder
            // 
            toolStripTextBoxPlaceholder.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBoxPlaceholder.Name = "toolStripTextBoxPlaceholder";
            toolStripTextBoxPlaceholder.Size = new Size(120, 27);
            toolStripTextBoxPlaceholder.Text = "Type Here";
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(20, 20);
            mnuContext.Items.AddRange(new ToolStripItem[] { mnuContextCut, mnuContextCopy, mnuContextPaste });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(113, 76);
            // 
            // mnuContextCut
            // 
            mnuContextCut.Name = "mnuContextCut";
            mnuContextCut.Size = new Size(112, 24);
            mnuContextCut.Text = "Cut";
            mnuContextCut.Click += mnuContextCut_Click;
            // 
            // mnuContextCopy
            // 
            mnuContextCopy.Name = "mnuContextCopy";
            mnuContextCopy.Size = new Size(112, 24);
            mnuContextCopy.Text = "Copy";
            mnuContextCopy.Click += mnuContextCopy_Click;
            // 
            // mnuContextPaste
            // 
            mnuContextPaste.Name = "mnuContextPaste";
            mnuContextPaste.Size = new Size(112, 24);
            mnuContextPaste.Text = "Paste";
            mnuContextPaste.Click += mnuContextPaste_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // txtContent
            // 
            txtContent.ContextMenuStrip = mnuContext;
            txtContent.Dock = DockStyle.Fill;
            txtContent.Location = new Point(0, 31);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(800, 419);
            txtContent.TabIndex = 1;
            txtContent.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContent);
            Controls.Add(mnuMainMenu);
            MainMenuStrip = mnuMainMenu;
            Name = "Form1";
            Text = "StepByStep2_19";
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
