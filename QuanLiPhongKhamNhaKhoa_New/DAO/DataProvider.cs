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
        }
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                // Kiểm tra xem kết nối đã được khởi tạo chưa
                if (connection == null)
                {
                    // Nếu chưa khởi tạo, thì ném một ngoại lệ
                    throw new Exception("Lỗi kết nối Database");
                }

                // Mở kết nối với cơ sở dữ liệu
                connection.Open();

                // Tạo một đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    // Tạo một đối tượng SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Tạo một đối tượng DataTable
                        DataTable dataTable = new DataTable();

                        // Điền dữ liệu từ SqlCommand vào DataTable
                        adapter.Fill(dataTable);

                        // Đóng kết nối với cơ sở dữ liệu
                        connection.Close();

                        // Trả về DataTable
                        return dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL nếu cần thiết
                // Có thể thêm log hoặc xử lý ngoại lệ theo yêu cầu cụ thể của bạn
                throw new Exception("Lỗi câu truy vấn SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác nếu cần thiết
                // Có thể thêm log hoặc xử lý ngoại lệ theo yêu cầu cụ thể của bạn
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng ngay cả khi có ngoại lệ xảy ra
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
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