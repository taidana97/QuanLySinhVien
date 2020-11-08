namespace QuanLySinhVien
{
    partial class frmDanhSachBangDiem
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DanhSachMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanhSachSinhVienDataSet = new QuanLySinhVien.DanhSachSinhVienDataSet();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.txtDiemKTNho = new System.Windows.Forms.TextBox();
            this.txtDiemTKNho = new System.Windows.Forms.TextBox();
            this.txtDiemQTNho = new System.Windows.Forms.TextBox();
            this.txtDiemL2Nho = new System.Windows.Forms.TextBox();
            this.txtDiemL1Nho = new System.Windows.Forms.TextBox();
            this.txtDiemKTLon = new System.Windows.Forms.TextBox();
            this.txtDiemTKLon = new System.Windows.Forms.TextBox();
            this.txtDiemQTLon = new System.Windows.Forms.TextBox();
            this.txtDiemL2Lon = new System.Windows.Forms.TextBox();
            this.txtDiemL1Lon = new System.Windows.Forms.TextBox();
            this.cmbTenSV = new System.Windows.Forms.ComboBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spinHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnResetText = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.reportDanhSachBangDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DanhSachMonHocTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter();
            this.sinhVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.monHocTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.MonHocTableAdapter();
            this.giangVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.GiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachMonHocBindingSource
            // 
            this.DanhSachMonHocBindingSource.DataMember = "DanhSachMonHoc";
            this.DanhSachMonHocBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // DanhSachSinhVienDataSet
            // 
            this.DanhSachSinhVienDataSet.DataSetName = "DanhSachSinhVienDataSet";
            this.DanhSachSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("82c7bf27-77fa-4b80-aba5-d7cc333cc801");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 184);
            this.dockPanel1.Size = new System.Drawing.Size(861, 184);
            this.dockPanel1.Text = "Thống kê";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.txtDiemKTNho);
            this.dockPanel1_Container.Controls.Add(this.txtDiemTKNho);
            this.dockPanel1_Container.Controls.Add(this.txtDiemQTNho);
            this.dockPanel1_Container.Controls.Add(this.txtDiemL2Nho);
            this.dockPanel1_Container.Controls.Add(this.txtDiemL1Nho);
            this.dockPanel1_Container.Controls.Add(this.txtDiemKTLon);
            this.dockPanel1_Container.Controls.Add(this.txtDiemTKLon);
            this.dockPanel1_Container.Controls.Add(this.txtDiemQTLon);
            this.dockPanel1_Container.Controls.Add(this.txtDiemL2Lon);
            this.dockPanel1_Container.Controls.Add(this.txtDiemL1Lon);
            this.dockPanel1_Container.Controls.Add(this.cmbTenSV);
            this.dockPanel1_Container.Controls.Add(this.spinHocKy);
            this.dockPanel1_Container.Controls.Add(this.cmbMaSV);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.labelControl10);
            this.dockPanel1_Container.Controls.Add(this.labelControl11);
            this.dockPanel1_Container.Controls.Add(this.labelControl9);
            this.dockPanel1_Container.Controls.Add(this.labelControl8);
            this.dockPanel1_Container.Controls.Add(this.labelControl7);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl6);
            this.dockPanel1_Container.Controls.Add(this.btnResetText);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.cmbNamHoc);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.cmbTenGV);
            this.dockPanel1_Container.Controls.Add(this.cmbTenMH);
            this.dockPanel1_Container.Controls.Add(this.btnThongKe);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(853, 157);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // txtDiemKTNho
            // 
            this.txtDiemKTNho.Location = new System.Drawing.Point(454, 96);
            this.txtDiemKTNho.Name = "txtDiemKTNho";
            this.txtDiemKTNho.Size = new System.Drawing.Size(84, 21);
            this.txtDiemKTNho.TabIndex = 38;
            this.txtDiemKTNho.Text = "10";
            // 
            // txtDiemTKNho
            // 
            this.txtDiemTKNho.Location = new System.Drawing.Point(710, 66);
            this.txtDiemTKNho.Name = "txtDiemTKNho";
            this.txtDiemTKNho.Size = new System.Drawing.Size(84, 21);
            this.txtDiemTKNho.TabIndex = 38;
            this.txtDiemTKNho.Text = "10";
            // 
            // txtDiemQTNho
            // 
            this.txtDiemQTNho.Location = new System.Drawing.Point(454, 66);
            this.txtDiemQTNho.Name = "txtDiemQTNho";
            this.txtDiemQTNho.Size = new System.Drawing.Size(84, 21);
            this.txtDiemQTNho.TabIndex = 38;
            this.txtDiemQTNho.Text = "10";
            // 
            // txtDiemL2Nho
            // 
            this.txtDiemL2Nho.Location = new System.Drawing.Point(184, 96);
            this.txtDiemL2Nho.Name = "txtDiemL2Nho";
            this.txtDiemL2Nho.Size = new System.Drawing.Size(84, 21);
            this.txtDiemL2Nho.TabIndex = 38;
            this.txtDiemL2Nho.Text = "10";
            // 
            // txtDiemL1Nho
            // 
            this.txtDiemL1Nho.Location = new System.Drawing.Point(184, 66);
            this.txtDiemL1Nho.Name = "txtDiemL1Nho";
            this.txtDiemL1Nho.Size = new System.Drawing.Size(84, 21);
            this.txtDiemL1Nho.TabIndex = 38;
            this.txtDiemL1Nho.Text = "10";
            // 
            // txtDiemKTLon
            // 
            this.txtDiemKTLon.Location = new System.Drawing.Point(360, 96);
            this.txtDiemKTLon.Name = "txtDiemKTLon";
            this.txtDiemKTLon.Size = new System.Drawing.Size(84, 21);
            this.txtDiemKTLon.TabIndex = 38;
            this.txtDiemKTLon.Text = "0";
            // 
            // txtDiemTKLon
            // 
            this.txtDiemTKLon.Location = new System.Drawing.Point(611, 66);
            this.txtDiemTKLon.Name = "txtDiemTKLon";
            this.txtDiemTKLon.Size = new System.Drawing.Size(84, 21);
            this.txtDiemTKLon.TabIndex = 38;
            this.txtDiemTKLon.Text = "0";
            // 
            // txtDiemQTLon
            // 
            this.txtDiemQTLon.Location = new System.Drawing.Point(360, 66);
            this.txtDiemQTLon.Name = "txtDiemQTLon";
            this.txtDiemQTLon.Size = new System.Drawing.Size(84, 21);
            this.txtDiemQTLon.TabIndex = 38;
            this.txtDiemQTLon.Text = "0";
            // 
            // txtDiemL2Lon
            // 
            this.txtDiemL2Lon.Location = new System.Drawing.Point(90, 96);
            this.txtDiemL2Lon.Name = "txtDiemL2Lon";
            this.txtDiemL2Lon.Size = new System.Drawing.Size(84, 21);
            this.txtDiemL2Lon.TabIndex = 38;
            this.txtDiemL2Lon.Text = "0";
            // 
            // txtDiemL1Lon
            // 
            this.txtDiemL1Lon.Location = new System.Drawing.Point(90, 66);
            this.txtDiemL1Lon.Name = "txtDiemL1Lon";
            this.txtDiemL1Lon.Size = new System.Drawing.Size(84, 21);
            this.txtDiemL1Lon.TabIndex = 38;
            this.txtDiemL1Lon.Text = "0";
            // 
            // cmbTenSV
            // 
            this.cmbTenSV.DataSource = this.sinhVienBindingSource;
            this.cmbTenSV.DisplayMember = "TenSV";
            this.cmbTenSV.FormattingEnabled = true;
            this.cmbTenSV.Location = new System.Drawing.Point(90, 39);
            this.cmbTenSV.Name = "cmbTenSV";
            this.cmbTenSV.Size = new System.Drawing.Size(178, 21);
            this.cmbTenSV.TabIndex = 18;
            this.cmbTenSV.ValueMember = "TenSV";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // spinHocKy
            // 
            this.spinHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHocKy.Location = new System.Drawing.Point(611, 11);
            this.spinHocKy.Name = "spinHocKy";
            this.spinHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinHocKy.Size = new System.Drawing.Size(183, 20);
            this.spinHocKy.TabIndex = 37;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sinhVienBindingSource;
            this.cmbMaSV.DisplayMember = "MaSV";
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(90, 12);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(178, 21);
            this.cmbMaSV.TabIndex = 19;
            this.cmbMaSV.ValueMember = "MaSV";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(557, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Học Kỳ";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(287, 104);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Điểm KT";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(557, 74);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(39, 13);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Điểm TK";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(287, 74);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Điểm QT";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 104);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Điểm L2";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Điểm L1";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Tên sinh viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(557, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Năm học";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Mã sinh viên";
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(710, 99);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(122, 23);
            this.btnResetText.TabIndex = 36;
            this.btnResetText.Text = "Reset";
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(287, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Tên giảng viên";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DataSource = this.DanhSachMonHocBindingSource;
            this.cmbNamHoc.DisplayMember = "KhoaHoc";
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(611, 38);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(183, 21);
            this.cmbNamHoc.TabIndex = 28;
            this.cmbNamHoc.ValueMember = "KhoaHoc";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(287, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Tên môn học";
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.DataSource = this.giangVienBindingSource;
            this.cmbTenGV.DisplayMember = "TenGV";
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(360, 38);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(178, 21);
            this.cmbTenGV.TabIndex = 34;
            this.cmbTenGV.ValueMember = "TenGV";
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.monHocBindingSource;
            this.cmbTenMH.DisplayMember = "TenMH";
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(360, 11);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(178, 21);
            this.cmbTenMH.TabIndex = 35;
            this.cmbTenMH.ValueMember = "TenMH";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(710, 127);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 23);
            this.btnThongKe.TabIndex = 29;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // reportDanhSachBangDiem
            // 
            this.reportDanhSachBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DanhSachMonHocBindingSource;
            this.reportDanhSachBangDiem.LocalReport.DataSources.Add(reportDataSource2);
            this.reportDanhSachBangDiem.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.DanhSachBangDiem.rdlc";
            this.reportDanhSachBangDiem.Location = new System.Drawing.Point(0, 184);
            this.reportDanhSachBangDiem.Name = "reportDanhSachBangDiem";
            this.reportDanhSachBangDiem.Size = new System.Drawing.Size(861, 191);
            this.reportDanhSachBangDiem.TabIndex = 1;
            // 
            // DanhSachMonHocTableAdapter
            // 
            this.DanhSachMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 375);
            this.Controls.Add(this.reportDanhSachBangDiem);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmDanhSachBangDiem";
            this.Text = "Danh Sách Bảng Điểm";
            this.Load += new System.EventHandler(this.frmDanhSachBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private Microsoft.Reporting.WinForms.ReportViewer reportDanhSachBangDiem;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.BindingSource DanhSachMonHocBindingSource;
        private DanhSachSinhVienDataSet DanhSachSinhVienDataSet;
        private DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter DanhSachMonHocTableAdapter;
        private DevExpress.XtraEditors.SpinEdit spinHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnResetText;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbTenGV;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.ComboBox cmbTenSV;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.TextBox txtDiemL1Nho;
        private System.Windows.Forms.TextBox txtDiemL1Lon;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtDiemKTNho;
        private System.Windows.Forms.TextBox txtDiemTKNho;
        private System.Windows.Forms.TextBox txtDiemQTNho;
        private System.Windows.Forms.TextBox txtDiemL2Nho;
        private System.Windows.Forms.TextBox txtDiemKTLon;
        private System.Windows.Forms.TextBox txtDiemTKLon;
        private System.Windows.Forms.TextBox txtDiemQTLon;
        private System.Windows.Forms.TextBox txtDiemL2Lon;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}