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

    }
}
