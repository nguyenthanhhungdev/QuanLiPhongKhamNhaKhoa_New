using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
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
        public DataTable LayDuLieuDichVu()
        {
            string query = "SELECT DICHVU.MaDV, DICHVU.TenDV, DICHVU.GIA, LOAIDICHVU.TenLDV " +
                   "FROM DICHVU " +
                   "LEFT JOIN LOAIDICHVU ON DICHVU.MaLDV = LOAIDICHVU.MaLDV ";
            return database.Execute(query);
        }

        public void ThemDichVu(string maDV, string tenDV, float gia, string maLDV)
        {
            string sql = string.Format("INSERT INTO DICHVU VALUES('{0}', N'{1}', N'{2}', '{3}')", maDV, tenDV, gia, maLDV);
            database.ExecuteNonQuery(sql);

        }
        public void SuaDichVu(string maDV, string tenDV, float gia, string maLDV)
        {
            string sql = string.Format("UPDATE DICHVU SET TenDV = N'{0}', Gia = '{1}', MaLDV = '{2}' WHERE MaDV = '{3}'", tenDV, gia,maLDV,maDV);
            database.ExecuteNonQuery(sql);
        }
        public void XoaDichVu(string maDV)
        {
            string sql = string.Format("DELETE FROM DICHVU WHERE MaDV = '{0}'", maDV);
            database.ExecuteNonQuery(sql);
        }
        public int LayTongDV()
        {
            string sql = "SELECT COUNT(MaDV) FROM DICHVU";
            int i = database.ExecuteScalar(sql);
            return i;
        }
        
        public DataTable GetListService()
        {
            string query = $@"SELECT *FROM DichVu";
            return database.Execute(query);
        }
        public DataTable GetListReadPDF(string madv)
        {
            string sql = $@"SELECT DichVu.MaDV, DichVu.TenDV,LoaiDichVu.TenLDV,DichVu.Gia
                FROM LoaiDichVu
                JOIN DichVu ON LoaiDichVu.MaLDV = DichVu.MaLDV
                Where MaDV='{madv}'";
            return database.Execute(sql);
        }

    }
}
