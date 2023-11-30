﻿using DAO;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
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
            this.Shown += new EventHandler(loading_Home);
        }
        private void loading_Home(object sender, EventArgs e)
        {
            if (Login.hasLogin)
            {
                //MessageBox.Show("đúng");
                if (Login.isAdmin && Login.isBs)
                {
                    tabControl1.TabPages.Remove(tabPageLeTan);
                }

                if (Login.isBs && !Login.isAdmin)
                {
                    //MessageBox.Show("bác sĩ dõm");
                    tabControl1.TabPages.Remove(tabPageLeTan);
                    tabControl1.TabPages.Remove(tabPageQuanLi);
                    tabControl1.TabPages.Remove(tabPageThongKe);
                }

                if (!Login.isBs && !Login.isAdmin)
                {
                    tabControl1.TabPages.Remove(tabBacSi);
                    tabControl1.TabPages.Remove(tabPageQuanLi);
                    tabControl1.TabPages.Remove(tabPageThongKe);
                }
            }
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
            PayBill pay = new PayBill();
            pay.TopLevel = false;
            tabPageLeTan.Controls.Add(pay);
            pay.BringToFront();
            pay.Dock = DockStyle.Fill;
            pay.Show();
        }

        private void toolStripLabelTraCuuBN_Click(object sender, EventArgs e)
        {
            HomeTraCuuBN home = new HomeTraCuuBN();
            home.TopLevel = false;
            tabPageLeTan.Controls.Add(home);
            home.BringToFront();
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void toolStripLabelThemBN_Click(object sender, EventArgs e)
        {
            HomeThemBN addhome = new HomeThemBN();
            addhome.TopLevel = false;
            tabPageLeTan.Controls.Add(addhome);
            addhome.BringToFront();
            addhome.Dock = DockStyle.Fill;
            addhome.Show();
        }

<<<<<<< HEAD
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.TopLevel = false;
            tabPageThongKe.Controls.Add(tk);
            tk.BringToFront();
            tk.Dock = DockStyle.Left;
            tk.Show();
        }

        private void toolStripLabelTTCN_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ttcn= new ThongTinCaNhan();
            //tabPageCaNhan.Controls.Clear();
            ttcn.TopLevel = false;
            tabPageCaNhan.Controls.Add(ttcn);
            ttcn.BringToFront();
            //ttcn.Dock = DockStyle.Left;
            ttcn.Show();
        }

        private void toolStripLabelTDMK_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau tdmk=new ThayDoiMatKhau();
            //tabPageCaNhan.Controls.Clear();
            tdmk.TopLevel = false;
            tabPageCaNhan.Controls.Add(tdmk);
            tdmk.BringToFront();
            //tdmk.Dock = DockStyle.Left;
            tdmk.Show();
=======
        private void loading_Home(object sender, EventArgs e)
        {
            if (Login.hasLogin)
            {
                if (Login.isAdmin && Login.isBs)
                {
                    tabControl1.TabPages.Remove(tabPageLeTan);
                }

                if (Login.isBs && !Login.isAdmin)
                {
                    tabControl1.TabPages.Remove(tabPageLeTan);
                    tabControl1.TabPages.Remove(tabPageQuanLi);
                    tabControl1.TabPages.Remove(tabPageThongKe);
                }

                if (!Login.isBs && !Login.isAdmin)
                {
                    tabControl1.TabPages.Remove(tabBacSi);
                    tabControl1.TabPages.Remove(tabPageQuanLi);
                    tabControl1.TabPages.Remove(tabPageThongKe);
                }
            }
>>>>>>> a3d367b7cdb7a0691aa4e212a1a5b1fdbaf7b04b
        }
    }
}