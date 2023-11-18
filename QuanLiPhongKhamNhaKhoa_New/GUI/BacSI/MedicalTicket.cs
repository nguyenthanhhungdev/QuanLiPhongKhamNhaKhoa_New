﻿using BUS;
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

namespace QuanLiPhongKhamNhaKhoa_New.GUI.BacSI
{
    public partial class MedicalTicket : Form
    {
        private readonly Home_Origin homeOriginInstance ;
        private readonly BenhNhanBUS BNBUS = new BenhNhanBUS();
        private readonly PhieuDichVuBUS PDVBUS = new PhieuDichVuBUS();
        public DataTable PDVTbl;
        public DataTable BNTbl;
        public MedicalTicket(Home_Origin home)
        {
            InitializeComponent();
            homeOriginInstance = home;
            BNTbl = BNBUS.GetList();
            PDVTbl = PDVBUS.GetListPhieuDv();
        }
        public MedicalTicket()
        {
            InitializeComponent();
            
        }
        public bool isMedicalFormVisible = false;
        private void btnService_Click(object sender, EventArgs e)
        {
            if (isMedicalFormVisible)
            {
                MessageBox.Show("Đang Lập Phiếu Dịch Vụ Rồi!");
                return;
            }
            // Kiểm tra các trường có trống không

            string sdt = txtSdt.Text.Trim();
            string diaChi = txtDC.Text.Trim();
            string mabn=txtMaBN.Text.Trim();
            string ngsinh=txtNgS.Text.Trim();
            string cmnd=txtCmnd.Text.Trim();

            if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(mabn)||string.IsNullOrEmpty(ngsinh) || string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Các trường không được để trống không được để trống.");
                return;
            }
            // Kiểm tra định dạng số điện thoại
            if (!IsPhoneNumberValid(sdt))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.");
                return;
            }
            isMedicalFormVisible = true;
            ServiceTicket svtk = new ServiceTicket(homeOriginInstance);
            svtk.FormClosed += (s, args) => { isMedicalFormVisible = false; };
            svtk.TopLevel = false;
            homeOriginInstance.panelDoctor.Controls.Add(svtk);
            svtk.Show();
            svtk.BringToFront();
            
            //tạo ra 1 datatable mới chứa nội dung mới
            DataTable BNTblNew=new DataTable();
            BNTblNew = BNTbl.Clone();
            DataRow newRow = BNTblNew.NewRow();

            // Gán giá trị cho các cột của dòng mới
            newRow["MaBN"] = txtMaBN.Text.ToString();
            newRow["TenBN"] = txtTen.Text.ToString();
            newRow["GioiTinh"] = txtGT.Text.ToString();
            newRow["CMND"] = txtCmnd.Text.ToString();
            newRow["NgSinh"] = txtNgS.Text.ToString();
            newRow["SDT"] = txtSdt.Text.ToString();
            newRow["DiaChi"] = txtDC.Text.ToString();
            newRow["BenhLy"] = txtBL.Text.ToString();
            // Thêm dòng mới vào DataTable
            BNTblNew.Rows.Add(newRow);
            if(BNBUS.UpdateBN(BNTblNew))
            {
                //MessageBox.Show("cập nhật thành công!");
                string maphieu = autoMaPhieu(PDVTbl.Rows.Count + 1);
                svtk.txtMaBN.Text = BNTblNew.Rows[0]["MaBN"].ToString();
                svtk.txtTen.Text = BNTblNew.Rows[0]["TenBN"].ToString();
                svtk.txtSdt.Text = BNTblNew.Rows[0]["SDT"].ToString();
                svtk.txtNgS.Text = BNTblNew.Rows[0]["NgSinh"].ToString();
                svtk.txtGT.Text = BNTblNew.Rows[0]["GioiTinh"].ToString();
                svtk.txtCmnd.Text = BNTblNew.Rows[0]["CMND"].ToString();
                svtk.txtDC.Text = BNTblNew.Rows[0]["DiaChi"].ToString();
                svtk.txtBL.Text = BNTblNew.Rows[0]["BenhLy"].ToString();
                svtk.txtPDV.Text = maphieu;
                svtk.txtLK.Text=txtLK.Text.ToString();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật!");
                return;
            }
            
        }
        public string autoMaPhieu(int soPhieu)
        {
            string maPhieu = soPhieu.ToString("D4");
            return maPhieu;
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy (Regular Expression) để kiểm tra số điện thoại
            string pattern = @"^0[39]\d{8}$";
            Regex regex = new Regex(pattern);

            // Kiểm tra sự khớp của số điện thoại với biểu thức chính quy
            return regex.IsMatch(phoneNumber);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
