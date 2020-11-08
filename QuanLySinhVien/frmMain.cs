using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;

namespace QuanLySinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static bool bIsLogin = false;

        public frmMain()
        {
            InitializeComponent();
        }
        
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        } 

        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            btnDangXuat.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            rbnDanhSach.Enabled = false;
            rbnQuanLyThongTin.Enabled = false;
        }

        private void barKhoaNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKhoaNganh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhoaNganh f = new frmKhoaNganh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barLopSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLopSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLopSinhVien f = new frmLopSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmGiangVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiangVien f = new frmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap login = new frmDangNhap();
            login.ShowDialog();
            if (frmMain.bIsLogin == true)
            {
                btnDangXuat.Enabled = true;
                btnDoiMatKhau.Enabled = true;
                barlbTenDangNhap.Caption = "Tên đăng nhập: "+ frmDangNhap.strTenDangNhap;
                btnLogin.Enabled = false;
                rbnDanhSach.Enabled = true;
                rbnQuanLyThongTin.Enabled = true;
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmGiangVien frm = new frmGiangVien();
            //frm.myButton.PerformClick();
        }

        private void barSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barUserSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmUserSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmUserSinhVien f = new frmUserSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBangDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBangDiem f = new frmBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau changePass = new frmDoiMatKhau();
            changePass.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                btnLogin.Enabled = true;
                btnDoiMatKhau.Enabled = false;
                rbnDanhSach.Enabled = false;
                rbnQuanLyThongTin.Enabled = false;
            }
            barlbTenDangNhap.Caption = "";
        }

        private void btnDanhSachSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDanhSachSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachSinhVien f = new frmDanhSachSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangSachDiemTichLuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDanhSachDiemTichLuy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachDiemTichLuy f = new frmDanhSachDiemTichLuy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhSachMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDanhSachMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachMonHoc f = new frmDanhSachMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhSachBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDanhSachBangDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachBangDiem f = new frmDanhSachBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
