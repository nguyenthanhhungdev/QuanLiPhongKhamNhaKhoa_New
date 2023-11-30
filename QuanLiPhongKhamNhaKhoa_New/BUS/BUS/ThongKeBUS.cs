using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongKe
{
    internal class ThongKeBUS
    {
        public void LoadThongKe(DataGridView dgv ,string fDay, string lDay, Label text)
        {
            ThongKeDAO tk = new ThongKeDAO();
            dgv.DataSource = tk.getAll(fDay, lDay);
            DataTable dt = tk.getTongTienAll(fDay, lDay);
            foreach (DataRow row in dt.Rows)
            {
                text.Text = row["ThanhTien"].ToString();
            }
        }

        public void LoadThongKeTungDV(DataGridView dgv,string fDay, string lDay, string tenDV, Label text)
        {
            ThongKeDAO tk = new ThongKeDAO();
            dgv.DataSource = tk.getLoaiDichVu(fDay, lDay, tenDV);
            DataTable dt = tk.getTongTienTungDV(fDay, lDay, tenDV);
            foreach (DataRow row in dt.Rows)
            {
                text.Text = row["ThanhTien"].ToString();
            }
        }

        public void showcbb(ComboBox cbb)
        {
            ThongKeDAO tk = new ThongKeDAO();
            DataTable dt = tk.listDichVu();
            foreach (DataRow row in dt.Rows)
            {
                cbb.Items.Add(row["TenDV"]);
            }

        }
        public int Count(string fDay,string lDay)
        {
            ThongKeDAO tk = new ThongKeDAO();
            return tk.getAll(fDay, lDay).Rows.Count;
        }
        public int Count2(string fDay, string lDay,string tenDV)
        {
            ThongKeDAO tk = new ThongKeDAO();
            return tk.getLoaiDichVu(fDay, lDay, tenDV).Rows.Count;
        }
        public void LoadTongThongKeTungDV(DataGridView dgv, string fDay, string lDay)
        {
            ThongKeDAO tk = new ThongKeDAO();
            dgv.DataSource = tk.getTungDV(fDay, lDay);
        }
    }
}
