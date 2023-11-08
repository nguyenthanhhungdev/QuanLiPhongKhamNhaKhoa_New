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
            QuanLiBenhNhan qlbenhNhan = new QuanLiBenhNhan();
            qlbenhNhan.TopLevel = false;
            panel1.Controls.Add(qlbenhNhan);
            qlbenhNhan.BringToFront();
            qlbenhNhan.Show();
        }

        private void toolStripLabelQLBS_Click(object sender, EventArgs e)
        {
            QuanLiBacSi quanLiBacSi = new QuanLiBacSi();
            quanLiBacSi.TopLevel = false;
            panel1.Controls.Add(quanLiBacSi);
            quanLiBacSi.BringToFront();
            quanLiBacSi.Show();
        }

        private void toolStripLabelQLNV_Click(object sender, EventArgs e)
        {
            QuanLiNhanVien quanLiNhanVien = new QuanLiNhanVien();
            quanLiNhanVien.TopLevel = false;
            panel1.Controls.Add(quanLiNhanVien);
            quanLiNhanVien.BringToFront();
            quanLiNhanVien.Show();
        }

        private void toolStripLabelQLPK_Click(object sender, EventArgs e)
        {
            QuanLiPhongKham quanLiPhongKham = new QuanLiPhongKham();
            quanLiPhongKham.TopLevel = false;
            panel1.Controls.Add(quanLiPhongKham);
            quanLiPhongKham.BringToFront();
            quanLiPhongKham.Show();
        }
    }
}
