using System;
using System.IO;
using System.Text;
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
        private bool hasRead = false;

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
                }
                else if (maskedTextBoxMatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                }
                else if (DataProvider
                             .ExecuteQuery(sql).Rows.Count == 0)
                {
                    int num1 = (int)MessageBox.Show("MÃ HOẶC PASSWORD KHÔNG ĐÚNG");
                }
                else
                {
                    int num2 = (int)MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                    this.Hide();
                    new Home_Origin().Show();
                    hasLogin = true;
                    write();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi hệ thống: \n" + exception.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hasRead = checkBox1.Checked;
        }

        private void write()
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream("data.txt", FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    if (checkBox1.Checked) writer.WriteLine("true");
                    else writer.WriteLine("false");
                    writer.WriteLine(textBoxMa.Text);
                    writer.WriteLine(maskedTextBoxMatKhau.Text);
                    writer.Close();
                    fileStream.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Load();
                MessageBox.Show("Kết nối database thành công");

                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream("data.txt", FileMode.OpenOrCreate);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line;
                        int dem = 0;
                        bool check = reader.ReadLine()?.Equals("true") ?? false;
                        while (((line = reader.ReadLine()) != null) && check)
                        {
                            checkBox1.Checked = true;
                            if (dem == 0) textBoxMa.Text = line;
                            else if (dem == 1) maskedTextBoxMatKhau.Text = line;
                            dem++;
                        }

                        reader.Close();
                        fileStream.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi kết nối database");
            }
        }

        private void buttonQuenMK_Click(object sender, EventArgs e)
        {
            new QuenMatKhau().Show();
            this.Hide();
        }
    }
}