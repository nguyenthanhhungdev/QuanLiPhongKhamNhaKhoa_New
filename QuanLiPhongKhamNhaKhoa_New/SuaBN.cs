using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New.BUS.BUS
{
    public partial class SuaBN : Form
    {
        BenhNhanBUS bn = new BenhNhanBUS();
        public SuaBN()
        {
            InitializeComponent();
        }

        public SuaBN(string maBN, string tenBN, string cmnd, string diachi, string ngaysinh, string sdt, string benhLy, string gioiTinh)
        {
            InitializeComponent();
            txtMaBN.Text = maBN;
            txtTenBN.Text = tenBN;
            txtCMND.Text = cmnd;
            txtDiaChi.Text = diachi;
            dtpNgaySinh.Value = DateTime.Parse(ngaysinh);
            txtSDT.Text = sdt;
            gioiTinh = gioiTinh.ToLower();
            if (gioiTinh == "nam")
            {
                radioNam.Checked = true;
                radioNu.Checked = false;
            }
            else if (gioiTinh == "nữ")
            {
                radioNu.Checked = true;
                radioNam.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            if (!IsValidName(txtTenBN.Text.Trim()))
            {
                MessageBox.Show("Tên Chưa Đúng Định Dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsPhoneNumberValid(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bn.SuaBN(txtMaBN.Text, txtCMND.Text, txtDiaChi.Text, txtSDT.Text);
            MessageBox.Show("Sửa thông tin bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private bool IsValidName(string name)
        {
            // Kiểm tra xem tên có chứa ký tự đặc biệt và số hay không
            return !Regex.IsMatch(name, @"\d");
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy (Regular Expression) để kiểm tra số điện thoại
            string pattern = @"^0\d{9}$";
            Regex regex = new Regex(pattern);
            // Kiểm tra sự khớp của số điện thoại với biểu thức chính quy
            return regex.IsMatch(phoneNumber);
        }
    }
}
