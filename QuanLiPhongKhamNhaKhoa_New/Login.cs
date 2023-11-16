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
        private bool isBs;
        private bool isNv;
        private bool hasLogin = false;

        public bool IsBs
        {
            get => isBs;
            set => isBs = value;
        }

        public bool IsBs1
        {
            get => isBs;
            set => isBs = value;
        }

        public bool IsNv
        {
            get => isNv;
            set => isNv = value;
        }

        public bool HasLogin
        {
            get => hasLogin;
            set => hasLogin = value;
        }

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
                var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            Application.Exit();
        }

        // private SqlConnection conn;

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataProvider
                        .ExecuteQuery(string.Format("SELECT * FROM BACSI WHERE MaNV = '{0}' AND MatKhau = '{1}'",
                            (object)this.textBoxMa.Text, (object)this.maskedTextBoxMatKhau.Text)).Rows.Count == 0)
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

        private void Losing(object sender, EventArgs e)
        {
            if (!hasLogin)
            {
                var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}