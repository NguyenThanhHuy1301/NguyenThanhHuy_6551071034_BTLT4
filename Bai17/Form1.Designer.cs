using System.Windows.Forms;
using System.Drawing;

namespace Bai14
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
        // control fields
        private TextBox txtTen;
        private Label lblTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnRight;
        private Button btnLeft;
        private Button btnAllRight;
        private Button btnAllLeft;
        private Button btnXoaA;
        private Button btnXoaB;
        private Button btnKetThuc;
        private ComboBox cboLop;
        private Label lblLop;
        // Menu
        private MenuStrip menuStripMain;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuCapNhatLopA;
        private ToolStripMenuItem mnuCapNhatLopB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuChuyenPhanTuSangLopA;
        private ToolStripMenuItem mnuChuyenPhanTuSangLopB;
        private ToolStripMenuItem mnuChuyenHetSangLopA;
        private ToolStripMenuItem mnuChuyenHetSangLopB;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuXoaDanhSachLopA;
        private ToolStripMenuItem mnuXoaDanhSachLopB;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripMenuItem mnuKetThucMenu;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTen = new TextBox();
            lblTen = new Label();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnRight = new Button();
            btnLeft = new Button();
            btnAllRight = new Button();
            btnAllLeft = new Button();
            btnXoaA = new Button();
            btnXoaB = new Button();
            btnKetThuc = new Button();
            menuStripMain = new MenuStrip();
            mnuCapNhat = new ToolStripMenuItem();
            mnuCapNhatLopA = new ToolStripMenuItem();
            mnuCapNhatLopB = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuChuyenPhanTuSangLopA = new ToolStripMenuItem();
            mnuChuyenPhanTuSangLopB = new ToolStripMenuItem();
            mnuChuyenHetSangLopA = new ToolStripMenuItem();
            mnuChuyenHetSangLopB = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuXoaDanhSachLopA = new ToolStripMenuItem();
            mnuXoaDanhSachLopB = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            mnuKetThucMenu = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(100, 38);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(420, 27);
            txtTen.TabIndex = 1;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(12, 41);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(56, 20);
            lblTen.TabIndex = 13;
            lblTen.Text = "Tên SV:";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(540, 36);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(100, 26);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Visible = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(25, 104);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(260, 244);
            lstLopA.TabIndex = 3;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(446, 104);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(260, 244);
            lstLopB.TabIndex = 4;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(300, 124);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(80, 30);
            btnRight.TabIndex = 5;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Visible = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(300, 204);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(80, 30);
            btnLeft.TabIndex = 7;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Visible = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnAllRight
            // 
            btnAllRight.Location = new Point(300, 164);
            btnAllRight.Name = "btnAllRight";
            btnAllRight.Size = new Size(80, 30);
            btnAllRight.TabIndex = 6;
            btnAllRight.Text = ">>";
            btnAllRight.UseVisualStyleBackColor = true;
            btnAllRight.Visible = false;
            btnAllRight.Click += btnAllRight_Click;
            // 
            // btnAllLeft
            // 
            btnAllLeft.Location = new Point(300, 244);
            btnAllLeft.Name = "btnAllLeft";
            btnAllLeft.Size = new Size(80, 30);
            btnAllLeft.TabIndex = 8;
            btnAllLeft.Text = "<<";
            btnAllLeft.UseVisualStyleBackColor = true;
            btnAllLeft.Visible = false;
            btnAllLeft.Click += btnAllLeft_Click;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(12, 354);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(120, 30);
            btnXoaA.TabIndex = 9;
            btnXoaA.Text = "Xóa Lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Visible = false;
            btnXoaA.Click += btnXoaLopA_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(586, 354);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(120, 30);
            btnXoaB.TabIndex = 11;
            btnXoaB.Text = "Xóa Lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Visible = false;
            btnXoaB.Click += btnXoaLopB_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(300, 354);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(80, 30);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Visible = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuHeThong });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(720, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain";
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuCapNhatLopA, mnuCapNhatLopB, toolStripSeparator1, mnuChuyenPhanTuSangLopA, mnuChuyenPhanTuSangLopB, mnuChuyenHetSangLopA, mnuChuyenHetSangLopB, toolStripSeparator2, mnuXoaDanhSachLopA, mnuXoaDanhSachLopB });
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(85, 24);
            mnuCapNhat.Text = "Cập Nhật";
            // 
            // mnuCapNhatLopA
            // 
            mnuCapNhatLopA.Name = "mnuCapNhatLopA";
            mnuCapNhatLopA.Size = new Size(315, 26);
            mnuCapNhatLopA.Text = "Cập Nhật Lớp A";
            mnuCapNhatLopA.Click += btnCapNhat_Click;
            // 
            // mnuCapNhatLopB
            // 
            mnuCapNhatLopB.Name = "mnuCapNhatLopB";
            mnuCapNhatLopB.Size = new Size(315, 26);
            mnuCapNhatLopB.Text = "Cập Nhật Lớp B";
            mnuCapNhatLopB.Click += mnuCapNhatLopB_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(312, 6);
            // 
            // mnuChuyenPhanTuSangLopA
            // 
            mnuChuyenPhanTuSangLopA.Name = "mnuChuyenPhanTuSangLopA";
            mnuChuyenPhanTuSangLopA.Size = new Size(315, 26);
            mnuChuyenPhanTuSangLopA.Text = "Chuyển Phần Tử Chọn Sang Lớp A";
            mnuChuyenPhanTuSangLopA.Click += btnLeft_Click;
            // 
            // mnuChuyenPhanTuSangLopB
            // 
            mnuChuyenPhanTuSangLopB.Name = "mnuChuyenPhanTuSangLopB";
            mnuChuyenPhanTuSangLopB.Size = new Size(315, 26);
            mnuChuyenPhanTuSangLopB.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            mnuChuyenPhanTuSangLopB.Click += btnRight_Click;
            // 
            // mnuChuyenHetSangLopA
            // 
            mnuChuyenHetSangLopA.Name = "mnuChuyenHetSangLopA";
            mnuChuyenHetSangLopA.Size = new Size(315, 26);
            mnuChuyenHetSangLopA.Text = "Chuyển Hết ds sang lớp A";
            mnuChuyenHetSangLopA.Click += btnAllLeft_Click;
            // 
            // mnuChuyenHetSangLopB
            // 
            mnuChuyenHetSangLopB.Name = "mnuChuyenHetSangLopB";
            mnuChuyenHetSangLopB.Size = new Size(315, 26);
            mnuChuyenHetSangLopB.Text = "Chuyển Hết ds Sang lớp B";
            mnuChuyenHetSangLopB.Click += btnAllRight_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(312, 6);
            // 
            // mnuXoaDanhSachLopA
            // 
            mnuXoaDanhSachLopA.Name = "mnuXoaDanhSachLopA";
            mnuXoaDanhSachLopA.Size = new Size(315, 26);
            mnuXoaDanhSachLopA.Text = "Xóa Danh Sách Lớp A";
            mnuXoaDanhSachLopA.Click += mnuRemoveSelectedLopA_Click;
            // 
            // mnuXoaDanhSachLopB
            // 
            mnuXoaDanhSachLopB.Name = "mnuXoaDanhSachLopB";
            mnuXoaDanhSachLopB.Size = new Size(315, 26);
            mnuXoaDanhSachLopB.Text = "Xóa Danh Sách Lớp B";
            mnuXoaDanhSachLopB.Click += mnuRemoveSelectedLopB_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin, mnuKetThucMenu });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(224, 26);
            mnuThongTin.Text = "Thông Tin";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // mnuKetThucMenu
            // 
            mnuKetThucMenu.Name = "mnuKetThucMenu";
            mnuKetThucMenu.Size = new Size(224, 26);
            mnuKetThucMenu.Text = "Kết Thúc";
            mnuKetThucMenu.Click += btnKetThuc_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            ClientSize = new Size(720, 420);
            Controls.Add(menuStripMain);
            Controls.Add(btnXoaB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaA);
            Controls.Add(btnAllLeft);
            Controls.Add(btnLeft);
            Controls.Add(btnAllRight);
            Controls.Add(btnRight);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += Form1_FormClosing;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ContextMenuStrip contextMenuStrip1;
    }
}
