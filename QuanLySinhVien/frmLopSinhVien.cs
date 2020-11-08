using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;

using QuanLySinhVien.BS_layer;

namespace QuanLySinhVien
{
    public partial class frmLopSinhVien : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtLopSinhVien = null;
        DataTable dtKhoaNganh = null;
        bool them;
        string err;
        BLLopSinhVien dbLSV = new BLLopSinhVien();
        BLKhoaNganh dbKN = new BLKhoaNganh();

        public frmLopSinhVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtLopSinhVien = new DataTable();
                dtLopSinhVien.Clear();
                DataSet ds = dbLSV.LayLopSinhVien();
                dtLopSinhVien = ds.Tables[0];

                gcLopSinhVien.DataSource = dtLopSinhVien;

                dtKhoaNganh = new DataTable();
                dtKhoaNganh.Clear();
                DataSet dsKN = dbKN.LayKhoaNganh();
                dtKhoaNganh = dsKN.Tables[0];
                
                LookUpKhoa.Properties.DataSource = dtKhoaNganh;
                LookUpKhoa.Properties.DisplayMember = "MaKhoa";
                LookUpKhoa.Properties.ValueMember = "MaKhoa";

                this.txtMaLop.ResetText();
                this.LookUpKhoa.ResetText();
                this.txtTenLop.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvLopSinhVien_RowCellClick(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            dockPanel3.Visibility = DockVisibility.Visible;
        }

        private void gvLopSinhVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvLopSinhVien.FocusedRowHandle;
            txtMaLop.Text = gvLopSinhVien.GetRowCellValue(r, "MaLop").ToString();
            LookUpKhoa.Text = gvLopSinhVien.GetRowCellValue(r, "MaKhoa").ToString();
            txtTenLop.Text = gvLopSinhVien.GetRowCellValue(r, "TenLop").ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtMaLop.Enabled = true;

            this.txtMaLop.ResetText();
            this.txtTenLop.ResetText();
            this.LookUpKhoa.ResetText();

            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvLopSinhVien_RowCellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaLop.Enabled = false;
            this.LookUpKhoa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvLopSinhVien.FocusedRowHandle;

                string strLopSinhVien = gvLopSinhVien.GetRowCellValue(r, "MaLop").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbLSV.XoaLopSinhVien(strLopSinhVien, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    XtraMessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                XtraMessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Chắc không?", "Trả lời",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLLopSinhVien blLSV = new BLLopSinhVien();
                    blLSV.ThemLopSinhVien(this.txtMaLop.Text, this.LookUpKhoa.Text, this.txtTenLop.Text, ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    XtraMessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLLopSinhVien blLSV = new BLLopSinhVien();
                blLSV.CapNhatLopSinhVien(this.txtMaLop.Text, this.LookUpKhoa.Text, this.txtTenLop.Text, ref err);

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaLop.ResetText();
            this.LookUpKhoa.ResetText();
            this.txtTenLop.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvLopSinhVien_RowCellClick(null, null);
        }

        private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }

        private void lokKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }

        private void txtTenLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }
        
    }
}