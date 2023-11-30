using BUS;
using DocumentFormat.OpenXml.InkML;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New.DAO.DAO
{
    public partial class HomeThemBN : Form
    {
        TiepDonBNBUS td = new TiepDonBNBUS();
        PhongKhamBUS ph = new PhongKhamBUS();
        BenhNhanBUS bn = new BenhNhanBUS();
        PhieuDichVuBUS phdv = new PhieuDichVuBUS();

        public HomeThemBN()
        {
            InitializeComponent();
            if (!Login.isBs)
            {
                NhanVienDTO NvDto = (NhanVienDTO)Login.dto;
                string manv = NvDto.Ma; // Thay mã phòng bằng mã phòng bác sĩ đăng nhập 
                txtMaNV.Text = manv;
            }
            HienThiPhongKham();
            HienThiDSTiepDon();
        }
        private bool IsCurrentTimeAM()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.Hour >= 7 && currentTime.Hour <= 15;
        }
        private bool IsCurrentTimePM()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.Hour > 15 && currentTime.Hour < 23;
        }

        public HomeThemBN(string maBN, string tenBN, string cmnd, string diachi, string ngaysinh, string sdt, string benhLy, string gioiTinh, string tinhTrang)
        {
            InitializeComponent();
            
            // Kiểm tra null trước khi gán giá trị cho TextBox
            txtMaBN.Text = maBN ?? string.Empty;
            txtTenBN.Text = tenBN ?? string.Empty;
            txtCMND.Text = cmnd ?? string.Empty;
            txtDiaChi.Text = diachi ?? string.Empty;
            dtpNgaySinh.Value = DateTime.Parse(ngaysinh);
            txtSDT.Text = sdt ?? string.Empty;
            if (!Login.isBs)
            {
                NhanVienDTO NvDto = (NhanVienDTO)Login.dto;
                string manv = NvDto.Ma; // Thay mã phòng bằng mã phòng bác sĩ đăng nhập 
                txtMaNV.Text = manv;
            }

            // Kiểm tra giá trị của benhLy
            txtBenhLy.Text = benhLy ?? string.Empty;

            // Kiểm tra và đặt giới tính
            gioiTinh = gioiTinh.ToLower();
            if (gioiTinh == "nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else if (gioiTinh == "nữ")
            {
                rdNu.Checked = true;
                rdNam.Checked = false;
            }

            txtTinhTrang.Text = tinhTrang;
            HienThiDSTiepDon();
            HienThiPhongKham();



        }

        void HienThiDSTiepDon()
        {
            dataGridView1.DataSource = td.LayDSTiepDon();
        }

        void HienThiPhongKham()
        {
            string caLam = "";
            if (IsCurrentTimeAM())
            {
                caLam = "Sáng";
            }
            else if (IsCurrentTimePM())
            {
                caLam = "Tối";
            }
            
            cboPhong.DataSource = ph.LayDSPhong(caLam);
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtBenhLy.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
            txtTinhTrang.Text = "";
            dataGridView1.ClearSelection();
            ActiveControl = null;
            HienThiDSTiepDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!txtMaBN.Text.Trim().Equals("") &&  !txtMaNV.Text.ToString().Trim().Equals(""))
            {
                string ngay = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
                if (!string.IsNullOrEmpty(cboPhong.SelectedValue?.ToString()))
                {
                    if (td.ThemTiepDon(txtMaNV.Text, txtMaBN.Text, cboPhong.SelectedValue.ToString(), ngay, txtTinhTrang.Text))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        txtMaBN.Text = "";
                        txtTenBN.Text = "";
                        txtCMND.Text = "";
                        txtDiaChi.Text = "";
                        txtBenhLy.Text = "";
                        dtpNgaySinh.Value = DateTime.Now;
                        txtSDT.Text = "";
                        txtTinhTrang.Text = "";
                        dataGridView1.ClearSelection();
                        ActiveControl = null;
                        HienThiDSTiepDon();
                        HienThiPhongKham();
                    }
                    else
                    {
                        MessageBox.Show("Bệnh nhân đã được tiếp đón", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không có phòng trống!");
                }
                
            }
            else
            {
                MessageBox.Show("Phải thực hiện tra cứu bệnh nhân!");
            }    
        }
    }
}
