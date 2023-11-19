// Giả sử bạn có một class BUS tên là BenhNhanBUS

using System;
using System.Data;
using DAO;
using DAO.DAO; // Import namespace của DAO
using DTO; // Import namespace của DTO

namespace BUS
{
    internal class BenhNhanBUS
    {
        private readonly BenhNhanDAO benhNhanDAO = new BenhNhanDAO();

        public DataTable LayDuLieuBenhNhan()
        {
            return benhNhanDAO.LayDuLieuBenhNhan();
        }
    }
}
