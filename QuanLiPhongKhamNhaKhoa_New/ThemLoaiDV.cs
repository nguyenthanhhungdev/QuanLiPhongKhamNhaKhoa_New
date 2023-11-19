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
    public partial class ThemLoaiDV : Form
    {
        public ThemLoaiDV()
        {
            InitializeComponent();
            LoaiDichVuBUS bus = new LoaiDichVuBUS();
            int ma = bus.LayTongLDV();
            if (ma <= 9)
            {
                textBox1.Text = "LDV0" + (ma + 1);
            }
            else
            {
                textBox1.Text = "LDV" + (ma + 1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maLDV = textBox1.Text;
            string tenLDV = textBox2.Text;

            if (string.IsNullOrWhiteSpace(tenLDV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoaiDichVuBUS bus = new LoaiDichVuBUS();
            bus.ThemLoaiDV(maLDV, tenLDV);

            DialogResult dr = MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
