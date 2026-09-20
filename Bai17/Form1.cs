using System;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            // Always add the new student name to lstLopA as requested
            string strDuLieu = txtTen.Text.Trim();
            lstLopA.Items.Add(strDuLieu);

            txtTen.Clear();
            txtTen.Focus();
        }

        // Remove selected items from a ListBox using safe while loop
        private void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
            }
        }

        // Remove items from Lop A with confirmation; uses xoaDuLieu to remove selected items
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            // Confirm then clear entire Lớp A list so all names (e.g. "thành", "huy") are removed
            if (lstLopA.Items.Count > 0)
            {
                var hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp A?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    lstLopA.Items.Clear();
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        // Remove items from Lop B with confirmation; uses xoaDuLieu to remove selected items
        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            // Confirm then clear entire Lớp B list
            if (lstLopB.Items.Count > 0)
            {
                var hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp B?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    lstLopB.Items.Clear();
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        private void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        // (Removed duplicate xoaDuLieu implementation)

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                var hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                var hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                var hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                var hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        // Menu: Add to Lop B (from menu)
        private void mnuCapNhatLopB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            string strDuLieu = txtTen.Text.Trim();
            lstLopB.Items.Add(strDuLieu);
            txtTen.Clear();
            txtTen.Focus();
        }

        // Menu: show about/info
        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài tập 14 - Hệ thống quản lý danh sách lớp\nTác giả: (điền tên của bạn)", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Menu: remove selected items from Class A
        private void mnuRemoveSelectedLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count == 0)
            {
                MessageBox.Show("Danh sách Lớp A đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool anySelected = false;
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                if (lstLopA.GetSelected(i)) { anySelected = true; break; }
            }

            if (!anySelected)
            {
                MessageBox.Show("Vui lòng chọn mục để xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa các mục đã chọn khỏi Lớp A?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hoiXoa == DialogResult.Yes)
                xoaDuLieu(lstLopA);
        }

        // Menu: remove selected items from Class B
        private void mnuRemoveSelectedLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count == 0)
            {
                MessageBox.Show("Danh sách Lớp B đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool anySelected = false;
            for (int i = 0; i < lstLopB.Items.Count; i++)
            {
                if (lstLopB.GetSelected(i)) { anySelected = true; break; }
            }

            if (!anySelected)
            {
                MessageBox.Show("Vui lòng chọn mục để xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa các mục đã chọn khỏi Lớp B?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hoiXoa == DialogResult.Yes)
                xoaDuLieu(lstLopB);
        }

        // Removed legacy unused handlers btnXoaA_Click and btnXoaB_Click to avoid confusion.

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn kết thúc chương trình?", "Kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
