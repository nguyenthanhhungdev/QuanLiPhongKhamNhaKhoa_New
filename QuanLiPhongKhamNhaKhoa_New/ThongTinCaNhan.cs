using BUS;
using DAO;
using DocumentFormat.OpenXml.InkML;
using DTO;
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
    public partial class ThongTinCaNhan : Form
    {
        private readonly BacSiBUS BSBUS = new BacSiBUS();
        private readonly NhanVienBUS NVBUS = new NhanVienBUS();
        BacSiDTO bacSiDto;
        NhanVienDTO nhanVienDto;
        public ThongTinCaNhan()
        {
            InitializeComponent();
            if (Login.isBs)
            {
                string madangnhap=Login.dto.Ma;
                //MessageBox.Show("madangnhap: " + madangnhap);
                if (madangnhap.StartsWith("BS"))
                {
                    // Mã đăng nhập là của Bác Sĩ
                    bacSiDto = (BacSiDTO)Login.dto;
                    lblMa.Text= lblMa.Text +" Bác Sĩ:";
                    lblTen.Text = lblTen.Text + " Bác Sĩ:";
                    txtMa.Text = bacSiDto.Ma;
                    txtTen.Text = bacSiDto.Ten;
                    txtDC.Text = bacSiDto.DiaChi;
                    txtEmail.Text = bacSiDto.Email;
                    txtSdt.Text = bacSiDto.Sdt;
                    dateNgS.Value = bacSiDto.NgSinh;
                    txtGt.Text = bacSiDto.GioiTinh;
                    txtcalam.Text = bacSiDto.CaLam;
                    txtPhong.Text = bacSiDto.MaPhong;
                }
                
            }
            else
            {
                string madangnhap = Login.dto.Ma;
                //MessageBox.Show("nhanvien");
                if (madangnhap.StartsWith("NV"))
                {
                    // Mã đăng nhập là của Nhân Viên
                    nhanVienDto = (NhanVienDTO)Login.dto;
                    lblMa.Text = lblMa.Text + " Nhân Viên:";
                    lblTen.Text = lblTen.Text + " Nhân Viên:";
                    txtMa.Text = nhanVienDto.Ma;
                    txtTen.Text = nhanVienDto.Ten;
                    txtDC.Text = nhanVienDto.DiaChi;
                    txtEmail.Text = nhanVienDto.Email;
                    txtSdt.Text = nhanVienDto.Sdt;
                    dateNgS.Value = nhanVienDto.NgSinh;
                    txtGt.Text = nhanVienDto.GioiTinh;
                    txtcalam.Text = nhanVienDto.CaLam;
                    lblphong.Visible = false;
                    txtPhong.Visible = false;
                }
            }
        }

        private void btnDmk_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau tdmk=new ThayDoiMatKhau();
            tdmk.TopLevel = false;
            Home_Origin.tabPageCaNhan.Controls.Add(tdmk);
            tdmk.BringToFront();
            //tdmk.Dock = DockStyle.Left;
            tdmk.Show();
        }

        private void btnfix_Click(object sender, EventArgs e)
        {
            if (!txtTen.Text.Trim().Equals("") && !txtDC.Text.Trim().Equals("") && !txtEmail.Text.Trim().Equals("") && !txtSdt.Text.Trim().Equals(""))
            {
                // Kiểm tra định dạng tên
                if (!IsValidName(txtTen.Text.Trim()))
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    return;
                }

                // Kiểm tra định dạng địa chỉ
                if (!IsValidAddress(txtDC.Text.Trim()))
                {
                    MessageBox.Show("Địa chỉ không hợp lệ!");
                    return;
                }
                // Kiểm tra định dạng email
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return;
                }
                // Kiểm tra định dạng số điện thoại
                if (!IsPhoneNumberValid(txtSdt.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return;
                }
                if (Login.isBs)
                {
                    BSBUS.fixInforbacsi(txtMa.Text,txtTen.Text,txtDC.Text,txtEmail.Text,txtSdt.Text);
                    MessageBox.Show("Sửa Thành Công!");
                }
                else
                {
                    NVBUS.fixInfornhanvien(txtMa.Text, txtTen.Text, txtDC.Text, txtEmail.Text, txtSdt.Text);
                    MessageBox.Show("Sửa Thành Công!");
                }
            }
            else
            {
                MessageBox.Show("Các Trường Thông Tin Phải Đầy Đủ!");
            }
        }
        //kiểm tra sdt
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy (Regular Expression) để kiểm tra số điện thoại
            string pattern = @"^0\d{9}$";
            Regex regex = new Regex(pattern);
            // Kiểm tra sự khớp của số điện thoại với biểu thức chính quy
            return regex.IsMatch(phoneNumber);
        }
        //kiểm tra tên
        private bool IsValidName(string name)
        {
            // Kiểm tra xem tên có chứa ký tự đặc biệt và số hay không
            return !Regex.IsMatch(name, @"\d");
        }
        //kiểm tra địa chỉ
        private bool IsValidAddress(string address)
        {
            // Kiểm tra xem địa chỉ có chứa số và chữ, và có thêm 1 ký tự '/' hay không
            return !Regex.IsMatch(address, @"[?><\""':{}[\]!@#$%^&*()]+");
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                Home_Origin frm = (Home_Origin)getParent(this);
                frm.Close();
                Login login = new Login();
                login.Show();
            }
        }
        private Control getParent(Control a)
        {
            if (a is Home_Origin) return a;
            return getParent(a.Parent);
        }
    }
}
