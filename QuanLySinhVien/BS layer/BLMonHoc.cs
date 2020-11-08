using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLMonHoc
    {
        DBMain db = null;
        public BLMonHoc()
        {
            db = new DBMain();
        }
        public DataSet LayMonHoc()
        {
            return db.ExecuteQueryDataSet("select * from MonHoc", CommandType.Text);
        }
        public bool ThemMonHoc(string MaMH, string TenMH, int SoTC, string MaGV, ref string err)
        {
            string sqlString = "Insert Into MonHoc Values(" + "'" +
            MaMH + "',N'" + TenMH + "','" +
            SoTC + "','" + MaGV + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaMonHoc(string MaMH, ref string err)
        {
            string sqlString = "Delete From MonHoc Where MaMH='" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatMonHoc(string MaMH, string TenMH, int SoTC, string MaGV, ref string err)
        {
            string sqlString = "Update MonHoc Set TenMH=N'" +
            TenMH + "',SoTC='" + SoTC + "',MaGV='" + MaGV + "' Where MaMH='" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
