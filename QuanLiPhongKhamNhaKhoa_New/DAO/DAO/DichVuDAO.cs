using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class DichVuDAO
    {
        private readonly Database database = new Database();
        public DataTable GetListService()
        {

            string query = $@"SELECT *FROM DichVu";
            return database.Execute(query);
        }
    }
}
