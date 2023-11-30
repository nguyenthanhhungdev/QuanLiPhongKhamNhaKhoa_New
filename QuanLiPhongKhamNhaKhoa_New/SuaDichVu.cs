using BUS;
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
    public partial class SuaDichVu : Form
    {
        public SuaDichVu(string maDV, string tenDV, float gia, string tenLDV)
        {
            InitializeComponent();
            HienThiLoaiDV();
            textBox1.Text = maDV;
            textBox2.Text = tenDV;
            textBox3.Text = gia.ToString();
            comboBox1.Text = tenLDV;

        }
        public void HienThiLoaiDV()
        {
            LoaiDichVuBUS ldv = new LoaiDichVuBUS();
            DataTable dt = ldv.LayDuLieuLoaiDV();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenLDV";
            comboBox1.ValueMember = "MaLDV";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maDV = textBox1.Text;
            string tenDV = textBox2.Text;
            string gia = textBox3.Text;
            string tenLDV = comboBox1.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(tenDV) || string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(gia, out float giaValue))
            {
                MessageBox.Show("Giá phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (giaValue < 0)
            {
                MessageBox.Show("Giá phải là số lớn hơn không!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DichVuBUS dichVuBUS = new DichVuBUS();
            dichVuBUS.SuaDichVu(maDV, tenDV, giaValue, tenLDV);

            DialogResult dr = MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
