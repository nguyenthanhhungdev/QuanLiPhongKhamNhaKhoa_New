using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    internal class TiepDonBNBUS
    {
        TiepDonBNDAO TDDAO=new TiepDonBNDAO();
        public DataTable GetListWaitingRoom(String maphong)
        {
            return TDDAO.GetListWaitingRoom(maphong);
        }
        public bool UpdateTDBN(DataTable tiepdonBN)
        {
            return TDDAO.UpdateTDBN(tiepdonBN);
        }
    }
}
