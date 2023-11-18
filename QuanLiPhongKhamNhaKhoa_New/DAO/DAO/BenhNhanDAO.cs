using QuanLiPhongKhamNhaKhoa_New;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    internal class BenhNhanDAO
    {
        private readonly Database database = new Database();
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
                int rowsAffected = database.ExecuteNonQuery(query);
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
