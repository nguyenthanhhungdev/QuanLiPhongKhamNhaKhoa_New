using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DAO
{
    internal class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        public string srvName = @"LAPTOP-91RK5R5L\SQLEXPRESS";  //chỉ định tên server
        public string dbName = "PhongKhamNhaKhoa";   //chỉ định tên CSDL
        public Database()
        {
            string connStr = "Data source=" + srvName + ";database=" + dbName + ";Integrated Security=True" + ";User ID=sa;Password=123456";
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
       
        public int ExecuteNonQuery(string sqlStr)
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
    }
}
