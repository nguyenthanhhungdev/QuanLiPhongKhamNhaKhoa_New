using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class PhongKhamBUS
    {
        private readonly PhongKhamDAO phongKhamDAO = new PhongKhamDAO();
        public DataTable LayTenPhongKham()
        {
            return phongKhamDAO.LayTenPhongKham();
        }
        public DataTable LayDuLieuPhongKham()
        {
            return phongKhamDAO.LayDuLieuPhongKham();
        }
        public void ThemPhongKham(string maP, string tenP)
        {
            phongKhamDAO.ThemPhongKham(maP, tenP);
        }
        public void SuaPhongKham(string maP, string tenP)
        {
            phongKhamDAO.SuaPhongKham(maP, tenP);
        }

        public void XoaPhongKham(string maP)
        {
            phongKhamDAO.XoaPhongKham(maP);
        }
        public int LayTongPK()
        {
            return phongKhamDAO.LayTongPK();
        }
    }
}
