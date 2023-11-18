using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class LoaiDichVuDAO
    {
        private readonly Database database = new Database();
        public DataTable GetListTypeService()
        {
            string query = $@"SELECT *FROM LoaiDichVu";
            return database.Execute(query);
        }
    }
}
