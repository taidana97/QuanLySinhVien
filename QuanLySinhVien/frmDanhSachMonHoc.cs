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
    public partial class frmDanhSachMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachMonHoc()
        {
            InitializeComponent();
        }

        private void frmDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.DanhSachSinhVienDataSet.GiangVien);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.DanhSachSinhVienDataSet.MonHoc);
            // TODO: This line of code loads data into the 'DanhSachSinhVienDataSet.DanhSachMonHoc' table. You can move, or remove it, as needed.
            this.DanhSachMonHocTableAdapter.Fill(this.DanhSachSinhVienDataSet.DanhSachMonHoc);

            this.reportDanhSachMonHoc.RefreshReport();

            SetParameters(cmbTenMH.Text, cmbTenGV.Text, spinHocKy.Text, cmbNamHoc.Text);
            reportDanhSachMonHoc.RefreshReport();
        }

        private void SetParameters(string tenMH, string tenGV, string hocKy, string namHoc)
        {
            ReportParameter[] rp = new ReportParameter[4];

            rp[0] = new ReportParameter("TenMH");
            rp[1] = new ReportParameter("TenGV");
            rp[2] = new ReportParameter("HocKy");
            rp[3] = new ReportParameter("KhoaHoc");

            rp[0].Values.Add("*" + tenMH + "*");
            rp[1].Values.Add("*" + tenGV + "*");
            rp[2].Values.Add(hocKy.ToString());
            rp[3].Values.Add("*" + namHoc + "*");
            reportDanhSachMonHoc.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(cmbTenMH.Text, cmbTenGV.Text, spinHocKy.Text, cmbNamHoc.Text);
            reportDanhSachMonHoc.RefreshReport();
        }

        private void cmbTenMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThongKe_Click(null, null);
            }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            this.cmbTenGV.ResetText();
            this.cmbTenMH.ResetText();
            this.cmbNamHoc.ResetText();
            this.spinHocKy.ResetText();   
        }
    }
}