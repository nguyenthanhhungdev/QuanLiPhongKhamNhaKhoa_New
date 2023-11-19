using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class PhieuDichVuDAO
    {
        private readonly Database database = new Database();
        public DataTable GetListPhieuDv()
        {
            string query = "SELECT * FROM PHIEUDICHVU WHERE SUBSTRING(SoPhieuDV, 1, 6) = FORMAT(GETDATE(), 'ddMMyy');";
            return database.Execute(query);

        }
        public bool insertPDV(DataTable phieudv)
        {
            DataRow row = phieudv.Rows[0];
            string thanhtien = row["ThanhTien"].ToString();
            float colTTValue = float.Parse(thanhtien);
            string Sophieudv = row["SoPhieuDV"].ToString();
            string MaBS = row["MaBS"].ToString();
            string Sophieukq = row["SoPhieuKQ"].ToString();
            string mabn = row["MaBN"].ToString();
            string query = $"INSERT INTO PHIEUDICHVU VALUES('{Sophieudv}','{colTTValue}','{MaBS}','{Sophieukq}','{mabn}')";
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
