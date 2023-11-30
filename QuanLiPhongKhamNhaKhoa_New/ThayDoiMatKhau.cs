using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class ThayDoiMatKhau : Form
    {
        private readonly BacSiBUS BSBUS = new BacSiBUS();
        private readonly NhanVienBUS NVBUS = new NhanVienBUS();
        BacSiDTO bacSiDto;
        NhanVienDTO nhanVienDto;
        private bool hasConfirm = false;
        public ThayDoiMatKhau()
        {
            InitializeComponent();
            if (Login.isBs)
            {
                string madangnhap = Login.dto.Ma;
                //MessageBox.Show("madangnhap: " + madangnhap);
                if (madangnhap.StartsWith("BS"))
                {
                    // Mã đăng nhập là của Bác Sĩ
                    bacSiDto = (BacSiDTO)Login.dto;
                    txtTenDn.Text = bacSiDto.Ten;
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
                    txtTenDn.Text = nhanVienDto.Ten;
                }
            }
        }
        
        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi mật khẩu không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                if (!txtmkNow.Text.Trim().Equals(""))
                {
                    if(!txtconfirmMk.Text.Trim().Equals("") && !textBoxThayDoiMK.Text.Trim().Equals(""))
                    {
                        if (txtconfirmMk.Text.Trim().Equals(textBoxThayDoiMK.Text.Trim()))
                        {
                            if (Login.isBs)
                            {
                                if (txtmkNow.Text.Trim().Equals(bacSiDto.MatKhau.Trim()))
                                {
                                    BSBUS.fixMKbacsi(bacSiDto.Ma, txtconfirmMk.Text.Trim());
                                    MessageBox.Show("Cập Nhật Thành Công!");
                                }
                                else
                                {
                                    MessageBox.Show("Nhập Sai Mật Khẩu Hiện Tại!");
                                }
                            }
                            else
                            {
                                if (txtmkNow.Text.Trim().Equals(nhanVienDto.MatKhau.Trim()))
                                {
                                    NVBUS.fixMKnhanvien(nhanVienDto.Ma, txtconfirmMk.Text.Trim());
                                    MessageBox.Show("Cập Nhật Thành Công!");
                                }
                                else
                                {
                                    MessageBox.Show("Nhập Sai Mật Khẩu Hiện Tại!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu Xác Nhận Khác với Mật Khẩu Mới!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không Được Để Trống Mật Khẩu Mới Hoặc Xác Nhận Mật Khẩu Mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Không Được Để Trống Mật Khẩu Hiện Tại!");
                }

            }
        }
        private bool IsTextWithoutDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);
            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
