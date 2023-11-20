using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLiPhongKhamNhaKhoa_New.DAO.DAO
{
    internal class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        public string srvName = "LAPTOP-8JINTJMF";	//chỉ định tên server
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
        public void ExecuteNonQuery(string strSQL)
        {
           SqlCommand cmd = new SqlCommand(strSQL, sqlConn);
           sqlConn.Open();
           cmd.ExecuteNonQuery();
           sqlConn.Close();
        }
        public int ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConn.Close();
            return i;
        }
    }
}
