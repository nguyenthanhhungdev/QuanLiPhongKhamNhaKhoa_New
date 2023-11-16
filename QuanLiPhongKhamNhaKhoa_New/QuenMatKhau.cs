using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            try
            {
                string sql = string.Format("Select * from BACSI where Email = '{0}'", textBoxEmail.Text);
                if (DataProvider.ExecuteQuery(sql).Rows.Count == 0)
                {
                    MessageBox.Show("Email không đúng");
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Lỗi hệ thống: \nLỗi truy vấn");
            }

            int maXacNhan = RandomFrom1To1000();
            sendEmail(maXacNhan);
        }

        private void sendEmail(int maXacNhan)
        {
            
        }

        public static int RandomFrom1To1000()
        {
            // Tạo đối tượng Random
            Random rand = new Random();

            // Trả về số ngẫu nhiên trong phạm vi từ 1 đến 1000
            return rand.Next(1, 1001);
        }
    }
}
