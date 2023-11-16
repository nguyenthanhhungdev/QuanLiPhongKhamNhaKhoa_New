using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO;

namespace QuanLiPhongKhamNhaKhoa_New
{
    public partial class QuenMatKhau : Form
    {
        bool hasConfirm = false;
        int maXacNhan = RandomFrom1To1000();

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            try
            {
                string sql = string.Format("Select * from BACSI where Email = '{0}'", email);
                if (DataProvider.ExecuteQuery(sql).Rows.Count == 0)
                {
                    MessageBox.Show("Email không đúng");
                }
                else
                {
                    sendEmail(maXacNhan, email);
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Lỗi hệ thống: \nLỗi truy vấn");
            }
        }

        private void sendEmail(int maXacNhan, string email)
        {
            try
            {
                var smtpClient = new SmtpClient()
                {
                    Port = 587,
                    Credentials = new NetworkCredential("cuahangthucannhanhhehe@gmail.com", "1405_Hung"),
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("cuahangthucannhanhhehe@gmail.com"),
                    Subject = "Email xác nhận thay đổi mật khẩu",
                    Body = maXacNhan.ToString(),
                };
                mailMessage.To.Add(email);
                smtpClient.Send(mailMessage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static int RandomFrom1To1000()
        {
            // Tạo đối tượng Random
            Random rand = new Random();

            // Trả về số ngẫu nhiên trong phạm vi từ 1 đến 1000
            return rand.Next(1, 1001);
        }

        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            if (hasConfirm)
            {
            }
            else
            {
                MessageBox.Show("Hãy nhập chính xác mã xác nhận");
            }
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (maXacNhan.ToString().Equals(textBoxXacNhan.Text))
            {
                MessageBox.Show("Mã xác nhận chính xác");
                hasConfirm = true;
            }
            else
            {
                MessageBox.Show("Mã xác nhận sai, vui lòng nhập lại chính xác");
            }
        }
    }
}