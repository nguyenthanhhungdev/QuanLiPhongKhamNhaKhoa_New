using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class BacSiDAO
    {
        private readonly Database database = new Database();

        public DataTable LayDuLieuBacSi()
        {
            string query = "SELECT BACSI.MaBS, BACSI.TenBS, BACSI.DiaChi, BACSI.NgSinh, BACSI.SDT, BACSI.Email, BACSI.GioiTinh, BACSI.CaLam, BACSI.MatKhau, PHONGKHAM.TenPhong,BACSI.TinhTrang " +
                  "FROM BACSI " +
                  "LEFT JOIN PHONGKHAM ON BACSI.MaPhong = PHONGKHAM.MaPhong ";
            return database.Execute(query);
        }
        public DataTable laybacsitrongphong(string maphong)
        {
            string query = $@"SELECT * FROM BACSI where MaPhong = '{maphong}'";
            return database.Execute(query);
        }
        public void ThemBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh,string caLam, string matKhau, string maPhong,string tinhtrang)
        {
            string sql = string.Format("INSERT INTO BACSI VALUES('{0}', N'{1}', N'{2}', '{3}','{4}','{5}',N'{6}',N'{7}','{8}','{9}',{10}", maBS, tenBS,diaChi,ngSinh,sdt,email,gioiTinh,caLam,matKhau,maPhong,tinhtrang);
            database.ExecuteNonQuery(sql);

        }
        public void SuaBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string maPhong, string tinhtrang)
        {
            string sql = string.Format("UPDATE BACSI SET TenBS = N'{0}', DiaChi = N'{1}', NgSinh = '{2}', SDT = '{3}', Email = '{4}', GioiTinh = N'{5}', CaLam = N'{6}', MatKhau = '{7}', MaPhong = '{8}', TinhTrang = '{9}' WHERE MaBS = '{10}'", tenBS, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, maPhong,tinhtrang, maBS);
            database.ExecuteNonQuery(sql);
        }
        public void fixMKbacsi(string mabs,string mk)
        {
            string sql = $@"UPDATE BACSI SET MatKhau = '{mk}' where MaBS='{mabs}'";
            database.ExecuteNonQuery(sql);
        }
        public void XoaBacSi(string maBS)
        {
            string sql = string.Format("UPDATE BACSI SET TinhTrang = 'False' WHERE MaBS = '{0}'", maBS);
            database.ExecuteNonQuery(sql);
        }
        public int LayTongBS()
        {
            string sql = "SELECT COUNT(MaBS) FROM BACSI";
            int i = database.ExecuteScalar(sql);
            return i;
        }
        public void fixInforbacsi(string mabs, string tenbs,string diachi,string email,string sdt)
        {
            string sql = $@"UPDATE BACSI SET TenBS=N'{tenbs}',DiaChi=N'{diachi}',Email='{email}',SDT='{sdt}' where MaBS='{mabs}'";
            database.ExecuteNonQuery(sql);
        }
    }
}
