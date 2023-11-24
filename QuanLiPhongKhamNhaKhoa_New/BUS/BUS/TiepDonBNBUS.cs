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

        //Lấy danh sách tiếp đón
        public DataTable LayDSTiepDon()
        {
            return TDDAO.LayDSTiepDon();
        }

        //Thêm tiếp đón
        public void ThemTiepDon(string maNV, string maBN, string maP, string ngay, string tinhTrang)
        {
            TDDAO.ThemTiepDon(maNV, maBN, maP, ngay, tinhTrang);
        }
    }
}
