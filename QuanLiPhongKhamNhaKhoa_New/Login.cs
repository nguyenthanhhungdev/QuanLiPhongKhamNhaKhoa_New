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


        private SqlConnection conn;

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            String ma, password;
            ma = textBoxMa.Text;
            password = maskedTextBoxMatKhau.Text;

            // try
            // {
            //     String sqlString = "SELECT * FROM NHANVIEN WHERE MaNV = @ma AND MatKhau = @matKhau";
            //     SqlCommand _command = new SqlCommand(sqlString, conn);
            //     // string getValue = _command.ExecuteScalar().ToString();
            //     _command.Parameters.AddWithValue("@ma", ma);
            //     _command.Parameters.AddWithValue("@matKhau", password);
            //
            //     conn.Open();
            //
            //     SqlDataReader _reader1 = _command.ExecuteReader();
            //
            //     if (_reader1.Read())
            //     {
            //         Application.Run(new Home_Origin());
            //         this.Hide();
            //     }
            //     else
            //     {
                    conn.Close();
                    string sqlString = "SELECT * FROM NHANVIEN WHERE MaNV = @ma AND MatKhau = @matKhau";
                    SqlCommand _command2 = new SqlCommand(sqlString, conn);
                    var maP = new SqlParameter("@ma", ma);
                    var passP = new SqlParameter("@matKhau", password);

                    _command2.Parameters.Add(maP);
                    _command2.Parameters.Add(passP);
            
                    // _command2.Parameters.AddWithValue("@ma", ma);
                    // _command2.Parameters.AddWithValue("@matKhau", password);

                    conn.Open();

                    SqlDataReader _reader2 = _command2.ExecuteReader();

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
            // }
            // catch
            // {
            //     MessageBox.Show("Lỗi không thể đăng nhập");
            // }
            // finally
            // {
            // }
        // }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                conn =
                    new SqlConnection(
                        @"Data Source=DESKTOP-CQKNKFS\SQLEXPRESS;Initial Catalog=PhongKhamNhaKhoa;User ID=sa;Password=1405hung");
                MessageBox.Show("Kết nối database thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi kết nối database");
            }
        }
    }
}