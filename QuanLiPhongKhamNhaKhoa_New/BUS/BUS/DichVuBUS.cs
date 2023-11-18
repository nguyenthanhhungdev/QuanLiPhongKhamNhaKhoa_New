using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace BUS
{
    internal class DichVuBUS
    {
        DichVuDAO dichVuDAO=new DichVuDAO();
        public DataTable GetListService()
        {
            return dichVuDAO.GetListService();
        }
    }
}
