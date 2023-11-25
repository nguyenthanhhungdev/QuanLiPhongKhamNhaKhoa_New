using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiPhongKhamNhaKhoa_New.DAO
{
    public class DataProvider
    {
        private static SqlConnection connection = new SqlConnection();

        public DataProvider()
        {
        }

        public static void Load()
        {
            try
            {
                connection = new SqlConnection(
                    @"Data Source=LAPTOP-91RK5R5L\SQLEXPRESS; Database=PHONGKHAMNHAKHOA;Integrated Security=True");
            }
            catch (SqlException e)
            {
                throw new Exception("Không truy cập được cơ sở dữ liệu");
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                
                // Mở kết nối với cơ sở dữ liệu
                connection.Open();
                if (connection == null)
                {
                    throw new Exception("Lỗi kết nối DataBase");
                    // throw new AppException(404, "Lỗi kết nối sql");
                }

                // Tạo một đối tượng SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Tạo một đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Tạo một đối tượng DataTable
                DataTable dataTable = new DataTable();

                // Điền dữ liệu từ SqlCommand vào DataTable
                adapter.Fill(dataTable);
                // dataTable.Load(command.ExecuteReader());
                
                // Đóng kết nối với cơ sở dữ liệu
                connection.Close();

                // Trả về DataTable
                return dataTable;
            }
            catch (SqlException ex)
            {
                // throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
                throw new Exception("Lỗi câu truy vấn");
            }

            // catch (AppException ex)
            // {
            //     throw ex;
            // }
        }

        public static int ExecuteNonQuery(string query)
        {
            try
            {
                // Tạo một đối tượng SqlConnection
                SqlConnection connection = new SqlConnection(
                    @"Data Source=LAPTOP-91RK5R5L\SQLEXPRESS; Database=PHONGKHAMNHAKHOA;Integrated Security=True");

                // Mở kết nối với cơ sở dữ liệu
                connection.Open();
                if (connection == null)
                {
                    // throw new AppException(404, "Lỗi kết nối sql");
                }

                // Tạo một đối tượng SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Thực hiện truy vấn dữ liệu
                int affectedRows = command.ExecuteNonQuery();

                // Đóng kết nối với cơ sở dữ liệu
                connection.Close();

                return affectedRows;
            }
            catch (SqlException ex)
            {
                // throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
                throw new Exception("Lỗi câu truy vấn");
            }
            // catch (AppException ex)
            // {
            //     throw ex;
            // }
        }

        public static object ExecuteScalar(string query)
        {
            try
            {
                // Tạo một đối tượng SqlConnection
                SqlConnection connection = new SqlConnection(
                    @"Data Source=LAPTOP-91RK5R5L\SQLEXPRESS; Database=PHONGKHAMNHAKHOA;Integrated Security=True");

                // Mở kết nối với cơ sở dữ liệu
                connection.Open();
                if (connection == null)
                {
                    // throw new AppException(404, "Lỗi kết nối sql");
                }

                // Tạo một đối tượng SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Thực hiện truy vấn dữ liệu
                object scalar = command.ExecuteScalar();

                // Đóng kết nối với cơ sở dữ liệu
                connection.Close();

                return scalar;
            }
            catch (SqlException ex)
            {
                // throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
                throw new Exception("Lỗi câu truy vấn");
            }
            // catch (AppException ex)
            // {
            //     throw ex;
            // }
        }
    }
}