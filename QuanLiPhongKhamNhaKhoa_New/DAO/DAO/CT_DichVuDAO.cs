using DocumentFormat.OpenXml.Spreadsheet;
using QuanLiPhongKhamNhaKhoa_New.BUS.BUS;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class CT_DichVuDAO
    {
        private readonly Database database = new Database();
        public void addCTDV(DataTable ctdv)
        {
            DataRow row = ctdv.Rows[0];
            string sophieudv = row["SoPhieuDV"].ToString().Trim();
            string madv = row["MaDV"].ToString().Trim();
            string soluong = row["SoLuong"].ToString().Trim();
            string sql = $@"INSERT INTO CT_DICHVU VALUES('{sophieudv}','{madv}','{soluong}')";
            database.ExecuteNonQuery(sql);
        }
        public DataTable getSl(string sophieudv)
        {
            string sql = $@"select * from CT_DICHVU where SoPhieuDV='{sophieudv}';";
            return database.Execute(sql);
        }
    }
}
