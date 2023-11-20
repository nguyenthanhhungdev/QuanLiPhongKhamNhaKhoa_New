using System;
using System.Data;
using DAO;
using DAO.DAO; // Import namespace của DAO
using DTO; // Import namespace của DTO

namespace BUS
{
    internal class NhanVienBUS
    {
        private readonly NhanVienDAO nhanVienDAO = new NhanVienDAO();
        public DataTable LayDuLieuNhanVien()
        {
            return nhanVienDAO.LayDuLieuNhanVien();
        }
        public void ThemNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau)
        {
            nhanVienDAO.ThemNhanVien(maNV, tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau);
        }
        public void SuaNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau)
        {
            nhanVienDAO.SuaNhanVien(maNV, tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau);
        }
        public void XoaNhanVien(string maNV)
        {
            nhanVienDAO.XoaNhanVien(maNV);
        }
        public int LayTongNV()
        {
            return nhanVienDAO.LayTongNV();
        }
    }
}
