using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DB_layer;

namespace QuanLySinhVien.BS_layer
{
    class BLGiangVien
    {
        DBMain db = null;
        public BLGiangVien()
        {
            db = new DBMain();
        }
        public DataSet LayGiangVien()
        {
            return db.ExecuteQueryDataSet("select MaGV, TenGV, GioiTinh = (CASE GioiTinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END), DiaChi, DienThoai, Email, Anh from GiangVien", CommandType.Text);
        }        
        public bool ThemGiangVien(string MaGV, string TenGV, bool GioiTinh, string DiaChi, string DienThoai, string Email, object hinhAnh, ref string err)
        {
            string sqlString = "Insert Into GiangVien Values(" + "'" +
                MaGV + "',N'" + TenGV + "','" + GioiTinh + "',N'" + DiaChi + "','" + DienThoai + "','" + Email + "',@hinh)";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("Insert Into GiangVien Values(" + "'" +
                    MaGV + "',N'" + TenGV + "','" + GioiTinh + "',N'" + DiaChi + "','" +
                    DienThoai + "','" + Email + "',NULL)", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
        public bool XoaGiangVien(string MaGV, ref string err)
        {
            string sqlString = "Delete From GiangVien Where MaGV='" + MaGV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatGiangVien(string MaGV, string TenGV, bool GioiTinh, string DiaChi, string DienThoai, string Email, object hinhAnh, ref string err)
        {
            string sqlString = "Update GiangVien Set TenGV=N'" +
            TenGV + "',GioiTinh='" + GioiTinh + "',DiaChi=N'" + DiaChi + "',DienThoai='" + DienThoai +
            "',Email='" + Email  + "',Anh = @hinh Where MaGV='" + MaGV + "'";
            if (hinhAnh == null)
            {
                return db.MyExecuteNonQuery("Update GiangVien Set TenGV=N'" +
                    TenGV + "',GioiTinh='" + GioiTinh + "',DiaChi=N'" + DiaChi + "',DienThoai='" + DienThoai +
                    "',Email='" + Email + "',Anh = NULL Where MaGV='" + MaGV + "'", CommandType.Text, ref err);
            }
            return db.QueryHinh(sqlString, hinhAnh, CommandType.Text, ref err);
        }
    }
}
