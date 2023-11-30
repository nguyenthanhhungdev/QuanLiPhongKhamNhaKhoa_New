using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Templates;
using DTO;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class Login : Form
    {
        public static bool isBs = false;
        public static bool hasLogin = false;
        public static bool isAdmin = false;
        public static UserDTO dto;
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
      string sqlBS = string.Format("SELECT * FROM BACSI WHERE TinhTrang = 'True' AND MaBS = '{0}' AND MatKhau = '{1}'", (object) this.textBoxMa.Text, (object) this.maskedTextBoxMatKhau.Text);
      string sqlNV = string.Format("SELECT * FROM NHANVIEN WHERE TinhTrang = 'True' AND MaNV = '{0}' AND MatKhau = '{1}'", (object) this.textBoxMa.Text, (object) this.maskedTextBoxMatKhau.Text);
      string sql = textBoxMa.Text.Contains("BS") ? sqlBS : sqlNV;
      Login.isAdmin = this.textBoxMa.Text.Contains("BS01");
      Login.isBs = this.textBoxMa.Text.Contains("BS");
      try
      {
        if (this.textBoxMa.Text.Length == 0)
        {
          int num1 = (int) MessageBox.Show("Mã không được để trống");
        }
        else if (this.maskedTextBoxMatKhau.Text.Length == 0)
        {
          int num2 = (int) MessageBox.Show("Mật khẩu không được để trống");
        }
        else
        {
          DataTable dataTable = DataProvider.ExecuteQuery(sql);
          if (dataTable.Rows.Count == 0)
          {
            int num1_1 = (int) MessageBox.Show("MÃ HOẶC PASSWORD KHÔNG ĐÚNG");
          }
          else
          {
            if (Login.isBs)
            {
              IEnumerator enumerator = dataTable.Rows.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  DataRow row = (DataRow) enumerator.Current;
                  BacSiDTO bacSiDto = new BacSiDTO();
                  bacSiDto.Ma = row.Field<string>("MaBS");
                  bacSiDto.Ten = row.Field<string>("TenBS");
                  bacSiDto.DiaChi = row.Field<string>("DiaChi");
                  bacSiDto.NgSinh = row.Field<DateTime>("NgSinh");
                  bacSiDto.Sdt = row.Field<string>("SDT");
                  bacSiDto.Email = row.Field<string>("Email");
                  bacSiDto.GioiTinh = row.Field<string>("GioiTinh");
                  bacSiDto.CaLam = row.Field<string>("CaLam");
                  bacSiDto.MatKhau = row.Field<string>("MatKhau");
                  bacSiDto.MaPhong = row.Field<string>("MaPhong");
                  Login.dto = (UserDTO) bacSiDto;
                }
              }
              finally
              {
                if (enumerator is IDisposable disposable)
                  disposable.Dispose();
              }
            }
            else
            {
              IEnumerator enumerator = dataTable.Rows.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  DataRow row = (DataRow) enumerator.Current;
                  NhanVienDTO nhanVienDto = new NhanVienDTO();
                  nhanVienDto.Ma = row.Field<string>("MaNV");
                  nhanVienDto.Ten = row.Field<string>("TenNV");
                  nhanVienDto.DiaChi = row.Field<string>("DiaChi");
                  nhanVienDto.NgSinh = row.Field<DateTime>("NgSinh");
                  nhanVienDto.Sdt = row.Field<string>("SDT");
                  nhanVienDto.Email = row.Field<string>("Email");
                  nhanVienDto.GioiTinh = row.Field<string>("GioiTinh");
                  nhanVienDto.CaLam = row.Field<string>("CaLam");
                  nhanVienDto.MatKhau = row.Field<string>("MatKhau");
                  Login.dto = (UserDTO) nhanVienDto;
                }
              }
              finally
              {
                if (enumerator is IDisposable disposable)
                  disposable.Dispose();
              }
            }
            int num2_1 = (int) MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
            this.Hide();
            new Home_Origin().Show();
            Login.hasLogin = true;
            this.write();
          }
        }
      }
      catch (Exception exception)
      {
        int num = (int) MessageBox.Show(string.Concat("Lỗi hệ thống: \n", exception.Message));
      }
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            textBoxMa.Focus();
        }

        private void buttonQuenMK_Click(object sender, EventArgs e)
        {
            new QuenMatKhau().Show();
            this.Hide();
        }
    }
}