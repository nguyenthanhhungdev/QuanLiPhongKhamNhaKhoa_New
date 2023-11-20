using DAO;
using DTO;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class DichVuBUS
    {
        private readonly DichVuDAO dichVuDAO = new DichVuDAO();

        public DataTable LayDuLieuDichVu()
        {
            return dichVuDAO.LayDuLieuDichVu();
        }
        public void ThemDichVu(string maDV, string tenDV, float gia, string maLDV)
        {
            dichVuDAO.ThemDichVu(maDV, tenDV, gia, maLDV);
        }
        public void SuaDichVu(string maDV, string tenDV, float gia, string maLDV)
        {
            dichVuDAO.SuaDichVu(maDV, tenDV, gia, maLDV);
        }

        public void XoaDichVu(string maDV)
        {
            dichVuDAO.XoaDichVu(maDV);
        }
        public int LayTongDV()
        {
            return dichVuDAO.LayTongDV();
        }
        
        public DataTable GetListService()
        {
            return dichVuDAO.GetListService();
        }
    }
}
