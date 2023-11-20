using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;

namespace DAO
{
    internal class TaiKhamDAO
    {
        private readonly Database database=new Database();
        public DataTable Getlist()
        {
            string query= $@"SELECT *FROM TaiKham";
            return database.Execute(query);
        }
        public bool insertTK(DataTable taikham)
        {
            DataRow row = taikham.Rows[0];
            string Ngtk = row["NgayTK"].ToString();
            DateTime dateTime = DateTime.ParseExact(Ngtk, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            // Giữ nguyên phần ngày và thiết lập giờ, phút và giây thành 23:59:59
            DateTime adjustedDateTime = dateTime.Date.Add(new TimeSpan(23, 59, 59));

            string formattedDate = adjustedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string tinhtrang = row["TinhTrang"].ToString();
            string MaTK = row["MaTK"].ToString();
            MessageBox.Show("ngày TK: "+ formattedDate);
            string query = $"INSERT INTO TAIKHAM VALUES('{MaTK}','{formattedDate}','{tinhtrang}')";
            int rowsAffected = database.ExecuteNonQueryInt(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
