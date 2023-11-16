using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MailKit.Security;
using MimeKit;
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
                var message = new MimeMessage();
                MailboxAddress from = new MailboxAddress("Admin", 
                    "casimir.stehr@ethereal.email");
                message.From.Add(from);
                
                MailboxAddress to = new MailboxAddress("User", 
                    email);
                message.To.Add(to);
                
                message.Subject = "Xác nhận thay đổi mật khẩu tài khoản phòng khám nha khoa";
                
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = string.Format("<h1>Mã xác nhận: {0}</h1>", maXacNhan.ToString());
                
                message.Body = bodyBuilder.ToMessageBody();

                var smtpClient = new MailKit.Net.Smtp.SmtpClient();
                smtpClient.Connect("smtp.ethereal.email", 587, SecureSocketOptions.Auto);
                smtpClient.Authenticate("casimir.stehr@ethereal.email", "6mEr7bWTBuEtk3C12Q");
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
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