using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLSinhVien
    {
        DBMain db = null;
        public BLSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LaySinhVien()
        {
            return db.ExecuteQueryDataSet("select MaSV, TenSV, NgaySinh," +
                "GioiTinh = (CASE GioiTinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END)," + 
                "DiaChi,MaLop,NamNhapHoc,Hinh from SinhVien", CommandType.Text);
        }
        public bool ThemSinhVien(string MaSV, string TenSV, string NgaySinh, bool GioiTinh, string DiaChi, string MaLop, string NamNhapHoc, object hinhAnh, ref string err)
        {
            string sqlString = "Insert Into SinhVien Values(" + "'" +
                MaSV + "',N'" + TenSV + "','" + NgaySinh + "','" + GioiTinh + "',N'" + DiaChi + "','" + MaLop + "','" + NamNhapHoc + "',@hinh)";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("Insert Into SinhVien Values(" + "'" +
                    MaSV + "',N'" + TenSV + "','" + NgaySinh +"','" + GioiTinh + "',N'" + DiaChi + "','" +
                    MaLop + "','" + NamNhapHoc + "',NULL)", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
        public bool XoaSinhVien(string MaSV, ref string err)
        {
            string sqlString = "Delete From SinhVien Where MaSV='" + MaSV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSinhVien(string MaSV, string TenSV, string NgaySinh, bool GioiTinh, string DiaChi, string MaLop, string NamNhapHoc, object hinhAnh, ref string err)
        {
            string sqlString = "Update SinhVien Set TenSV=N'" +
            TenSV + "',NgaySinh=CAST('" + NgaySinh + "' as date)" + ",GioiTinh='" + 
            GioiTinh + "',DiaChi=N'" + DiaChi + "',MaLop='" + MaLop +
            "',NamNhapHoc=CAST('" + NamNhapHoc + "' as date)" + ",Hinh = @hinh Where MaSV='" + MaSV + "'";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("Update SinhVien Set TenSV=N'" +
            TenSV + "',NgaySinh=CAST('" + NgaySinh + "' as date)" + ",GioiTinh='" + 
            GioiTinh + "',DiaChi=N'" + DiaChi + "',MaLop='" + MaLop +
            "',NamNhapHoc=CAST('" + NamNhapHoc + "' as date)" + ",Hinh = NULL Where MaSV='" + MaSV + "'", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
    }
}
