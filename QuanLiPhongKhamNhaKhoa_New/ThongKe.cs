using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using QuanLiPhongKhamNhaKhoa_New.DAO;


namespace ThongKe
{
    public partial class ThongKe : Form
    {
        

        
        public ThongKe()
        {
            InitializeComponent();
        }


     

        private void Form1_Load(object sender, EventArgs e)
        {
            dtTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDen.Value = DateTime.Now;
            DataProvider.Load();
            DateTime dtT = dtTu.Value;
            DateTime dtD = dtDen.Value;
            string dtTs = String.Format("{0:ddMMyy}", dtT);
            string dtDs = String.Format("{0:ddMMyy}", dtD);
            // LoadThongKe(dtTs, dtDs);
            ThongKeBUS tkb = new ThongKeBUS();
            tkb.LoadThongKe(dgv, dtTs, dtDs, text);
            tkb.showcbb(cbb);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtTu_ValueChanged(object sender, EventArgs e)
        {
            if(dtTu.Value > dtDen.Value) {
                MessageBox.Show("Ngay khong hop le!");
                dtTu.Select();
                return;
                } 
        }

        private void dtTu_Leave(object sender, EventArgs e)
        {
            if (dtTu.Value > dtDen.Value)
            {
                MessageBox.Show("Ngay khong hop le!");
                dtTu.Select();
                return;
            }
        }

        private void dtDen_ValueChanged(object sender, EventArgs e)
        {
            if (dtTu.Value > dtDen.Value)
            {
                MessageBox.Show("Ngay khong hop le!");
                dtTu.Select();
                return;
            }
        }

        private void dtDen_Leave(object sender, EventArgs e)
        {
            if (dtTu.Value > dtDen.Value)
            {
                MessageBox.Show("Ngay khong hop le!");
                dtTu.Select();
                return;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
       
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtT = dtTu.Value;
            DateTime dtD = dtDen.Value;
            string dtTs = String.Format("{0:ddMMyy}", dtT);
            string dtDs = String.Format("{0:ddMMyy}", dtD);
            ThongKeBUS tkb = new ThongKeBUS();
            if (cbb.Text == "Tất cả")
            {
                tkb.LoadThongKe(dgv, dtTs, dtDs, text);
            }
            else
            {
                string cbbText = cbb.Text;
                tkb.LoadThongKeTungDV(dgv, dtTs, dtDs, cbbText, text);            // LoadThongKeTungDV(dtTs, dtDs, cbbText);
            }
            ThongKeDAO tkd = new ThongKeDAO();
            if((tkb.Count(dtTs,dtDs)) == 0)
            {
                text.Text = "";
            }
            if ((tkb.Count2(dtTs, dtDs, cbb.Text)) == 0 && cbb.Text != "Tất cả")
            {
                text.Text = "";
            }


        }
        

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
