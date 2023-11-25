using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;

namespace DAO
{
    internal class TiepDonBNDAO
    {   
        private readonly Database database=new Database();
        public DataTable GetListWaitingRoom(String maphong)
        {
            // Lấy ngày hiện tại
            DateTime ngayHienTai = DateTime.Now;
            // Sử dụng định dạng ngày phù hợp cho kiểu smalldatetime trong SQL (yyyyMMdd)
            string query = $@"
                SELECT *
                FROM TIEPDONBN
                WHERE MaPhong = '{maphong}'
                AND DATEPART(YEAR, NgayKham) = {ngayHienTai.Year}
                AND DATEPART(MONTH, NgayKham) = {ngayHienTai.Month}
                AND DATEPART(DAY, NgayKham) = {ngayHienTai.Day}
                AND (TinhTrang = 'Khám' OR TinhTrang = 'Tái Khám')
                ORDER BY NgayKham ASC;";
            return database.Execute(query);
        }
        public bool UpdateTDBN(DataTable tiepdonBN)
        {
            try
            {
                DataRow row = tiepdonBN.Rows[0]; // Lấy dòng đầu tiên của DataTable
                // Lấy giá trị từ DataRow
                string maBenhNhan = row["MaBN"].ToString();
                string tinhtrang = row["TinhTrang"].ToString();               
                string query = $"UPDATE TIEPDONBN SET TinhTrang = N'{tinhtrang}' " +
                                      $"WHERE MaBN = '{maBenhNhan}' AND CONVERT(DATE, NgayKham) = CONVERT(DATE, GETDATE())";
                int rowsAffected = database.ExecuteNonQueryInt(query);
                if (rowsAffected > 0)
                {
                    // Cập nhật thành công
                    return true;

                }
                else
                {
                    // Không có dòng nào được cập nhật
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        

        //Lấy danh sách tiếp đón
        public DataTable LayDSTiepDon()
        {
            string sql = "SELECT TenPhong, TenBN, NgayKham, B.TinhTrang " +
                "FROM ((BENHNHAN A join TIEPDONBN B on A.MaBN = B.MaBN) join PHONGKHAM C on B.MaPhong = C.MaPhong) " +
                "WHERE DAY(NgayKham) = DAY(GETDATE())";
            //MessageBox.Show(sql);
            DataTable dt = database.Execute(sql);
            return dt;
        }

        public DataTable LayDSTiepDon(string maBN)
        {
            string sql = "SELECT TenPhong, TenBN, NgayKham, B.TinhTrang " +
                "FROM ((BENHNHAN A join TIEPDONBN B on A.MaBN = B.MaBN) join PHONGKHAM C on B.MaPhong = C.MaPhong) " +
                "WHERE DAY(NgayKham) = DAY(GETDATE())" +
                " AND B.MaBN ='" + maBN + "'";
            MessageBox.Show(sql);
            DataTable dt = database.Execute(sql);
            return dt;
        }

        //Thêm tiếp đón
        public void ThemTiepDon(string maNV, string maBN, string maP, string ngayKham, string tinhTrang)
        {
            //MessageBox.Show("thông tin tiếp đoán: ");
            string sql = string.Format("INSERT INTO TIEPDONBN VALUES('{0}', '{1}', '{2}', '{3}', N'{4}')", maNV, maBN, maP, ngayKham, tinhTrang);
            database.ExecuteNonQuery(sql);
        }
    }
}