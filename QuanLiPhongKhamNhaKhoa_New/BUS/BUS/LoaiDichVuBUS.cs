using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BUS
{
    internal class LoaiDichVuBUS
    {
        private readonly LoaiDichVuDAO loaiDichVuDAO = new LoaiDichVuDAO();
       
        public DataTable LayDuLieuLoaiDV()
        {
            return loaiDichVuDAO.LayDuLieuLoaiDV();
        }
        public int LayTongLDV()
        {
            return loaiDichVuDAO.LayTongLDV();
        }
        public void ThemLoaiDV(string maLDV, string tenLDV)
        {
            loaiDichVuDAO.ThemLoaiDV(maLDV,tenLDV);
        }
        public void SuaLoaiDV(string maLDV, string tenLDV)
        {
            loaiDichVuDAO.SuaLoaiDV(maLDV, tenLDV);
        }

        public void XoaLoaiDV(string maLDV)
        {
            loaiDichVuDAO.XoaLoaiDV(maLDV);
        }
    }
}
