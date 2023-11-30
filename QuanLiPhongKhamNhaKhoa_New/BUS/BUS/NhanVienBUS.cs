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
        public void ThemNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string tinhtrang)
        {
            nhanVienDAO.ThemNhanVien(maNV, tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, tinhtrang);
        }
        public void SuaNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string tinhtrang)
        {
            nhanVienDAO.SuaNhanVien(maNV, tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, tinhtrang);
        }
        public void XoaNhanVien(string maNV)
        {
            nhanVienDAO.XoaNhanVien(maNV);
        }
        public int LayTongNV()
        {
            return nhanVienDAO.LayTongNV();
        }
        public void fixMKnhanvien(string manv, string mk)
        {
            nhanVienDAO.fixMKnhanvien(manv, mk);
        }
        public void fixInfornhanvien(string manv, string tennv, string diachi, string email, string sdt)
        {
            nhanVienDAO.fixInfornhanvien(manv, tennv, diachi, email, sdt);
        }
    }
}
