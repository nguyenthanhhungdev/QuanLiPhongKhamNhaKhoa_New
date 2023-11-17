using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class Login : Form
    {
        public static bool isBs = false;
        public static bool isNv = false;
        public static bool hasLogin = false;
        public static bool isAdmin = false;
        public Login()
        {
            InitializeComponent();
        }

        private void checkBoxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxMatKhau.PasswordChar = checkBoxHienMatKhau.Checked ? '\0' : '*';
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                // Chuyển con trỏ xuống ô maskedtextbox nhập mật khẩu
                maskedTextBoxMatKhau.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu phím enter được nhấn
            if (e.KeyCode == Keys.Enter)
                // Thực hiện sự kiện click cho nút login
                buttonDangNhap_Click(sender, new EventArgs());
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hasLogin)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn đóng không?", "Xác nhận", MessageBoxButtons.YesNo);

                // Nếu người dùng chọn Yes, thì đóng form
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        // private SqlConnection conn;

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string sqlBS = string.Format("SELECT * FROM BACSI WHERE MaBS = '{0}' AND MatKhau = '{1}'",
                (object)this.textBoxMa.Text, (object)this.maskedTextBoxMatKhau.Text);
            string sqlNV = string.Format("SELECT * FROM NHANVIEN WHERE MaNV = '{0}' AND MatKhau = '{1}'",
                (object)this.textBoxMa.Text, (object)this.maskedTextBoxMatKhau.Text);

            string sql = textBoxMa.Text.Contains("BS") ? sqlBS : sqlNV;
            isAdmin = textBoxMa.Text.Contains("BS01") ? true : false;
            
            try
            {
                if (textBoxMa.Text.Length == 0)
                {
                    MessageBox.Show("Mã không được để trống");
                    return;
                } else if (maskedTextBoxMatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                } else if (DataProvider
                          .ExecuteQuery(sql).Rows.Count == 0)
                {
                    int num1 = (int)MessageBox.Show("MÃ HOẶC PASSWORD KHÔNG ĐÚNG");
                }
                else
                {
                    int num2 = (int)MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                    this.Hide();
                    new Home_Origin().Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi hệ thống: \n" +  exception.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Load();
                MessageBox.Show("Kết nối database thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi kết nối database");
            }
        }

        private void buttonQuenMK_Click(object sender, EventArgs e)
        {
            new QuenMatKhau().Show();
        }
    }
}