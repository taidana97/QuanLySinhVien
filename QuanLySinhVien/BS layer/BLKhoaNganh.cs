using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLKhoaNganh
    {
        DBMain db = null;
        public BLKhoaNganh()
        {
            db = new DBMain();
        }
        public DataSet LayKhoaNganh()
        {
            return db.ExecuteQueryDataSet("select * from KhoaNganh", CommandType.Text);
        }
        public bool ThemKhoaNganh(string MaKhoa, string TenKhoa, ref string err)
        {
            string sqlString = "Insert Into KhoaNganh Values(" + "'" +
            MaKhoa + "',N'" +
            TenKhoa + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhoaNganh(string MaKhoa, ref string err)
        {
            string sqlString = "Delete From KhoaNganh Where MaKhoa='" + MaKhoa + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhoaNganh(string MaKhoa, string TenKhoa, ref string err)
        {
            string sqlString = "Update KhoaNganh Set TenKhoa=N'" +
            TenKhoa + "' Where MaKhoa='" + MaKhoa + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
