using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using QuanLiPhongKhamNhaKhoa_New.DAO;
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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        public void showcbb()
        {
            string query = "select * from DICHVU";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                cbb.Items.Add(row["TenDV"]);
            }
            //cbb.DataSource = DataProvider.ExecuteQuery(query);
            //bb.DisplayMember = "TenDV";
            //bb.ValueMember = "MaDV";
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

            dtTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDen.Value = DateTime.Now;
            //  conn = new SqlConnection(str);
            //  conn.Open();
            DataProvider.Load();
            DateTime dtT = dtTu.Value;
            DateTime dtD = dtDen.Value;
            string dtTs = String.Format("{0:yyyyMMdd}", dtT);
            string dtDs = String.Format("{0:yyyyMMdd}", dtD);



            LoadThongKe(dtTs, dtDs);
            //DateTime dt = dtDen.Value;
            //string dtime = String.Format("{0:yyyyMMdd}", dt);

            //text.Text = dtime;

            showcbb();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtTu_ValueChanged(object sender, EventArgs e)
        {
            if (dtTu.Value > dtDen.Value)
            {
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
        #region methods
        void LoadThongKe(string fDay, string lDay)
        {
            ThongKeDAO tk = new ThongKeDAO();
            dgv.DataSource = tk.getAll(fDay, lDay);
            DataTable dt = tk.getTongTienAll(fDay, lDay);
            foreach (DataRow row in dt.Rows)
            {
                text.Text = row["ThanhTien"].ToString();
            }

        }
        void LoadThongKeTungDV(string fDay, string lDay, string tenDV)
        {
            ThongKeDAO tk = new ThongKeDAO();
            dgv.DataSource = tk.getLoaiDichVu(fDay, lDay, tenDV);
            DataTable dt = tk.getTongTienTungDV(fDay, lDay, tenDV);
            foreach (DataRow row in dt.Rows)
            {
                text.Text = row["ThanhTien"].ToString();
            }
        }
        #endregion
        #region events
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbb.Text == "Tất cả")
            {
                DateTime dtT = dtTu.Value;
                DateTime dtD = dtDen.Value;
                string dtTs = String.Format("{0:yyyyMMdd}", dtT);
                string dtDs = String.Format("{0:yyyyMMdd}", dtD);
                LoadThongKe(dtTs, dtDs);


            }
            else
            {
                DateTime dtT = dtTu.Value;
                DateTime dtD = dtDen.Value;
                string dtTs = String.Format("{0:yyyyMMdd}", dtT);
                string dtDs = String.Format("{0:yyyyMMdd}", dtD);
                string cbbText = cbb.Text;
                LoadThongKeTungDV(dtTs, dtDs, cbbText);


            }
        }
        #endregion

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
