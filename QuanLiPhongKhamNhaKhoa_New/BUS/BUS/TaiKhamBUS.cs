using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class TaiKhamBUS
    {
        TaiKhamDAO TKDAO = new TaiKhamDAO();
        public DataTable Getlist()
        {
            return TKDAO.Getlist();
        }
        public bool insertTK(DataTable taikham)
        {
            return TKDAO.insertTK(taikham);
        }
    }
}
