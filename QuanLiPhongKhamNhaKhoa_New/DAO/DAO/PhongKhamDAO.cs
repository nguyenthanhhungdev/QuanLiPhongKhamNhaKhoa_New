using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class PhongKhamDAO
    {
        private readonly Database database = new Database();
        public DataTable LayTenPhongKham()
        {
            string query = "SELECT * FROM PHONGKHAM";
            return database.Execute(query);
        }
        public DataTable LayDuLieuPhongKham()
        {
            string query = "SELECT PHONGKHAM.MaPhong, PHONGKHAM.TenPhong, BACSI.TenBS, BACSI.CaLam " +
                   "FROM PHONGKHAM " +
                   "LEFT JOIN BACSI ON PHONGKHAM.MaPhong = BACSI.MaPhong " ;
            return database.Execute(query);
        }

        public void ThemPhongKham(string maP, string tenP)
        {
            string sql = string.Format("INSERT INTO PHONGKHAM VALUES('{0}', N'{1}')", maP, tenP);
            database.ExecuteNonQuery(sql);

        }
        public void SuaPhongKham(string maP, string tenP)
        {
            string sql = string.Format("UPDATE PHONGKHAM SET TenPhong = N'{0}' WHERE MaPhong = '{1}'", tenP, maP);
            database.ExecuteNonQuery(sql);
        }
        public void XoaPhongKham(string maP)
        {
            string sql = string.Format("DELETE FROM PHONGKHAM WHERE MaPhong = '{0}'", maP);
            database.ExecuteNonQuery(sql);
        }
        public int LayTongPK()
        {
            string sql = "SELECT COUNT(MaPhong) FROM PHONGKHAM";
            int i = database.ExecuteScalar(sql);
            return i;
        }
    }
}
