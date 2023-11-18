using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = $"INSERT INTO PHIEUKETQUA VALUES('{Sophieu}','{ketluan}',NULLIF('{MaTK}', ''))";
            int rowsAffected = database.ExecuteNonQuery(query);
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
