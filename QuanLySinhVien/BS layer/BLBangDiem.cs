using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLBangDiem
    {
        DBMain db = null;
        public BLBangDiem()
        {
            db = new DBMain();
        }
        public DataSet LayBangDiem()
        {
            return db.ExecuteQueryDataSet("select * from BangDiem", CommandType.Text);
        }
        public DataSet LaySinhDiemCoDieuKien(string MaSV)
        {
            string sqlDieuKien = "select * from SinhVien where MaSV='" + MaSV + "'";
            return db.ExecuteQueryDataSet(sqlDieuKien, CommandType.Text);
        }
        public bool ThemBangDiem(string MaSV, string TenSV, string MaLop, string MaMH, string HocKy, string KhoaHoc, ref string err)
        {
            string sqlString = "Insert Into BangDiem Values(" + "'" +
            MaSV + "',N'" + TenSV + "','" + MaLop + "','" + MaMH + "',NULL,NULL,NULL,NULL,NULL,'" + HocKy + "','" + KhoaHoc + "',NULL)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaBangDiem(string MaSV, string MaMH, ref string err)
        {
            string sqlString = "Delete From BangDiem Where MaSV='" + MaSV + "' and MaMH ='" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatBangDiem(string MaSV, string MaMH, string HocKy, string KhoaHoc, string MaMHCu, ref string err)
        {
            string sqlString = "Update BangDiem Set HocKy='" + HocKy + "',KhoaHoc='" + KhoaHoc + "',MaMH ='" + MaMH +
            "' Where MaSV = '" + MaSV + "' and MaMH= '" + MaMHCu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDiem(string MaSV, string MaMH, string DiemL1, string DiemL2, string DiemQT, string DiemKT, string DiemTong, ref string err)
        {
            string sqlString = "Update BangDiem Set DiemL1='" + DiemL1 + "',DiemL2='" + DiemL2 + "',DiemQT='" + 
                DiemQT + "',DiemKT='" + DiemKT + "',DiemTK='" + DiemTong +
            "' Where MaSV='" + MaSV + "' and MaMH= '" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool TinhDiemTongKet(string MaSV, string MaMH, string DiemQT, string DiemTong, bool KetQua, ref string err)
        {
            string sqlString = "Update BangDiem Set DiemQT='" + DiemQT + "',DiemTK='" + DiemTong +
                "',KetQua='" + KetQua +"' Where MaSV='" + MaSV + "' and MaMH= '" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool TinhDiemQuaTrinh(string MaSV, string MaMH, string DiemQT, ref string err)
        {
            string sqlString = "Update BangDiem Set DiemQT='" + DiemQT + "' Where MaSV='" + MaSV + "' and MaMH= '" + MaMH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
