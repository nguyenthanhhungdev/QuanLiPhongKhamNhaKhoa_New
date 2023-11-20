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
        public void ThemBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string maPhong)
        {
            bacSiDAO.ThemBacSi( maBS,  tenBS,  diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, maPhong);
        }
        public void SuaBacSi(string maBS, string tenBS, string diaChi, string ngSinh, string sdt, string email, string gioiTinh, string caLam, string matKhau, string maPhong)
        {
            bacSiDAO.SuaBacSi(maBS, tenBS, diaChi, ngSinh, sdt, email, gioiTinh, caLam, matKhau, maPhong);
        }
        public void XoaBacSi(string maBS)
        {
            bacSiDAO.XoaBacSi(maBS);
        }
        public int LayTongBS()
        {
            return bacSiDAO.LayTongBS();
        }
    }
}
