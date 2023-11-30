using BUS;
using DevExpress.XtraWaitForm;
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
    public partial class ThemBacSi : Form
    {
        private readonly BacSiBUS BSBUS = new BacSiBUS();

        public ThemBacSi()
        {
            InitializeComponent();
            HienThiPhong();
            BacSiBUS bus = new BacSiBUS();
            int ma = bus.LayTongBS();
            if (ma  <= 9)
            {
                textBox1.Text = "BS0" + (ma + 1);
            } else
            {
                textBox1.Text = "BS" + (ma + 1);
            }
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
            string maBS = textBox1.Text;
            string tenBS = textBox6.Text;
            string diaChi = textBox5.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string sdt = Regex.Replace(maskedTextBox1.Text, "[^0-9]", "");
            string email = textBox4.Text;
            string matKhau = textBox2.Text;
            string gioiTinh = "";
            string tenPhong = comboBox1.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(tenBS) || string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(tenPhong) || ngaySinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidName(tenBS))
            {
                MessageBox.Show("Tên Không Hợp Lệ!");
                return;
            }
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            if (DateTime.Now.Year - ngaySinh.Year < 30)
            {
                MessageBox.Show("Tuổi của bác sĩ phải lớn hơn 30!");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                return;
            }
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
            DataTable phongbs = BSBUS.laybacsitrongphong(tenPhong);
            foreach(DataRow row in phongbs.Rows)
            {
                if (caLam.ToString().Trim().Equals(row["CaLam"].ToString().Trim()))
                {
                    MessageBox.Show("Đã Có Người Trực Ca Này!");
                    return;
                }
            }
            BacSiBUS bacSiBUS = new BacSiBUS();
            bacSiBUS.ThemBacSi(maBS, tenBS, diaChi, ngay, sdt, email, gioiTinh, caLam, matKhau, tenPhong,"True");

            DialogResult dr = MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string matKhau = dateTimePicker1.Value.ToString("ddMMyyyy");
            textBox2.Text = matKhau;
        }


    }
}

