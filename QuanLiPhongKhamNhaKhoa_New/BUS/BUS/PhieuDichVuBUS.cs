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
    }
}
