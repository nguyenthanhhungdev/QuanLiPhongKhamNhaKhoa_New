using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class BenhNhanBUS
    {
        BenhNhanDAO BNDAO=new BenhNhanDAO();
        public DataTable GetList()
        {
            return BNDAO.GetList();
        }
        public bool UpdateBN(DataTable BNnew)
        {
            return BNDAO.UpdateBN(BNnew);
        }
    }
}
