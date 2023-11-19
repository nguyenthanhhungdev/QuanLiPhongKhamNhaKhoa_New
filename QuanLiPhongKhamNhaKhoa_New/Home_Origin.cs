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
    public partial class Home_Origin : Form
    {
        public Home_Origin()
        {
            InitializeComponent();
        }

        private void toolStripLabelQLBN_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiBenhNhan qlbenhNhan = new QuanLiBenhNhan();
            qlbenhNhan.TopLevel = false;
            panel1.Controls.Add(qlbenhNhan);
            qlbenhNhan.Dock = DockStyle.Fill;
            qlbenhNhan.Show();
        }

        private void toolStripLabelQLBS_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiBacSi quanLiBacSi = new QuanLiBacSi();
            quanLiBacSi.TopLevel = false;
            panel1.Controls.Add(quanLiBacSi);
            quanLiBacSi.BringToFront();
            quanLiBacSi.Show();

        }

        private void toolStripLabelQLNV_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiNhanVien quanLiNhanVien = new QuanLiNhanVien();
            quanLiNhanVien.TopLevel = false;
            panel1.Controls.Add(quanLiNhanVien);
            quanLiNhanVien.BringToFront();
            quanLiNhanVien.Show();
        }

        private void toolStripLabelQLPK_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiPhongKham quanLiPhongKham = new QuanLiPhongKham();
            quanLiPhongKham.TopLevel = false;
            panel1.Controls.Add(quanLiPhongKham);
            quanLiPhongKham.BringToFront();
            quanLiPhongKham.Show();
        }

        private void toolStripLabelQLLDV_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiLoaiDichVu quanLiLoaiDichVu = new QuanLiLoaiDichVu();
            quanLiLoaiDichVu.TopLevel = false;
            panel1.Controls.Add(quanLiLoaiDichVu);
            quanLiLoaiDichVu.BringToFront();
            quanLiLoaiDichVu.Show();
        }

        private void toolStripLabelQLDV_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLiDichVu quanLiDichVu = new QuanLiDichVu();
            quanLiDichVu.TopLevel = false;
            panel1.Controls.Add(quanLiDichVu);
            quanLiDichVu.BringToFront();
            quanLiDichVu.Show();
        }
    }
}
