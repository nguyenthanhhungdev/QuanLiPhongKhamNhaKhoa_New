using System;
using System.Data;
using DAO;
using DAO.DAO; // Import namespace của DAO
using DTO; // Import namespace của DTO

namespace BUS
{
    internal class BacSiBUS
    {
        private readonly BacSiDAO bacSiDAO = new BacSiDAO();

        public DataTable LayDuLieuBacSi()
        {
            return bacSiDAO.LayDuLieuBacSi();
        }
        public DataTable laybacsitrongphong(string maphong)
        {
            return bacSiDAO.laybacsitrongphong(maphong);
        }
        public void ThemBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string maPhong,string tinhtrang)
        {
            bacSiDAO.ThemBacSi( maBS,  tenBS,  diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, maPhong, tinhtrang);
        }
        public void SuaBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string maPhong, string tinhtrang)
        {
            bacSiDAO.SuaBacSi(maBS, tenBS, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, maPhong,tinhtrang);
        }
        public void XoaBacSi(string maBS)
        {
            bacSiDAO.XoaBacSi(maBS);
        }
        public int LayTongBS()
        {
            return bacSiDAO.LayTongBS();
        }
        public void fixMKbacsi(string mabs, string mk)
        {
            bacSiDAO.fixMKbacsi(mabs, mk);
        }
        public void fixInforbacsi(string mabs, string tenbs, string diachi, string email, string sdt)
        {
            bacSiDAO.fixInforbacsi(mabs,tenbs,diachi,email,sdt);
        }
    }
}
