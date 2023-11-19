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

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
            NhanVienBUS bus = new NhanVienBUS();
            int ma = bus.LayTongNV();
            if (ma <= 9)
            {
                textBox1.Text = "NV0" + (ma + 1);
            }
            else
            {
                textBox1.Text = "NV" + (ma + 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maNV = textBox1.Text;
            string tenNV = textBox6.Text;
            string diaChi = textBox5.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string sdt = Regex.Replace(maskedTextBox1.Text, "[^0-9]", "");
            string email = textBox4.Text;
            string matKhau = textBox2.Text;
            if (string.IsNullOrWhiteSpace(tenNV) || string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(email) || ngaySinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            if (DateTime.Now.Year - ngaySinh.Year < 18)
            {
                MessageBox.Show("Tuổi của nhân viên phải lớn hơn 18!");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                return;
            }
            string gioiTinh = "";
            if (NamRadioButton.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (NuRadioButton.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }
            string caLam = "";
            if (sangRadioButton.Checked)
            {
                caLam = "Sáng";
            }
            else if (toiRadioButton.Checked)
            {
                caLam = "Tối";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ca làm!");
                return;
            }
            string ngay = String.Format("{0:MM/dd/yyyy}", ngaySinh);
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            nhanVienBUS.ThemNhanVien(maNV, tenNV, diaChi, ngay, sdt, email, gioiTinh, caLam, matKhau);

            DialogResult dr = MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            string matKhau = dateTimePicker1.Value.ToString("ddMMyyyy");
            textBox2.Text = matKhau;
        }
    }
}
