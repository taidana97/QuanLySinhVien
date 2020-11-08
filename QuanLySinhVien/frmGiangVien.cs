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
using System.IO;

namespace QuanLySinhVien
{
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtGiangVien = null;
        bool them;
        string err;
        BLGiangVien dbGV = new BLGiangVien();

        public frmGiangVien()
        {
            InitializeComponent();           
        }

        void LoadData()
        {
            try
            {
                dtGiangVien = new DataTable();
                dtGiangVien.Clear();
                DataSet ds = dbGV.LayGiangVien();
                dtGiangVien = ds.Tables[0];

                gcGiangVien.DataSource = dtGiangVien;

                this.txtMaGV.ResetText();
                this.txtTenGV.ResetText();
                this.rdoNam.ResetText();
                this.rdoNu.ResetText();
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();
                this.txtEmail.ResetText();
                this.picHinhGV.Image = null;
                this.picHinhGV.BackgroundImage = null;

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvGiangVien_RowCellClick(null, null);

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            this.txtMaGV.Enabled = true;

            this.txtMaGV.ResetText();
            this.txtTenGV.ResetText();
            this.rdoNam.ResetText();
            this.rdoNu.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtEmail.ResetText();
            this.picHinhGV.Image = null;
            //this.picHinhGV.Invalidate();
            this.picHinhGV.BackgroundImage = null;



            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.layoutControl1.Enabled = true;
            gvGiangVien_RowCellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;
            
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaGV.Enabled = false;
            this.txtTenGV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvGiangVien.FocusedRowHandle;

                string strKhoaNganh = gvGiangVien.GetRowCellValue(r, "MaGV").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbGV.XoaGiangVien(strKhoaNganh, ref err);

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
            dplThongTin.Visibility = DockVisibility.Visible;
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
                    BLGiangVien blGV = new BLGiangVien();
                    if (picHinhGV.Image == null)
                    {
                        blGV.ThemGiangVien(this.txtMaGV.Text, this.txtTenGV.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.txtDienThoai.Text, this.txtEmail.Text, null, ref err);
                    }
                    else
                    {
                        blGV.ThemGiangVien(this.txtMaGV.Text, this.txtTenGV.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.txtDienThoai.Text, this.txtEmail.Text, imageToByteArray(picHinhGV.Image), ref err);
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
                BLGiangVien blGV = new BLGiangVien();
                if (picHinhGV.Image == null)
                {
                    blGV.CapNhatGiangVien(this.txtMaGV.Text, this.txtTenGV.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.txtDienThoai.Text, this.txtEmail.Text, null, ref err);
                }
                else
                {
                    blGV.CapNhatGiangVien(this.txtMaGV.Text, this.txtTenGV.Text, this.rdoNam.Checked, this.txtDiaChi.Text, this.txtDienThoai.Text, this.txtEmail.Text, imageToByteArray(picHinhGV.Image), ref err);
                }

                LoadData();

                XtraMessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaGV.ResetText();
            this.txtTenGV.ResetText();
            this.rdoNam.ResetText();
            this.rdoNu.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtEmail.ResetText();
            this.picHinhGV.Image = null;
            //this.picHinhGV.Invalidate();
            this.picHinhGV.BackgroundImage = null;

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvGiangVien_RowCellClick(null, null);
        }

        private void gvGiangVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvGiangVien.FocusedRowHandle;
            txtMaGV.Text = gvGiangVien.GetRowCellValue(r, "MaGV").ToString();
            txtTenGV.Text = gvGiangVien.GetRowCellValue(r, "TenGV").ToString(); 
            if (gvGiangVien.GetRowCellValue(r, "GioiTinh").ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtDiaChi.Text = gvGiangVien.GetRowCellValue(r, "DiaChi").ToString();
            txtDienThoai.Text = gvGiangVien.GetRowCellValue(r, "DienThoai").ToString();
            txtEmail.Text = gvGiangVien.GetRowCellValue(r, "Email").ToString();
            try
            {
                picHinhGV.BackgroundImageLayout = ImageLayout.Zoom;
                picHinhGV.Image = byteArrayToImage((byte[])gvGiangVien.GetRowCellValue(r, "Anh"));
            }
            catch
            {
                picHinhGV.Image = null;
                picHinhGV.BackgroundImage = null;
            }

        }

        private void txtMaGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhGV.ImageLocation = openFileDialog.FileName;
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

        //public Button myButton
        //{
        //    get
        //    {
        //        return btnInfor;
        //    }
        //}
    }
}