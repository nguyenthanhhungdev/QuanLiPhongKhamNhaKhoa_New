using DAO;
using DAO.DAO;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class CT_DichVuBUS
    {
        private readonly CT_DichVuDAO CT_DVDAO = new CT_DichVuDAO();
        public void addCTDV(DataTable ctdv)
        {
            CT_DVDAO.addCTDV(ctdv);
        }
        public DataTable getSl(string sophieudv)
        {
            return CT_DVDAO.getSl(sophieudv);
        }
    }
}
