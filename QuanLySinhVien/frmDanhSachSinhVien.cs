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
    public partial class frmDanhSachSinhVien : DevExpress.XtraEditors.XtraForm
    {

        public frmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.LopSinhVien' table. You can move, or remove it, as needed.
            this.lopSinhVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.LopSinhVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.KhoaNganh' table. You can move, or remove it, as needed.
            this.khoaNganhTableAdapter.Fill(this.DanhSachSinhVienDataSet.KhoaNganh);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.DanhSachSinhVien' table. You can move, or remove it, as needed.
            this.DanhSachSinhVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.DanhSachSinhVien);

            this.reportDSSV.RefreshReport();

            this.cmbMaSV.ResetText();
            this.cmbTenSV.ResetText();
            this.cmbLop.ResetText();
            this.cmbKhoa.ResetText();
            
            SetParameters(cmbMaSV.Text, cmbTenSV.Text, cmbLop.Text, cmbKhoa.Text);
            this.reportDSSV.RefreshReport();
        }

        private void SetParameters(string maSV, string tenSV, string tenLop, string tenKhoa)
        {
            ReportParameter[] rp = new ReportParameter[4];

            rp[0] = new ReportParameter("MaSV");
            rp[1] = new ReportParameter("TenSV");
            rp[2] = new ReportParameter("TenLop");
            rp[3] = new ReportParameter("TenKhoa");

            rp[0].Values.Add("*" + maSV + "*");
            rp[1].Values.Add("*" + tenSV + "*");
            rp[2].Values.Add("*" + tenLop + "*");
            rp[3].Values.Add("*" + tenKhoa + "*");
            reportDSSV.LocalReport.SetParameters(rp);            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(cmbMaSV.Text, cmbTenSV.Text, cmbLop.Text, cmbKhoa.Text);
            reportDSSV.RefreshReport();
        }

        private void cmbLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThongKe_Click(null, null);
            }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            this.cmbMaSV.ResetText();
            this.cmbTenSV.ResetText();
            this.cmbLop.ResetText();
            this.cmbKhoa.ResetText();
        }
    }
}