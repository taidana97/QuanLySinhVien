namespace QuanLySinhVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barKhoaNganh = new DevExpress.XtraBars.BarButtonItem();
            this.barLopSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barUserSV = new DevExpress.XtraBars.BarButtonItem();
            this.barSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.barMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.lbTenDangNhap = new DevExpress.XtraBars.BarHeaderItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangSachDiemTichLuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barlbTenDangNhap = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnDanhSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnQuanLyThongTin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barKhoaNganh,
            this.barLopSinhVien,
            this.barUserSV,
            this.barSinhVien,
            this.barGiangVien,
            this.barMonHoc,
            this.barBangDiem,
            this.skinRibbonGalleryBarItem2,
            this.btnLogin,
            this.barButtonItem1,
            this.btnDoiMatKhau,
            this.barHeaderItem1,
            this.lbTenDangNhap,
            this.btnDangXuat,
            this.btnDanhSachSinhVien,
            this.btnDangSachDiemTichLuy,
            this.btnDanhSachMonHoc,
            this.btnDanhSachBangDiem,
            this.barlbTenDangNhap});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 30;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(828, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barKhoaNganh
            // 
            this.barKhoaNganh.Caption = "Khoa Ngành";
            this.barKhoaNganh.Glyph = global::QuanLySinhVien.Properties.Resources.students_cap;
            this.barKhoaNganh.Id = 1;
            this.barKhoaNganh.Name = "barKhoaNganh";
            this.barKhoaNganh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKhoaNganh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKhoaNganh_ItemClick);
            // 
            // barLopSinhVien
            // 
            this.barLopSinhVien.Caption = "Lớp Sinh Viên";
            this.barLopSinhVien.Glyph = global::QuanLySinhVien.Properties.Resources.classroom;
            this.barLopSinhVien.Id = 2;
            this.barLopSinhVien.Name = "barLopSinhVien";
            this.barLopSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barLopSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLopSinhVien_ItemClick);
            // 
            // barUserSV
            // 
            this.barUserSV.Caption = "Đăng nhập Sinh viên";
            this.barUserSV.Id = 3;
            this.barUserSV.LargeGlyph = global::QuanLySinhVien.Properties.Resources.login__1_;
            this.barUserSV.Name = "barUserSV";
            this.barUserSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barUserSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUserSV_ItemClick);
            // 
            // barSinhVien
            // 
            this.barSinhVien.Caption = "Sinh Viên";
            this.barSinhVien.Glyph = global::QuanLySinhVien.Properties.Resources.graduate_student_avatar;
            this.barSinhVien.Id = 4;
            this.barSinhVien.Name = "barSinhVien";
            this.barSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSinhVien_ItemClick);
            // 
            // barGiangVien
            // 
            this.barGiangVien.Caption = "Giảng Viên";
            this.barGiangVien.Glyph = global::QuanLySinhVien.Properties.Resources.teacher_lecture_in_front_an_auditory;
            this.barGiangVien.Id = 5;
            this.barGiangVien.Name = "barGiangVien";
            this.barGiangVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barGiangVien_ItemClick);
            // 
            // barMonHoc
            // 
            this.barMonHoc.Caption = "Môn học";
            this.barMonHoc.Glyph = global::QuanLySinhVien.Properties.Resources.stack_of_books;
            this.barMonHoc.Id = 6;
            this.barMonHoc.Name = "barMonHoc";
            this.barMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMonHoc_ItemClick);
            // 
            // barBangDiem
            // 
            this.barBangDiem.Caption = "Bảng Điểm";
            this.barBangDiem.Glyph = global::QuanLySinhVien.Properties.Resources.script;
            this.barBangDiem.Id = 7;
            this.barBangDiem.Name = "barBangDiem";
            this.barBangDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBangDiem_ItemClick);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 15;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Glyph = global::QuanLySinhVien.Properties.Resources.DangNhap32x32;
            this.btnLogin.Id = 18;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Glyph = global::QuanLySinhVien.Properties.Resources.icon_password;
            this.btnDoiMatKhau.Id = 21;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Tên đăng nhập:";
            this.barHeaderItem1.Id = 22;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.Id = 23;
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Glyph = global::QuanLySinhVien.Properties.Resources.icon_sign_out;
            this.btnDangXuat.Id = 24;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDanhSachSinhVien
            // 
            this.btnDanhSachSinhVien.Caption = "Sinh Viên";
            this.btnDanhSachSinhVien.Glyph = global::QuanLySinhVien.Properties.Resources.icon_table;
            this.btnDanhSachSinhVien.Id = 25;
            this.btnDanhSachSinhVien.Name = "btnDanhSachSinhVien";
            this.btnDanhSachSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachSinhVien_ItemClick);
            // 
            // btnDangSachDiemTichLuy
            // 
            this.btnDangSachDiemTichLuy.Caption = "Điểm Tích Lũy";
            this.btnDangSachDiemTichLuy.Glyph = global::QuanLySinhVien.Properties.Resources.icon_table;
            this.btnDangSachDiemTichLuy.Id = 26;
            this.btnDangSachDiemTichLuy.Name = "btnDangSachDiemTichLuy";
            this.btnDangSachDiemTichLuy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangSachDiemTichLuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangSachDiemTichLuy_ItemClick);
            // 
            // btnDanhSachMonHoc
            // 
            this.btnDanhSachMonHoc.Caption = "Môn Học";
            this.btnDanhSachMonHoc.Glyph = global::QuanLySinhVien.Properties.Resources.icon_table;
            this.btnDanhSachMonHoc.Id = 27;
            this.btnDanhSachMonHoc.Name = "btnDanhSachMonHoc";
            this.btnDanhSachMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachMonHoc_ItemClick);
            // 
            // btnDanhSachBangDiem
            // 
            this.btnDanhSachBangDiem.Caption = "Bảng Điểm";
            this.btnDanhSachBangDiem.Glyph = global::QuanLySinhVien.Properties.Resources.icon_table;
            this.btnDanhSachBangDiem.Id = 28;
            this.btnDanhSachBangDiem.Name = "btnDanhSachBangDiem";
            this.btnDanhSachBangDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachBangDiem_ItemClick);
            // 
            // barlbTenDangNhap
            // 
            this.barlbTenDangNhap.Id = 29;
            this.barlbTenDangNhap.Name = "barlbTenDangNhap";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnHeThong,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ Thống";
            // 
            // rbnHeThong
            // 
            this.rbnHeThong.ItemLinks.Add(this.btnLogin);
            this.rbnHeThong.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbnHeThong.ItemLinks.Add(this.btnDangXuat);
            this.rbnHeThong.Name = "rbnHeThong";
            this.rbnHeThong.Text = "Hệ thống tài khoản";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Giao Diện";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnDanhSach});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Danh Sách";
            // 
            // rbnDanhSach
            // 
            this.rbnDanhSach.ItemLinks.Add(this.btnDanhSachSinhVien);
            this.rbnDanhSach.ItemLinks.Add(this.btnDangSachDiemTichLuy);
            this.rbnDanhSach.ItemLinks.Add(this.btnDanhSachMonHoc);
            this.rbnDanhSach.ItemLinks.Add(this.btnDanhSachBangDiem);
            this.rbnDanhSach.Name = "rbnDanhSach";
            this.rbnDanhSach.Text = "Danh Sách";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnQuanLyThongTin});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Quản Lý Thông Tin";
            // 
            // rbnQuanLyThongTin
            // 
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barSinhVien);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barGiangVien);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barMonHoc);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barBangDiem);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barLopSinhVien);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barKhoaNganh);
            this.rbnQuanLyThongTin.ItemLinks.Add(this.barUserSV);
            this.rbnQuanLyThongTin.Name = "rbnQuanLyThongTin";
            this.rbnQuanLyThongTin.Text = "Quản Lý Thông Tin Chi Tiết";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barlbTenDangNhap);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 287);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(828, 31);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 318);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnHeThong;
        private DevExpress.XtraBars.BarButtonItem barKhoaNganh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnQuanLyThongTin;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barLopSinhVien;
        private DevExpress.XtraBars.BarButtonItem barUserSV;
        private DevExpress.XtraBars.BarButtonItem barSinhVien;
        private DevExpress.XtraBars.BarButtonItem barGiangVien;
        private DevExpress.XtraBars.BarButtonItem barMonHoc;
        private DevExpress.XtraBars.BarButtonItem barBangDiem;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem lbTenDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnDangSachDiemTichLuy;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachBangDiem;
        private DevExpress.XtraBars.BarHeaderItem barlbTenDangNhap;
    }
}

