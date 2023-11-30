﻿using BUS;
using DocumentFormat.OpenXml.Spreadsheet;
using QuanLiPhongKhamNhaKhoa_New.BUS.BUS;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class HomeTraCuuBN : Form
    {
        BenhNhanBUS bn = new BenhNhanBUS();
        PhieuDichVuBUS phdv = new PhieuDichVuBUS();
        public HomeTraCuuBN()
        {
            InitializeComponent();
            HienThiDSBenhNhan();
        }

        void HienThiDSBenhNhan()
        {
            dataGridView1.DataSource = bn.LayDuLieuBenhNhan();
        }

        void HienThiDSBenhNhan(string maBN, string tenBN, string cmnd, string sdt)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable dt = bn.GetList();
            DataTable dtSearch = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {
                // Kiểm tra xem dòng hiện tại có chứa từ khóa tìm kiếm không
                if (row["MaBN"].ToString().ToUpper().Contains(maBN.ToUpper()) &&
           row["TenBN"].ToString().ToUpper().Contains(tenBN.ToUpper()) &&
           row["CMND"].ToString().ToUpper().Contains(cmnd.ToUpper()) &&
           row["SDT"].ToString().ToUpper().Contains(sdt.ToUpper()))
                {
                    // Nếu có, thêm dòng đó vào DataTable mới
                    dtSearch.ImportRow(row);
                }
            }
            dataGridView1.DataSource = dtSearch;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemBN them = new ThemBN();
            them.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text.Length == 0 && txtTenBN.Text.Length == 0 && txtCMND.Text.Length == 0 && txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HienThiDSBenhNhan();
            }
            else
            {

                HienThiDSBenhNhan(txtMaBN.Text, txtTenBN.Text, txtCMND.Text, txtSDT.Text);
                if (dataGridView1.Rows.Count == 0)
                {
                    DialogResult dr = MessageBox.Show("Không tìm thấy bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        HienThiDSBenhNhan();
                        ThemBN them = new ThemBN();
                        them.Show();
                    }
                    else if (dr == DialogResult.No)
                    {
                        txtMaBN.Text = "";
                        txtTenBN.Text = "";
                        txtCMND.Text = "";
                        txtSDT.Text = "";
                        HienThiDSBenhNhan();
                    }
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string tinhTrang = "";
                
                try
                {
                    DataTable tt = phdv.LayMaTK(row.Cells["MaBN"].Value.ToString());
                    if (tt.Rows.Count == 0)
                    {
                        tinhTrang = "Khám";
                        HomeThemBN formThemBN = new HomeThemBN(row.Cells["MaBN"].Value.ToString(),
                        row.Cells["TenBN"].Value.ToString(),
                        row.Cells["CMND"].Value.ToString(),
                        row.Cells["DiaChi"].Value.ToString(),
                        row.Cells["NgSinh"].Value.ToString(),
                        row.Cells["SDT"].Value.ToString(),
                        row.Cells["BenhLy"].Value.ToString(),
                        row.Cells["GioiTinh"].Value.ToString(), tinhTrang);

                        formThemBN.TopLevel = false;
                        Home_Origin.tabPageLeTan.Controls.Add(formThemBN);
                        formThemBN.Dock = DockStyle.Fill;
                        formThemBN.Show();
                        formThemBN.BringToFront();
                    }
                    else
                    {
                        DateTime date = DateTime.Now;
                        string formattedDateNow = date.ToString("yyyyMMdd");
                        DateTime ngaytk = Convert.ToDateTime(tt.Rows[0]["NgayTK"]);

                        string formattedDateTK = ngaytk.ToString("yyyyMMdd");


                        if (int.Parse(formattedDateTK) > int.Parse(formattedDateNow))
                        {
                            
                            DialogResult result = MessageBox.Show("Bệnh Nhân Đến Tái Khám Sớm! Có Muốn Khám Không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            // Kiểm tra kết quả của hộp thoại
                            if (result == DialogResult.Yes)
                            {
                                tinhTrang = "Khám";
                                HomeThemBN formThemBN = new HomeThemBN(row.Cells["MaBN"].Value.ToString(),
                                row.Cells["TenBN"].Value.ToString(),
                                row.Cells["CMND"].Value.ToString(),
                                row.Cells["DiaChi"].Value.ToString(),
                                row.Cells["NgSinh"].Value.ToString(),
                                row.Cells["SDT"].Value.ToString(),
                                row.Cells["BenhLy"].Value.ToString(),
                                row.Cells["GioiTinh"].Value.ToString(), tinhTrang);

                                formThemBN.TopLevel = false;
                                Home_Origin.tabPageLeTan.Controls.Add(formThemBN);
                                formThemBN.Dock = DockStyle.Fill;
                                formThemBN.Show();
                                formThemBN.BringToFront();
                            }
                        }
                        else if (int.Parse(formattedDateTK) < int.Parse(formattedDateNow))
                        {
                            //MessageBox.Show("");
                            DialogResult result = MessageBox.Show("Bệnh Nhân Quá Hạn Tái Khám! Có Muốn Khám Không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            // Kiểm tra kết quả của hộp thoại
                            if (result == DialogResult.Yes)
                            {
                                tinhTrang = "Khám";
                                HomeThemBN formThemBN = new HomeThemBN(row.Cells["MaBN"].Value.ToString(),
                                row.Cells["TenBN"].Value.ToString(),
                                row.Cells["CMND"].Value.ToString(),
                                row.Cells["DiaChi"].Value.ToString(),
                                row.Cells["NgSinh"].Value.ToString(),
                                row.Cells["SDT"].Value.ToString(),
                                row.Cells["BenhLy"].Value.ToString(),
                                row.Cells["GioiTinh"].Value.ToString(), tinhTrang);

                                formThemBN.TopLevel = false;
                                Home_Origin.tabPageLeTan.Controls.Add(formThemBN);
                                formThemBN.Dock = DockStyle.Fill;
                                formThemBN.Show();
                                formThemBN.BringToFront();
                            }
                               
                        }
                        else
                        {
                            tinhTrang = "Tái Khám";
                            HomeThemBN formThemBN = new HomeThemBN(row.Cells["MaBN"].Value.ToString(),
                            row.Cells["TenBN"].Value.ToString(),
                            row.Cells["CMND"].Value.ToString(),
                            row.Cells["DiaChi"].Value.ToString(),
                            row.Cells["NgSinh"].Value.ToString(),
                            row.Cells["SDT"].Value.ToString(),
                            row.Cells["BenhLy"].Value.ToString(),
                            row.Cells["GioiTinh"].Value.ToString(), tinhTrang);

                            formThemBN.TopLevel = false;
                            Home_Origin.tabPageLeTan.Controls.Add(formThemBN);
                            formThemBN.Dock = DockStyle.Fill;
                            formThemBN.Show();
                            formThemBN.BringToFront();
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }

                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân muốn cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                SuaBN home = new SuaBN(row.Cells["MaBN"].Value.ToString(), row.Cells["TenBN"].Value.ToString(), row.Cells["CMND"].Value.ToString(), row.Cells["DiaChi"].Value.ToString(), row.Cells["NgSinh"].Value.ToString(), row.Cells["SDT"].Value.ToString(), row.Cells["BenhLy"].Value.ToString(), row.Cells["GioiTinh"].Value.ToString());
                home.Show();
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            HienThiDSBenhNhan();
        }

        
    }
}