using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLLopSinhVien
    {
        DBMain db = null;
        public BLLopSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LayLopSinhVien()
        {
            return db.ExecuteQueryDataSet("select * from LopSinhVien", CommandType.Text);
        }
        public bool ThemLopSinhVien(string MaLop, string MaKhoa, string TenLop, ref string err)
        {
            string sqlString = "Insert Into LopSinhVien Values(" + "'" +
            MaLop + "','" + 
            MaKhoa +"',N'" +
            TenLop + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaLopSinhVien(string MaLop, ref string err)
        {
            string sqlString = "Delete From LopSinhVien Where MaLop='" + MaLop + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatLopSinhVien(string MaLop, string MaKhoa, string TenLop, ref string err)
        {
            string sqlString = "Update LopSinhVien Set MaKhoa='" + MaKhoa + "',TenLop=N'" + TenLop + "' Where MaLop='" + MaLop + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
