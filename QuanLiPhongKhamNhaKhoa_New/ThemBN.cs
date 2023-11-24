using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New.BUS.BUS
{
    public partial class ThemBN : Form
    {
        BenhNhanBUS bn = new BenhNhanBUS();
        public ThemBN()
        {
            InitializeComponent();
            txtMaBN.Text = "BN" + (bn.LayDem() + 1).ToString("D4");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenBN.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            radioNam.Checked = false;
            radioNu.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenBN.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 1)
            {
                MessageBox.Show("Bệnh nhân phải trên 1 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCMND.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập chứng minh nhân dân đủ 12 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioNam.Checked && !radioNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gt = "";
            if (radioNam.Checked)
            {
                gt = "Nam";
            }
            else if (radioNu.Checked)
            {
                gt = "Nữ";
            }
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            bn.ThemBN(txtMaBN.Text, txtTenBN.Text, txtCMND.Text, txtDiaChi.Text, ngay, txtSDT.Text, gt);
            MessageBox.Show("Thêm thành công bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
