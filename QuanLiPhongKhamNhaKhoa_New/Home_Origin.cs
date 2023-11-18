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

        private void toolStripMedical_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            MedicalTicket mdform = new MedicalTicket(this);
            mdform.TopLevel = false;
            panelDoctor.Controls.Add(mdform);
            mdform.Show();
        }

        private void toolStripLabelWaitingRoom_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            waitingRoom waitform = new waitingRoom(this);
            waitform.TopLevel = false;
            panelDoctor.Controls.Add(waitform);
            waitform.Show();
        }

        private void toolStripService_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            ServiceTicket serviceform = new ServiceTicket(this);
            serviceform.TopLevel = false;
            panelDoctor.Controls.Add(serviceform);
            serviceform.Show();
        }

        

        private void toolStripResuft_Click(object sender, EventArgs e)
        {
            panelDoctor.Controls.Clear();
            resuftTicket resuftform = new resuftTicket(this);
            resuftform.TopLevel = false;
            panelDoctor.Controls.Add(resuftform);
            resuftform.Show();
        }
    }
}
