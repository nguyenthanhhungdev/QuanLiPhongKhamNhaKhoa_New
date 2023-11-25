using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiPhongKhamNhaKhoa_New.DAO.DAO;

namespace DAO
{
    internal class PhieuKetQuaDAO
    {
        private readonly Database database = new Database();
        public bool insertPKQ(DataTable phieukq)
        {
            DataRow row = phieukq.Rows[0];
            string ketluan = row["KetLuan"].ToString();
            string Sophieu = row["SoPhieuKQ"].ToString();
            string MaTK = row["MaTK"].ToString();
            bool tinhtrang = Convert.ToBoolean(row["TinhTrang"].ToString());
            string query = $"INSERT INTO PHIEUKETQUA VALUES('{Sophieu}','{ketluan}',NULLIF('{MaTK}', ''),'{tinhtrang}')";
            int rowsAffected = database.ExecuteNonQueryInt(query);
            if (rowsAffected > 0)
            {
                // Cập nhật thành công
                return true;

            }
            else
            {
                // Không có dòng nào được cập nhật
                return false;
            }
        }
        public DataTable GetBill(string sophieu)
        {
            string sqlnull = $@"select PHIEUKETQUA.SoPhieuKQ,BENHNHAN.MaBN,BENHNHAN.TenBN,PHIEUDICHVU.ThanhTien from PHIEUKETQUA
                join PHIEUDICHVU on PHIEUKETQUA.SoPhieuKQ=PHIEUDICHVU.SoPhieuKQ
                join BENHNHAN on BENHNHAN.MaBN=PHIEUDICHVU.MaBN WHERE PHIEUKETQUA.TinhTrang = 'False'";
            string sqlnotnull = $@"select PHIEUKETQUA.SoPhieuKQ,BENHNHAN.MaBN,BENHNHAN.TenBN,PHIEUDICHVU.ThanhTien from PHIEUKETQUA
                join PHIEUDICHVU on PHIEUKETQUA.SoPhieuKQ=PHIEUDICHVU.SoPhieuKQ
                join BENHNHAN on BENHNHAN.MaBN=PHIEUDICHVU.MaBN
                where PHIEUKETQUA.SoPhieuKQ like '%{sophieu}%' and PHIEUKETQUA.TinhTrang = 'False';";
            if (!string.IsNullOrEmpty(sophieu))
            {
                return database.Execute(sqlnotnull);
            }
            else
            {
                return database.Execute(sqlnull);
            }
            
        }

        public bool UpdatePay(string soPhieu)
        {
            string sql = "UPDATE PHIEUKETQUA SET TinhTrang = 'True' WHERE SoPhieuKQ = '" + soPhieu + "'";
            int rowsAffected = database.ExecuteNonQueryInt(sql);
            if (rowsAffected > 0)
            {
                // Cập nhật thành công
                return true;

            }
            else
            {
                // Không có dòng nào được cập nhật
                return false;
            }
        }
    }
}
