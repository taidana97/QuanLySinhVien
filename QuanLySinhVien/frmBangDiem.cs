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
    public partial class frmBangDiem : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtBangDiem = null;
        DataTable dtMonHoc = null;
        DataTable dtSinhVien = null;
        DataTable dtWhere_MaSV = null;
        bool them = true;
        bool suaDiem = false;
        string err;
        string boolKetQua = "";
        string selectDienKien = "";
        string MaMHCu = "";
        double diemL1;
        double diemL2;
        double diemQT;
        double diemKT;
        double diemTK;
        BLBangDiem dbBD = new BLBangDiem();
        BLMonHoc dbMH = new BLMonHoc();
        BLSinhVien dbSV = new BLSinhVien();
        BLBangDiem blBD_MaSV = new BLBangDiem();

        public frmBangDiem()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtBangDiem = new DataTable();
                dtBangDiem.Clear();
                DataSet ds = dbBD.LayBangDiem();
                dtBangDiem = ds.Tables[0];

                gcBangDiem.DataSource = dtBangDiem;
                
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                DataSet dsMH = dbMH.LayMonHoc();
                dtMonHoc = dsMH.Tables[0];

                lookUpMaMH.Properties.DataSource = dtMonHoc;
                lookUpMaMH.Properties.DisplayMember = "MaMH";
                lookUpMaMH.Properties.ValueMember = "MaMH";
                
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet dsSV = dbSV.LaySinhVien();
                dtSinhVien = dsSV.Tables[0];

                lookUpMaSV.Properties.DataSource = dtSinhVien;
                lookUpMaSV.Properties.DisplayMember = "MaSV";
                lookUpMaSV.Properties.ValueMember = "MaSV";                

                this.lookUpMaSV.ResetText();
                this.txtTenSV.ResetText();
                this.txtMaLop.ResetText();
                this.lookUpMaMH.ResetText();
                this.txtDiemL1.ResetText();
                this.txtDiemL2.ResetText();
                this.txtDiemQT.ResetText();
                this.txtDiemKT.ResetText();
                this.txtDiemTK.ResetText();
                this.spinHocKy.ResetText();
                this.txtKhoaHoc.ResetText();
                this.chkKetQua.Reset();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.layoutControl1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSuaDiem.Enabled = true;
                this.btnTroVe.Enabled = true;
                gvBangDiem_RowCellClick(null, null);                

            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Không lấy được nội dung trong table BangDiem. Lỗi rồi!!!");
            }
        }

        private void gvBangDiem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int r = gvBangDiem.FocusedRowHandle;
            lookUpMaSV.Text = gvBangDiem.GetRowCellValue(r, "MaSV").ToString();
            txtTenSV.Text = gvBangDiem.GetRowCellValue(r, "TenSV").ToString();
            txtMaLop.Text = gvBangDiem.GetRowCellValue(r, "MaLop").ToString();
            lookUpMaMH.Text = gvBangDiem.GetRowCellValue(r, "MaMH").ToString();
            txtDiemL1.Text = gvBangDiem.GetRowCellValue(r, "DiemL1").ToString();
            txtDiemL2.Text = gvBangDiem.GetRowCellValue(r, "DiemL2").ToString();
            txtDiemQT.Text = gvBangDiem.GetRowCellValue(r, "DiemQT").ToString();
            txtDiemKT.Text = gvBangDiem.GetRowCellValue(r, "DiemKT").ToString();
            txtDiemTK.Text = gvBangDiem.GetRowCellValue(r, "DiemTK").ToString();
            spinHocKy.Text = gvBangDiem.GetRowCellValue(r, "HocKy").ToString();
            txtKhoaHoc.Text = gvBangDiem.GetRowCellValue(r, "KhoaHoc").ToString();
            boolKetQua = gvBangDiem.GetRowCellValue(r, "KetQua").ToString().Trim();
            if (boolKetQua == "True")
            {
                chkKetQua.Checked = true;
            }
            else
            {
                chkKetQua.Checked = false;              
            }
            MaMHCu = gvBangDiem.GetRowCellValue(r, "MaMH").ToString(); 
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            suaDiem = false;
            this.layoutControl1.Enabled = true;
            this.lookUpMaSV.Enabled = true;
            this.txtTenSV.Enabled = true;
            this.txtMaLop.Enabled = true;
            this.lookUpMaMH.Enabled = true;
            this.spinHocKy.Enabled = true;
            this.txtKhoaHoc.Enabled = true;

            this.txtDiemL1.Enabled = false;
            this.txtDiemL2.Enabled = false;
            this.txtDiemQT.Enabled = false;
            this.txtDiemKT.Enabled = false;
            this.txtDiemTK.Enabled = false;
            this.chkKetQua.Enabled = false;

            this.txtDiemL1.ResetText();
            this.txtDiemL2.ResetText();
            this.txtDiemQT.ResetText();
            this.txtDiemKT.ResetText();
            this.txtDiemTK.ResetText();
            this.spinHocKy.ResetText();
            this.txtKhoaHoc.ResetText();
            this.chkKetQua.Reset();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.layoutControl1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSuaDiem.Enabled = false;
            this.btnTroVe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            suaDiem = false;

            this.layoutControl1.Enabled = true;
            gvBangDiem_RowCellClick(null, null);


            this.layoutControl1.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.txtDiemL1.Enabled = false;
            this.txtDiemL2.Enabled = false;
            this.txtDiemQT.Enabled = false;
            this.txtDiemKT.Enabled = false;
            this.txtDiemTK.Enabled = false;
            this.chkKetQua.Enabled = false;
            this.spinHocKy.Enabled = true;
            this.txtKhoaHoc.Enabled = true;
            

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnSuaDiem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.lookUpMaSV.Enabled = false;
            this.txtTenSV.Enabled = false;
            this.txtMaLop.Enabled = false;
            this.lookUpMaMH.Enabled = true; ;
            this.spinHocKy.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvBangDiem.FocusedRowHandle;

                string strBangDiem_MaSV = gvBangDiem.GetRowCellValue(r, "MaSV").ToString();
                string strBangDiem_MaMH = gvBangDiem.GetRowCellValue(r, "MaMH").ToString();
                DialogResult traloi;
                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    dbBD.XoaBangDiem(strBangDiem_MaSV, strBangDiem_MaMH, ref err);

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
                
                if (suaDiem == true)
                {
                    BLBangDiem blBD = new BLBangDiem();
                    blBD.CapNhatDiem(this.lookUpMaSV.Text, this.lookUpMaMH.Text,
                            this.txtDiemL1.Text.Replace(",", "."), this.txtDiemL2.Text.Replace(",", "."),
                            this.txtDiemQT.Text.Replace(",", "."), this.txtDiemKT.Text.Replace(",", "."),
                            this.txtDiemTK.Text.Replace(",", "."), ref err);

                    LoadData();

                    XtraMessageBox.Show("Đã sửa điểm xong!");
                }
                else
                {
                    try
                    {
                        BLBangDiem blBD = new BLBangDiem();
                        blBD.ThemBangDiem(this.lookUpMaSV.Text, this.txtTenSV.Text.TrimEnd(), this.txtMaLop.Text, this.lookUpMaMH.Text, this.spinHocKy.Text, txtKhoaHoc.Text.TrimEnd(), ref err);

                        LoadData();

                        XtraMessageBox.Show("Đã thêm xong!");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
            }
            else
            {
                if (suaDiem == true)
                {
                    BLBangDiem blBD = new BLBangDiem();
                    blBD.CapNhatDiem(this.lookUpMaSV.Text, this.lookUpMaMH.Text,
                            this.txtDiemL1.Text.Replace(",", "."), this.txtDiemL2.Text.Replace(",", "."),
                            this.txtDiemQT.Text.Replace(",", "."), this.txtDiemKT.Text.Replace(",", "."),
                            this.txtDiemTK.Text.Replace(",", "."), ref err);

                    LoadData();
                    
                    XtraMessageBox.Show("Đã sửa điểm xong!");
                }
                else
                {
                    BLBangDiem blBD = new BLBangDiem();
                    blBD.CapNhatBangDiem(this.lookUpMaSV.Text, this.lookUpMaMH.Text,
                        this.spinHocKy.Text, txtKhoaHoc.Text.TrimEnd(), MaMHCu, ref err);
                    LoadData();

                    XtraMessageBox.Show("Đã sửa xong!");
                }
            }
           

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtDiemL1.ResetText();
            this.txtDiemL2.ResetText();
            this.txtDiemQT.ResetText();
            this.txtDiemKT.ResetText();
            this.txtDiemTK.ResetText();
            this.spinHocKy.ResetText();
            this.txtKhoaHoc.ResetText();
            this.chkKetQua.Reset();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSuaDiem.Enabled = true;
            this.btnTroVe.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.layoutControl1.Enabled = false;
            gvBangDiem_RowCellClick(null, null);
        }

        private void lookUpMaSV_EditValueChanged(object sender, EventArgs e)
        {
            selectDienKien = lookUpMaSV.Text;
                        
            // Select điệu kiện Mã sinh viên
            dtWhere_MaSV = new DataTable();
            dtWhere_MaSV.Clear();
            DataSet dsWhere_MaSV = dbBD.LaySinhDiemCoDieuKien(selectDienKien.Trim());
            dtWhere_MaSV = dsWhere_MaSV.Tables[0];

            txtTenSV.Text = dtWhere_MaSV.Rows[0][1].ToString();
            txtMaLop.Text = dtWhere_MaSV.Rows[0][5].ToString();
        }

        private void btnQiemTK_Click(object sender, EventArgs e)
        {
            try
            {
                diemL1 = double.Parse(txtDiemL1.Text);
                diemL2 = double.Parse(txtDiemL2.Text);
                diemKT = double.Parse(txtDiemKT.Text);
                diemQT = (diemL1 + diemL2) / 2;
                diemTK = (diemQT + diemKT) / 2;
                if (diemTK >= 5)
                {
                    chkKetQua.Checked = true;
                }
                else
                {
                    chkKetQua.Checked = false;
                }
                BLBangDiem blBD = new BLBangDiem();
                blBD.TinhDiemTongKet(this.lookUpMaSV.Text, this.lookUpMaMH.Text, diemQT.ToString().Replace(",", "."), diemTK.ToString().Replace(",", "."), chkKetQua.Checked, ref err);

                LoadData();

                XtraMessageBox.Show("Đã tính xong điểm tổng kết!");
            }
            catch
            {
                XtraMessageBox.Show("Thiếu dữ liệu hoặc lỗi rồi!");
            }
        }

        private void btnDiemQT_Click(object sender, EventArgs e)
        {
            try
            {
                diemL1 = double.Parse(txtDiemL1.Text);
                diemL2 = double.Parse(txtDiemL2.Text);
                diemQT = (diemL1 + diemL2) / 2;
                BLBangDiem blBD = new BLBangDiem();
                blBD.TinhDiemQuaTrinh(this.lookUpMaSV.Text, this.lookUpMaMH.Text, diemQT.ToString().Replace(",", "."), ref err);

                LoadData();

                XtraMessageBox.Show("Đã tính xong điểm quá trình!");
            }
            catch
            {
                XtraMessageBox.Show("Thiếu dữ liệu hoặc lỗi rồi!");
            }
        }

        private void lookUpMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(null, null);
            }
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            suaDiem = true;

            this.layoutControl1.Enabled = true;
            gvBangDiem_RowCellClick(null, null);
            

            this.layoutControl1.Enabled =true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.lookUpMaSV.Enabled = false;
            this.txtTenSV.Enabled = false;
            this.txtMaLop.Enabled = false;
            this.lookUpMaMH.Enabled = false;
            this.chkKetQua.Enabled = false;            
            this.spinHocKy.Enabled = false;
            this.txtKhoaHoc.Enabled = false;
            this.txtDiemL1.Enabled = true;
            this.txtDiemL2.Enabled = true;
            this.txtDiemQT.Enabled = true;
            this.txtDiemKT.Enabled = true;
            this.txtDiemTK.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSuaDiem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtDiemL1.Focus();
        }
    }
}