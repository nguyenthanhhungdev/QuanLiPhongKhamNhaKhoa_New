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
        BenhNhanDAO BNDAO=new BenhNhanDAO();
        public DataTable GetList()
        {
            return BNDAO.GetList();
        }
        public bool UpdateBN(DataTable BNnew)
        {
            return BNDAO.UpdateBN(BNnew);
        }
        public DataTable GetListMaBN(string mabn)
        {
            return BNDAO.GetListMaBN(mabn);
        }

        //Thêm BN
        public void ThemBN(string maBN, string tenBN, string cmnd, string diaChi, string ngaySinh, string sdt, string gioiTinh)
        {
            benhNhanDAO.ThemBN(maBN, tenBN, cmnd, diaChi, ngaySinh, sdt, gioiTinh);
        }

        //Lấy số lượng BN trong db
        public int LayDem()
        {
            return benhNhanDAO.LayBN();
        }

        //Sửa BN
        public void SuaBN(string maBN, string cmnd, string diaChi, string sdt)
        {
            benhNhanDAO.SuaBN(maBN, cmnd, diaChi, sdt);
        }
    }
}
