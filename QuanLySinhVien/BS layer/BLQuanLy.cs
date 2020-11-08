using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLQuanLy
    {

        DBMain db = null;

        public BLQuanLy()
        {
            db = new DBMain();
        }
        public DataSet LayQuanLy()
        {
            return db.ExecuteQueryDataSet("select * from QuanLy", CommandType.Text);
        }
        public int DangNhapQuanLy(string User, string Pass, ref string err)
        {
            string sqlString = "select count(*) from QuanLy where MaQL='" + User + "' and Pass='" + Pass + "'";
            return db.QueryLogin(sqlString, CommandType.Text, ref err);
        }
        public bool DangKyQuanLy(string User, string Pass, ref string err)
        {
            string sqlString = "Insert Into QuanLy Values('" + User + "','" + Pass + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public int XetTenQuanLy(string User, ref string err)
        {
            string sqlString = "select count(*) from QuanLy where MaQL='" + User + "'";
            return db.QueryLogin(sqlString, CommandType.Text, ref err);
        }
        public bool DoiMatKhauQuanLy(string User, string PassNew, ref string err)
        {
            string sqlString = "Update QuanLy Set Pass='" +
            PassNew + "' Where MaQL='" + User + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public string SelectPassCu(string User, ref string err)
        {
            string sqlString = "select Pass from QuanLy where MaQL='" + User + "'";
            return db.QueryDoiMatKhau(sqlString, CommandType.Text, ref err);
        }
    }
}
