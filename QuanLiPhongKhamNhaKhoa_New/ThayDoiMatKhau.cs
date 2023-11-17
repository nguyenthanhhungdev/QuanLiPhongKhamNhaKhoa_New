using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class ThayDoiMatKhau : Form
    {
        private bool hasConfirm = false;
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }
        
        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            if (hasConfirm)
            {
                if (textBoxThayDoiMK.Text.Length == 0)
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới");
                    return;
                }

                string sqlBS = string.Format("UPDATE BACSI SET MatKhau = '{0}' WHERE MaBS = '{1}'", textBoxThayDoiMK.Text, QuenMatKhau.ma);
                string sqlNV = string.Format("UPDATE NHANVIEN SET MatKhau = '{0}' WHERE MaNV = '{1}'", textBoxThayDoiMK.Text, QuenMatKhau.ma);
                string sql = QuenMatKhau.ma.Contains("BS") ? sqlBS : sqlNV;
                if (DataProvider.ExecuteNonQuery(sql) == 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu không thành công");
                    return;
                }
                MessageBox.Show("Đã Thay Đổi Mật Khẩu");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập chính xác mã xác nhận");
            }
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (QuenMatKhau.maXacNhan.ToString().Equals(textBoxXacNhan.Text))
            {
                MessageBox.Show("Mã xác nhận chính xác");
                hasConfirm = true;
                textBoxThayDoiMK.Focus();
            }
            else
            {
                MessageBox.Show("Mã xác nhận sai, vui lòng nhập lại chính xác");
            }
        }
        
        public void txtMaXacNhan_KeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Enter)
            {
                buttonXacNhan_Click(sender, new EventArgs());
            }
        }
        
        public void txtThayDoiMK_KeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Enter)
            {
                buttonThayDoi_Click(sender, new EventArgs());
            }
        }
    }
}
