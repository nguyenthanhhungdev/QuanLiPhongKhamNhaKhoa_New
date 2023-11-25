using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

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
        public DataTable LayDSTiepDon(string mabn)
        {
            return TDDAO.LayDSTiepDon(mabn);
        }
        //Thêm tiếp đón
        public bool ThemTiepDon(string maNV, string maBN, string maP, string ngay, string tinhTrang)
        {
            DataTable dstd = LayDSTiepDon(maBN);
            //System.Windows.MessageBox.Show(dstd.Rows.Count.ToString());
            if (dstd.Rows.Count == 0)
            {
                TDDAO.ThemTiepDon(maNV, maBN, maP, ngay, tinhTrang);
                return true;
            } else
            {
                return false;
            }
            
            
        }
        
    }
}
