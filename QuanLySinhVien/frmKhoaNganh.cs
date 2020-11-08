using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using System.Data.SqlClient;
using QuanLySinhVien.BS_layer;

namespace QuanLySinhVien
{
    public partial class frmKhoaNganh : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtKhoaNganh = null;
        bool them;
        string err;
        BLKhoaNganh dbKN = new BLKhoaNganh();

        public frmKhoaNganh()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtKhoaNganh = new DataTable();
                dtKhoaNganh.Clear();
                DataSet ds = dbKN.LayKhoaNganh();
                dtKhoaNganh = ds.Tables[0];

                dgvKhoaNganh.DataSource = dtKhoaNganh;

                this.txtMaKhoa.ResetText();
                this.txtTenKhoa.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvKhoaNganh_RowCellClick_2(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void frmKhoaNganh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void gvKhoaNganh_RowCellClick_2(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {            
            int r = gvKhoaNganh.FocusedRowHandle;
            txtMaKhoa.Text = gvKhoaNganh.GetRowCellValue(r, "MaKhoa").ToString();
            txtTenKhoa.Text = gvKhoaNganh.GetRowCellValue(r, "TenKhoa").ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvKhoaNganh_RowCellClick_2(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLKhoaNganh blKN = new BLKhoaNganh();
                    blKN.ThemKhoaNganh(this.txtMaKhoa.Text, this.txtTenKhoa.Text, ref err);

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
                BLKhoaNganh blKN = new BLKhoaNganh();
                blKN.CapNhatKhoaNganh(this.txtMaKhoa.Text, this.txtTenKhoa.Text, ref err);

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void txtMaKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }

        private void txtTenKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtMaKhoa.Enabled = true;
            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvKhoaNganh_RowCellClick_2(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaKhoa.Enabled = false;
            this.txtTenKhoa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvKhoaNganh.FocusedRowHandle;

                string strKhoaNganh = gvKhoaNganh.GetRowCellValue(r, "MaKhoa").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbKN.XoaKhoaNganh(strKhoaNganh, ref err);

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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            dockPanel2.Visibility = DockVisibility.Visible;
        }
    }
}
