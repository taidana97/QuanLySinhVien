using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;

namespace QuanLySinhVien
{
    public partial class frmDanhSachBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachBangDiem()
        {
            InitializeComponent();
        }

        private void frmDanhSachBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.GiangVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.DanhSachSinhVienDataSet.MonHoc);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.DanhSachMonHoc' table. You can move, or remove it, as needed.
            this.DanhSachMonHocTableAdapter.Fill(this.DanhSachSinhVienDataSet.DanhSachMonHoc);

            this.reportDanhSachBangDiem.RefreshReport();
        }

        private void SetParameters(string maSV, string tenSV,string tenMH, string tenGV, string hocKy, string namHoc, string diemL1Lon, string diemL1Nho,
            string diemL2Lon, string diemL2Nho, string diemQTLon, string diemQTNho, string diemKTLon, string diemKTNho, string diemTKLon, string diemTKNho)
        {
            ReportParameter[] rp = new ReportParameter[16];

            rp[0] = new ReportParameter("MaSV");
            rp[1] = new ReportParameter("TenSV");
            rp[2] = new ReportParameter("TenMH");
            rp[3] = new ReportParameter("TenGV");
            rp[4] = new ReportParameter("HocKy");
            rp[5] = new ReportParameter("KhoaHoc");
            rp[6] = new ReportParameter("DiemL1Lon");
            rp[7] = new ReportParameter("DiemL1Nho");
            rp[8] = new ReportParameter("DiemL2Lon");
            rp[9] = new ReportParameter("DiemL2Nho");
            rp[10] = new ReportParameter("DiemQTLon");
            rp[11] = new ReportParameter("DiemQTNho");
            rp[12] = new ReportParameter("DiemKTLon");
            rp[13] = new ReportParameter("DiemKTNho");
            rp[14] = new ReportParameter("DiemTKLon");
            rp[15] = new ReportParameter("DiemTKNho");

            rp[0].Values.Add("*" + maSV + "*");
            rp[1].Values.Add("*" + tenSV + "*");
            rp[2].Values.Add("*" + tenMH + "*");
            rp[3].Values.Add("*" + tenGV + "*");
            rp[4].Values.Add(hocKy.ToString());
            rp[5].Values.Add("*" + namHoc + "*");
            rp[6].Values.Add(diemL1Lon);
            rp[7].Values.Add(diemL1Nho);
            rp[8].Values.Add(diemL2Lon);
            rp[9].Values.Add(diemL2Nho);
            rp[10].Values.Add(diemQTLon);
            rp[11].Values.Add(diemQTNho);
            rp[12].Values.Add(diemKTLon);
            rp[13].Values.Add(diemKTNho);
            rp[14].Values.Add(diemTKLon);
            rp[15].Values.Add(diemTKNho);

            reportDanhSachBangDiem.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(cmbMaSV.Text, cmbTenSV.Text,cmbTenMH.Text, cmbTenGV.Text, spinHocKy.Text, cmbNamHoc.Text, 
                txtDiemL1Lon.Text, txtDiemL1Nho.Text, txtDiemL2Lon.Text, txtDiemL2Nho.Text, txtDiemQTLon.Text, txtDiemQTNho.Text,
                txtDiemKTLon.Text, txtDiemKTNho.Text, txtDiemTKLon.Text, txtDiemTKNho.Text);
            reportDanhSachBangDiem.RefreshReport();
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            cmbMaSV.ResetText();
            cmbTenGV.ResetText();
            cmbTenSV.ResetText();
            cmbTenMH.ResetText();
            cmbNamHoc.ResetText();
            spinHocKy.ResetText();
            txtDiemL1Lon.Text = "0";
            txtDiemL1Nho.Text = "10";
            txtDiemL2Lon.Text = "0";
            txtDiemL2Nho.Text = "10";
            txtDiemQTLon.Text = "0";
            txtDiemQTNho.Text = "10";
            txtDiemKTLon.Text = "0";
            txtDiemKTNho.Text = "10";
            txtDiemTKLon.Text = "0";
            txtDiemTKNho.Text = "10";   
        }
    }
}