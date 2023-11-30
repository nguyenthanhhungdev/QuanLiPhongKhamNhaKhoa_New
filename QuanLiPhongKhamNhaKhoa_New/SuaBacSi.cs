﻿using BUS;
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
    public partial class SuaBacSi : Form
    {
        public SuaBacSi(string maBS, string tenBS, string diaChi, DateTime ngaySinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string tenPhong,string tinhtrang)
        {
            InitializeComponent();
            HienThiPhong();
            // Hiển thị thông tin trên các controls của form
            textBox1.Text = maBS;
            textBox6.Text = tenBS;
            textBox5.Text = diaChi;
            dateTimePicker1.Value = ngaySinh;
            maskedTextBox1.Text = sdt;
            textBox4.Text = email;

            if (tinhtrang.Trim().Equals("True"))
            {
                cbxTT.Checked = true;
            }
            else
            {
                cbxTT.Checked = false;
            }
            if (gioiTinh == "Nam")
            {
                NamRadioButton.Checked = true;
            }
            else if (gioiTinh == "Nữ")
            {
                NuRadioButton.Checked = true;
            }

            if (caLam == "Sáng")
            {
                sangRadioButton.Checked = true;
            }
            else if (caLam == "Tối")
            {
                toiRadioButton.Checked = true;
            }

            textBox2.Text = matKhau;
            comboBox1.Text = tenPhong;
        }
        public void HienThiPhong()
        {
            PhongKhamBUS pk = new PhongKhamBUS();
            DataTable dt = pk.LayTenPhongKham();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenPhong";
            comboBox1.ValueMember = "MaPhong";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string tinhtrang;
            if (cbxTT.Checked)
            {
                tinhtrang = "True";
            }
            else
            {
                tinhtrang = "False";
            }
            string maBS = textBox1.Text;
            string tenBS = textBox6.Text;
            string diaChi = textBox5.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string sdt = Regex.Replace(maskedTextBox1.Text, "[^0-9]", "");
            string email = textBox4.Text;
            string matKhau = textBox2.Text;
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

            string tenPhong = comboBox1.SelectedValue.ToString();
            if ( string.IsNullOrWhiteSpace(diaChi) ||string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau) || ngaySinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!" + sdt);
                return;
            }
            
            if (!IsValidName(tenBS))
            {
                MessageBox.Show("Tên Không Hợp Lệ!");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                return;
            }
            
            string ngay = String.Format("{0:MM/dd/yyyy}", ngaySinh);
            BacSiBUS bacSiBUS = new BacSiBUS();
            bacSiBUS.SuaBacSi(maBS, tenBS, diaChi, ngay, sdt, email, gioiTinh, caLam, matKhau, tenPhong, tinhtrang);

            DialogResult dr = MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
        private bool IsValidName(string name)
        {
            // Kiểm tra xem tên có chứa ký tự đặc biệt và số hay không
            return !Regex.IsMatch(name, @"\d");
        }
        private bool IsValidEmail(string email)
        {
            email = email.Trim();
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
