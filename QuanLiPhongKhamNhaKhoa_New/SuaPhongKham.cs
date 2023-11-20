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
    public partial class SuaPhongKham : Form
    {
        public SuaPhongKham(string maP, string tenP)
        {
            InitializeComponent();
            // Hiển thị thông tin trên các controls của form
            textBox1.Text = maP;
            textBox2.Text = tenP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maP = textBox1.Text;
            string tenP = textBox2.Text;
            if (string.IsNullOrWhiteSpace(tenP) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PhongKhamBUS phongKhamBUS = new PhongKhamBUS();
            phongKhamBUS.SuaPhongKham(maP,tenP);
            DialogResult dr = MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
