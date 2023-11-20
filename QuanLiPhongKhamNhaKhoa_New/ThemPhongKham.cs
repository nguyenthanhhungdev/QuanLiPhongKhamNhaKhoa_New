using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class ThemPhongKham : Form
    {
        public ThemPhongKham()
        {
            InitializeComponent();
            PhongKhamBUS bus = new PhongKhamBUS();
            int ma = bus.LayTongPK();
            if (ma <= 9)
            {
                textBox1.Text = "P0" + (ma + 1);
            }
            else
            {
                textBox1.Text = "P" + (ma + 1);
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Lấy thông tin từ các điều khiển trên form
                string maP = textBox1.Text;
                string tenP = textBox2.Text;
               
                if (string.IsNullOrWhiteSpace(tenP))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                PhongKhamBUS phongKhamBUS = new PhongKhamBUS();
                phongKhamBUS.ThemPhongKham(maP, tenP);

                DialogResult dr = MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
