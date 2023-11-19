using BUS;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class SuaLoaiDV : Form
    {
        public SuaLoaiDV(string maLDV, string tenLDV)
        {
            InitializeComponent();
            // Hiển thị thông tin trên các controls của form
            textBox1.Text = maLDV;
            textBox2.Text = tenLDV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maLDV = textBox1.Text;
            string tenLDV = textBox2.Text;
            if (string.IsNullOrWhiteSpace(tenLDV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoaiDichVuBUS bus = new LoaiDichVuBUS();
            bus.SuaLoaiDV(maLDV, tenLDV);
            DialogResult dr = MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
