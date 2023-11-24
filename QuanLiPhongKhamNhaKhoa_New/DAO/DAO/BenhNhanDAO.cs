// Giả sử bạn có một class DAO tên là BenhNhanDAO

using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Data;

namespace DAO.DAO
{
    internal class BenhNhanDAO
    {
        private readonly Database database = new Database();

        public DataTable LayDuLieuBenhNhan()
        {
            string query = "SELECT * FROM BENHNHAN"; // Thay đổi query tùy theo cấu trúc bảng thực tế của bạn
            return database.Execute(query);
        }
        public DataTable GetListMaBN(string mabn)
        {
            string query = $@"SELECT * FROM BenhNhan where MaBN='{mabn}'";
            return database.Execute(query);
        }
        public DataTable GetList()
        {
            string query = "SELECT * FROM BenhNhan ";
            return database.Execute(query);
        }
        public bool UpdateBN(DataTable BNnew)
        {
            try
            {
                DataRow row = BNnew.Rows[0]; // Lấy dòng đầu tiên của DataTable

                // Lấy giá trị từ DataRow
                string maBenhNhan = row["MaBN"].ToString();
                string SdtBenhNhan = row["SDT"].ToString();
                string diaChi = row["DiaChi"].ToString();
                string Benhly = row["BenhLy"].ToString();
                // Điều chỉnh query cập nhật dữ liệu tùy thuộc vào cấu trúc của bảng BenhNhan
                string query = $"UPDATE BENHNHAN SET SDT = '{SdtBenhNhan}', BenhLy = N'{Benhly}', DiaChi = N'{diaChi}' WHERE MaBN = '{maBenhNhan}'";
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
    }
}
