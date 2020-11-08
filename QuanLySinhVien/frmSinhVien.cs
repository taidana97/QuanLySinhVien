using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

using QuanLySinhVien.BS_layer;
using System.IO;
using DevExpress.XtraBars.Docking;

namespace QuanLySinhVien
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtSinhVien = null;
        DataTable dtLopSinhVien = null;
        bool them;
        string err;
        BLSinhVien dbSV = new BLSinhVien();
        BLLopSinhVien dbLSV = new BLLopSinhVien();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.LaySinhVien();
                dtSinhVien = ds.Tables[0];

                dtLopSinhVien = new DataTable();
                dtLopSinhVien.Clear();
                DataSet dsKN = dbLSV.LayLopSinhVien();
                dtLopSinhVien = dsKN.Tables[0];

                lookUpMaLop.Properties.DataSource = dtLopSinhVien;
                lookUpMaLop.Properties.DisplayMember = "MaLop";
                lookUpMaLop.Properties.ValueMember = "MaLop";

                gcSinhVien.DataSource = dtSinhVien;

                this.txtMaSV.ResetText();
                this.txtTenSV.ResetText();
                this.rdoNam.ResetText();
                this.rdoNu.ResetText();
                this.txtDiaChi.ResetText();
                this.dateNgaySinh.ResetText();
                this.dateNhapHoc.ResetText();
                this.lookUpMaLop.ResetText();
                this.picHinhSV.Image = null;
                this.picHinhSV.BackgroundImage = null;

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                //gvSinhVien_RowCellClick(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void gvSinhVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvSinhVien.FocusedRowHandle;
            txtMaSV.Text = gvSinhVien.GetRowCellValue(r, "MaSV").ToString();
            txtTenSV.Text = gvSinhVien.GetRowCellValue(r, "TenSV").ToString();
            try 
            {
                dateNgaySinh.Text = (Convert.ToDateTime(gvSinhVien.GetRowCellValue(r, "NgaySinh").ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                dateNgaySinh.Text = gvSinhVien.GetRowCellValue(r, "NgaySinh").ToString();
            }
            if (gvSinhVien.GetRowCellValue(r, "GioiTinh").ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtDiaChi.Text = gvSinhVien.GetRowCellValue(r, "DiaChi").ToString();
            lookUpMaLop.Text = gvSinhVien.GetRowCellValue(r, "MaLop").ToString();
            try
            {
                dateNhapHoc.Text = (Convert.ToDateTime(gvSinhVien.GetRowCellValue(r, "NamNhapHoc").ToString()).ToString("MM/dd/yyyy")).ToString();
            }
            catch
            {
                dateNhapHoc.Text = gvSinhVien.GetRowCellValue(r, "NamNhapHoc").ToString();
            }
            try
            {
                picHinhSV.BackgroundImageLayout = ImageLayout.Zoom;
                picHinhSV.Image = byteArrayToImage((byte[])gvSinhVien.GetRowCellValue(r, "Hinh"));
            }
            catch
            {
                picHinhSV.Image = null;
                picHinhSV.BackgroundImage = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtMaSV.Enabled = true;

            this.txtMaSV.ResetText();
            this.txtTenSV.ResetText();
            this.dateNgaySinh.ResetText();
            this.rdoNam.ResetText();
            this.rdoNu.ResetText();
            this.txtDiaChi.ResetText();
            this.lookUpMaLop.ResetText();
            this.dateNhapHoc.ResetText();
            this.picHinhSV.Image = null;
            this.picHinhSV.BackgroundImage = null;



            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvSinhVien_RowCellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaSV.Enabled = false;
            this.txtTenSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvSinhVien.FocusedRowHandle;

                string strSinhVien = gvSinhVien.GetRowCellValue(r, "MaSV").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbSV.XoaSinhVien(strSinhVien, ref err);

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
                    BLSinhVien blSV = new BLSinhVien();
                    if (picHinhSV.Image == null)
                    {
                        blSV.ThemSinhVien(this.txtMaSV.Text, this.txtTenSV.Text, this.dateNgaySinh.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.lookUpMaLop.Text, this.dateNhapHoc.Text, null, ref err);
                    }
                    else
                    {
                        blSV.ThemSinhVien(this.txtMaSV.Text, this.txtTenSV.Text, this.dateNgaySinh.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.lookUpMaLop.Text, this.dateNhapHoc.Text, imageToByteArray(picHinhSV.Image), ref err);
                    }

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
                BLSinhVien blSV = new BLSinhVien();
                if (picHinhSV.Image == null)
                {
                    blSV.CapNhatSinhVien(this.txtMaSV.Text, this.txtTenSV.Text, this.dateNgaySinh.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.lookUpMaLop.Text, this.dateNhapHoc.Text, null, ref err);
                }
                else
                {
                    blSV.CapNhatSinhVien(this.txtMaSV.Text, this.txtTenSV.Text, this.dateNgaySinh.Text ,this.rdoNam.Checked, this.txtDiaChi.Text, this.lookUpMaLop.Text, this.dateNhapHoc.Text, imageToByteArray(picHinhSV.Image), ref err);
                }

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaSV.ResetText();
            this.txtTenSV.ResetText();
            this.dateNgaySinh.ResetText();
            this.rdoNam.ResetText();
            this.rdoNu.ResetText();
            this.txtDiaChi.ResetText();
            this.lookUpMaLop.ResetText();
            this.dateNhapHoc.ResetText();
            this.picHinhSV.Image = null;
            this.picHinhSV.BackgroundImage = null;

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvSinhVien_RowCellClick(null, null);
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhSV.ImageLocation = openFileDialog.FileName;
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }
    }
}