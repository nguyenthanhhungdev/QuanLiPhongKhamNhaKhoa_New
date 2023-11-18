using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    internal class LoaiDichVuBUS
    {
        LoaiDichVuDAO loaiDichVuDAO = new LoaiDichVuDAO();
        public DataTable GetListTypeService()
        {
           return loaiDichVuDAO.GetListTypeService();
        }
    }
}
