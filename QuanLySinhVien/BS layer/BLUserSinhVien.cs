using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLUserSinhVien
    {
        DBMain db = null;
        public BLUserSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LayNguoiDungSinhVien()
        {
            return db.ExecuteQueryDataSet("select * from NguoiDungSinhVien", CommandType.Text);
        }
        public bool ThemNguoiDungSinhVien(string UserMaSV, string Pass, ref string err)
        {
            string sqlString = "Insert Into NguoiDungSinhVien Values(" + "'" +
            UserMaSV + "',N'" +
            Pass + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNguoiDungSinhVien(string UserMaSV, ref string err)
        {
            string sqlString = "Delete From NguoiDungSinhVien Where UserMaSV='" + UserMaSV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNguoiDungSinhVien(string UserMaSV, string Pass, ref string err)
        {
            string sqlString = "Update NguoiDungSinhVien Set Pass='" +
            Pass + "' Where UserMaSV='" + UserMaSV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
