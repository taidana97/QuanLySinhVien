using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using System.Data.SqlClient;
using QuanLySinhVien.BS_layer;

namespace QuanLySinhVien
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtMonHoc = null;
        DataTable dtGiangVien = null;
        bool them;
        string err;
        BLMonHoc dbMH = new BLMonHoc();
        BLGiangVien dbGV = new BLGiangVien();

        public frmMonHoc()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                DataSet ds = dbMH.LayMonHoc();
                dtMonHoc = ds.Tables[0];

                gcMonHoc.DataSource = dtMonHoc;

                dtGiangVien = new DataTable();
                dtGiangVien.Clear();
                DataSet dsGV = dbGV.LayGiangVien();
                dtGiangVien = dsGV.Tables[0];

                lookUpMaGV.Properties.DataSource = dtGiangVien;
                lookUpMaGV.Properties.DisplayMember = "MaGV";
                lookUpMaGV.Properties.ValueMember = "MaGV";

                this.txtMaMH.ResetText();
                this.txtTenMH.ResetText();
                this.spinSoTC.ResetText();
                this.lookUpMaGV.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvMonHoc_RowCellClick(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtMaMH.Enabled = true;

            this.txtMaMH.ResetText();
            this.txtTenMH.ResetText();
            this.spinSoTC.ResetText();
            this.lookUpMaGV.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaMH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvMonHoc_RowCellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaMH.Enabled = false;
            this.txtTenMH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvMonHoc.FocusedRowHandle;

                string strMonHoc = gvMonHoc.GetRowCellValue(r, "MaMH").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbMH.XoaMonHoc(strMonHoc, ref err);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            dockInfor.Visibility = DockVisibility.Visible;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLMonHoc blMH = new BLMonHoc();
                    blMH.ThemMonHoc(this.txtMaMH.Text, this.txtTenMH.Text.TrimEnd(), (int)this.spinSoTC.Value, this.lookUpMaGV.Text,  ref err);

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
                BLMonHoc blMH = new BLMonHoc();
                blMH.CapNhatMonHoc(this.txtMaMH.Text, this.txtTenMH.Text.TrimEnd(), (int)this.spinSoTC.Value, this.lookUpMaGV.Text, ref err);

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaMH.ResetText();
            this.txtTenMH.ResetText();
            this.spinSoTC.ResetText();
            this.lookUpMaGV.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvMonHoc_RowCellClick(null, null);
        }

        private void gvMonHoc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvMonHoc.FocusedRowHandle;
            txtMaMH.Text = gvMonHoc.GetRowCellValue(r, "MaMH").ToString();
            txtTenMH.Text = gvMonHoc.GetRowCellValue(r, "TenMH").ToString();
            spinSoTC.Text = gvMonHoc.GetRowCellValue(r, "SoTC").ToString();
            lookUpMaGV.Text = gvMonHoc.GetRowCellValue(r, "MaGV").ToString();
        }

        private void txtMaMH_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }
    }
}