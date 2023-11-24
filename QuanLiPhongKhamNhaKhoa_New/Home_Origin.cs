using DAO;
using QuanLiPhongKhamNhaKhoa_New.GUI.BacSI;
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
        public static object Instance { get; internal set; }

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

        private void toolStripMedical_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            MedicalTicket mdform = new MedicalTicket();
            mdform.TopLevel = false;
            panelDoctor.Controls.Add(mdform);
            mdform.Show();
        }

        private void toolStripLabelWaitingRoom_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            waitingRoom waitform = new waitingRoom();
            waitform.TopLevel = false;
            panelDoctor.Controls.Add(waitform);
            waitform.Show();
        }

        private void toolStripService_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            ServiceTicket serviceform = new ServiceTicket();
            serviceform.TopLevel = false;
            panelDoctor.Controls.Add(serviceform);
            serviceform.Show();
        }

        

        private void toolStripResuft_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            resuftTicket resuftform = new resuftTicket();
            resuftform.TopLevel = false;
            panelDoctor.Controls.Add(resuftform);
            resuftform.Show();
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

        private void toolStripPay_Click(object sender, EventArgs e)
        {
            PayBill pay=new PayBill();
            pay.TopLevel = false;
            Home_Origin.tabPageLeTan.Controls.Add(pay);
            pay.BringToFront();
            pay.Show();
        }
    }
}
