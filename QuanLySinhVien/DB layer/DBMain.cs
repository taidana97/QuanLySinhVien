using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien.DB_layer
{
    class DBMain
    {
        // Thòng Thanh Vĩ 15110372
        // Bùi Đỗ Trung Trực 15110354
        // Chuẩn bị các đối tượng
        // Chuỗi kết nối
        string ConnStr = "Data Source=TAIDANA\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        //string ConnStr = "Data Source =169.254.38.82;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=abc;Password=123";

        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng thực hiện lệnh
        SqlCommand comm = null;
        // Đối tượng đưa dữ liệu vào DataTable
        SqlDataAdapter da = null;
        public DBMain()
        {
            // Khởi động connection 
            conn = new SqlConnection(ConnStr);
            // Khởi động quá trình tạo lệnh
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            // Mở kết nối 
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thực hiện lệnh
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            // Đối tượng tập dữ liệu
            DataSet ds = new DataSet();
            // Đưa dữ liệu vào DataTable
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thực hiện lệnh
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                // Thực hiện lệnh truy vấn câu hỏi
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                // Thông báo lỗi
                error = ex.Message;
            }
            finally
            {
                // Kết thúc kết nối
                conn.Close();
            }
            return f;
        }
        // Truy vấn đăng nhập
        public int QueryLogin(string strSQL, CommandType ct, ref string err)
        {
            int f;
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thực hiện lệnh
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            // Kêt quả của việc thực hiện truy vấn câu hỏi
            f = (int)comm.ExecuteScalar();
            try
            {
                // Kêt quả của việc thực hiện truy vấn câu hỏi 
                f = (int)comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                // Thông báo lỗi
                err = ex.Message;
            }
            finally
            {
                // Kết thúc kết nối
                conn.Close();
            }
            return f;
        }
        public bool QueryHinh(string strSQL, object hinhAnh, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            comm.Parameters.AddWithValue("@hinh", hinhAnh);

            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public string QueryDoiMatKhau(string strSQL, CommandType ct, ref string err)
        {
            string f;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            f = (string)comm.ExecuteScalar();
            try
            {
                f = (string)comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
