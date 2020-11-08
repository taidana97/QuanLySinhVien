using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;

namespace QuanLySinhVien
{
    public partial class frmDanhSachDiemTichLuy : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachDiemTichLuy()
        {
            InitializeComponent();
        }

        private void frmDanhSachDiemTichLuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.DanhSachMonHoc' table. You can move, or remove it, as needed.
            this.DanhSachMonHocTableAdapter.Fill(this.DanhSachSinhVienDataSet.DanhSachMonHoc);

            this.reportDiemTichLuy.RefreshReport();

            SetParameters(cmbMaSV.Text, cmbTenSV.Text, spinHocKy.Text, cmbNamHoc.Text);
            reportDiemTichLuy.RefreshReport();
        }

        private void SetParameters(string maSV, string tenSV, string hocKy, string namHoc)
        {
            ReportParameter[] rp = new ReportParameter[4];

            rp[0] = new ReportParameter("MaSV");
            rp[1] = new ReportParameter("TenSV");
            rp[2] = new ReportParameter("HocKy");
            rp[3] = new ReportParameter("KhoaHoc");

            rp[0].Values.Add("*" + maSV + "*");
            rp[1].Values.Add("*" + tenSV + "*");
            rp[2].Values.Add(hocKy.ToString());
            rp[3].Values.Add("*" + namHoc + "*");
            reportDiemTichLuy.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(cmbMaSV.Text, cmbTenSV.Text, spinHocKy.Text, cmbNamHoc.Text);
            reportDiemTichLuy.RefreshReport();
        }

        private void dockPanel1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThongKe_Click(null, null);
            }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            cmbMaSV.ResetText();
            cmbTenSV.ResetText();
            spinHocKy.ResetText();
            cmbNamHoc.ResetText();
        }
    }
}
