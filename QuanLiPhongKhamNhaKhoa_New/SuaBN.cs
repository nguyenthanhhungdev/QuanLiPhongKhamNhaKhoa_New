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

namespace QuanLiPhongKhamNhaKhoa_New.BUS.BUS
{
    public partial class SuaBN : Form
    {
        BenhNhanBUS bn = new BenhNhanBUS();
        public SuaBN()
        {
            InitializeComponent();
        }

        public SuaBN(string maBN, string tenBN, string cmnd, string diachi, string ngaysinh, string sdt, string benhLy, string gioiTinh)
        {
            InitializeComponent();
            txtMaBN.Text = maBN;
            txtTenBN.Text = tenBN;
            txtCMND.Text = cmnd;
            txtDiaChi.Text = diachi;
            dtpNgaySinh.Value = DateTime.Parse(ngaysinh);
            txtSDT.Text = sdt;
            gioiTinh = gioiTinh.ToLower();
            if (gioiTinh == "nam")
            {
                radioNam.Checked = true;
                radioNu.Checked = false;
            }
            else if (gioiTinh == "nữ")
            {
                radioNu.Checked = true;
                radioNam.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bn.SuaBN(txtMaBN.Text, txtCMND.Text, txtDiaChi.Text, txtSDT.Text);
            MessageBox.Show("Sửa thông tin bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
