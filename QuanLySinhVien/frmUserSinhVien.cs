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
    public partial class frmUserSinhVien : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtUserSinhVien = null;
        bool them;
        string err;
        BLUserSinhVien dbUSV = new BLUserSinhVien();

        public frmUserSinhVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtUserSinhVien = new DataTable();
                dtUserSinhVien.Clear();
                DataSet ds = dbUSV.LayNguoiDungSinhVien();
                dtUserSinhVien = ds.Tables[0];

                gcUserSinhVien.DataSource = dtUserSinhVien;

                this.txtUserMaSV.ResetText();
                this.txtPass.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvUserSinhVien_RowCellClick(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table NguoiDungSinhVien. Lỗi rồi!!!");
            }
        }

        private void frmUserSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvUserSinhVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvUserSinhVien.FocusedRowHandle;
            txtUserMaSV.Text = gvUserSinhVien.GetRowCellValue(r, "UserMaSV").ToString();
            txtPass.Text = gvUserSinhVien.GetRowCellValue(r, "Pass").ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtUserMaSV.Enabled = true;
            this.txtUserMaSV.ResetText();
            this.txtPass.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtUserMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvUserSinhVien_RowCellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtUserMaSV.Enabled = false;
            this.txtPass.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvUserSinhVien.FocusedRowHandle;

                string strUserSinhVien = gvUserSinhVien.GetRowCellValue(r, "UserMaSV").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbUSV.XoaNguoiDungSinhVien(strUserSinhVien, ref err);

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
                    BLUserSinhVien blUSV = new BLUserSinhVien();
                    blUSV.ThemNguoiDungSinhVien(this.txtUserMaSV.Text, this.txtPass.Text, ref err);

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
                BLUserSinhVien blUSV = new BLUserSinhVien();
                blUSV.CapNhatNguoiDungSinhVien(this.txtUserMaSV.Text, this.txtPass.Text, ref err);

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtUserMaSV.ResetText();
            this.txtPass.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvUserSinhVien_RowCellClick(null, null);
        }

        private void txtUserMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }
    }
}
