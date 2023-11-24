using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    internal class PhieuDichVuBUS
    {
        PhieuDichVuDAO PDVDAO = new PhieuDichVuDAO();
        public DataTable GetListPhieuDv()
        {
            return PDVDAO.GetListPhieuDv();
        }
        public bool insertPDV(DataTable phieudv)
        {
            return PDVDAO.insertPDV(phieudv);
        }
        public DataTable GetSoPhieu(string maBN)
        {
            return PDVDAO.GetSoPhieu(maBN);
        }
        public DataTable getTenBS(string maphieu)
        {
            return PDVDAO.getTenBS(maphieu);
        }
    }
}
