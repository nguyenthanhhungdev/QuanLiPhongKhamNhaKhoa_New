using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAO
{
    internal class LoaiDichVuDAO
    {
        private readonly Database database = new Database();
       
        public DataTable LayDuLieuLoaiDV()
        {
            string query = "SELECT * FROM LOAIDICHVU"; // Thay đổi query tùy theo cấu trúc bảng thực tế của bạn
            return database.Execute(query);
        }
        public int LayTongLDV()
        {
            string sql = "SELECT COUNT(MaLDV) FROM LOAIDICHVU";
            int i = database.ExecuteScalar(sql);
            return i;
        }
        public void ThemLoaiDV(string maLDV, string tenLDV)
        {
            string sql = string.Format("INSERT INTO LOAIDICHVU VALUES('{0}', N'{1}')", maLDV, tenLDV);
            database.ExecuteNonQuery(sql);

        }
        public void SuaLoaiDV(string maLDV, string tenLDV)
        {
            string sql = string.Format("UPDATE LOAIDICHVU SET TenLDV = N'{0}' WHERE MaLDV= '{1}'", tenLDV, maLDV);
            database.ExecuteNonQuery(sql);
        }
        public void XoaLoaiDV(string maLDV)
        {
            string sql = string.Format("DELETE FROM LOAIDICHVU WHERE MaLDV = '{0}'", maLDV);
            database.ExecuteNonQuery(sql);
        }
        
        public DataTable GetListTypeService()
        {
            string query = $@"SELECT *FROM LoaiDichVu";
            return database.Execute(query);
        }
    }
}
