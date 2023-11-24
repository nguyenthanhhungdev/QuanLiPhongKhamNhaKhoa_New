using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class PhieuKetQuaBUS
    {
        PhieuKetQuaDAO PKQDAO=new PhieuKetQuaDAO();
        public bool insertPKQ(DataTable phieukq)
        {
            return PKQDAO.insertPKQ(phieukq);   
        }
        public DataTable GetBill(string sophieu)
        {
            return PKQDAO.GetBill(sophieu);
        }

        public bool UpdatePay(string soPhieu)
        {
            return PKQDAO.UpdatePay(soPhieu);
        }
    }
}
