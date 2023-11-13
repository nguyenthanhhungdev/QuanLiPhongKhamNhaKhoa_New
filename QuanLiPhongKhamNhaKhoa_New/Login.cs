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

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class Login : Form
    {
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
            {
                // Chuyển con trỏ xuống ô maskedtextbox nhập mật khẩu
                maskedTextBoxMatKhau.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Nếu phím enter được nhấn
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện sự kiện click cho nút login
                
            }
        }


        private SqlConnection conn =
            new SqlConnection(
                @"Data Source=DESKTOP-CQKNKFS\SQLEXPRESS;Initial Catalog=PhongKhamNhaKhoa;User ID=sa;Password=1405hung");

        private String sqlString;
        private SqlCommand _command;
        private SqlDataReader _reader1, _reader2;
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            String ma, password;
            ma = textBoxMa.Text;
            password = maskedTextBoxMatKhau.Text;

            try
            {
                sqlString = "SELECT * FROM NHANVIEN WHERE MaNV = @ma AND MatKhau = @matKhau";
                _command = new SqlCommand(sqlString, conn);
                _command.Parameters.AddWithValue("@ma", ma);
                _command.Parameters.AddWithValue("@matKhau", password);
                
                conn.Open();

                _reader1 = _command.ExecuteReader();

                if (_reader1.Read())
                {
                    Application.Run(new Home_Origin());
                    this.Hide();
                }
                else
                {
                    sqlString = "SELECT * FROM BACSI WHERE MaBS = @ma AND MatKhau = @matKhau";
                    _command = new SqlCommand(sqlString, conn);
                    _command.Parameters.AddWithValue("@ma", ma);
                    _command.Parameters.AddWithValue("@matKhau", password);

                    _reader2 = _command.ExecuteReader();

                    if (_reader2.Read())
                    {
                        Application.Run(new Home_Origin());
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mã hoặc tên đăng nhập sai");
                    }
                }
            }
            catch
            {
            }
            finally
            {

            }
        }
    }
}
