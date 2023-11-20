using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class NhanVienDAO
    {
        private readonly Database database = new Database();

        public DataTable LayDuLieuNhanVien()
        {
            string query = "SELECT * FROM NHANVIEN"; // Thay đổi query tùy theo cấu trúc bảng thực tế của bạn
            return database.Execute(query);
        }
        public void ThemNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau)
        {
            string sql = string.Format("INSERT INTO NHANVIEN VALUES('{0}', N'{1}', N'{2}', '{3}','{4}','{5}',N'{6}',N'{7}','{8}')", maNV, tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau);
            database.ExecuteNonQuery(sql);
        }
        public void SuaNhanVien(string maNV, string tenNV, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau)
        {
            string sql = string.Format("UPDATE NHANVIEN SET TenNV = N'{0}', DiaChi = N'{1}', NgSinh = '{2}', SDT = '{3}', Email = '{4}', GioiTinh = N'{5}', Calam = N'{6}', MatKhau = '{7}' WHERE MaNV = '{8}'", tenNV, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau,  maNV);
            database.ExecuteNonQuery(sql);
        }
        public void XoaNhanVien(string maNV)
        {
            string sql = string.Format("DELETE FROM NHANVIEN WHERE MaNV = '{0}'", maNV);
            database.ExecuteNonQuery(sql);
        }
        public int LayTongNV()
        {
            string sql = "SELECT COUNT(MaNV) FROM NHANVIEN";
            int i = database.ExecuteScalar(sql);
            return i;
        }
    }
}
