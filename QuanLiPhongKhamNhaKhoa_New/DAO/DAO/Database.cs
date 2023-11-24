using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLiPhongKhamNhaKhoa_New.DAO.DAO
{
    internal class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        public string srvName = @"LAPTOP-3GFMRAKL\\VENCHU";	//chỉ định tên server
        public string dbName = "PhongKhamNhaKhoa";   //chỉ định tên CSDL
        public Database()
        {
            string connStr = @"Data Source=LAPTOP-3GFMRAKL\VENCHU; Database=PHONGKHAMNHAKHOA;Integrated Security=True";
            sqlConn = new SqlConnection(connStr);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn); 
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
           SqlCommand cmd = new SqlCommand(strSQL, sqlConn);
           sqlConn.Open();
           cmd.ExecuteNonQuery();
           sqlConn.Close();
        }
        
        
        public int ExecuteNonQueryInt(string sqlStr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                sqlConn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ExecuteNonQuery. SQL: {sqlStr}. Error: {ex.Message}");
                return -1; // Return a value indicating an error
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }
        public int ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConn.Close();
            return i;
        }

        public string ExecuteScalarStr(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            string i = Convert.ToString(cmd.ExecuteScalar());
            sqlConn.Close();
            return i;
        }
    }
}
