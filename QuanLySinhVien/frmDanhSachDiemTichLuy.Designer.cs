namespace QuanLySinhVien
{
    partial class frmDanhSachDiemTichLuy
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
            this.spinHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.btnResetText = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTenSV = new System.Windows.Forms.ComboBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.reportDiemTichLuy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DanhSachMonHocTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
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
            this.dockPanel1.ID = new System.Guid("9d4b2779-31c5-4e51-9fab-9c295aa03c86");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 188);
            this.dockPanel1.Size = new System.Drawing.Size(896, 188);
            this.dockPanel1.Text = "Thống kê";
            this.dockPanel1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dockPanel1_KeyDown);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.spinHocKy);
            this.dockPanel1_Container.Controls.Add(this.btnResetText);
            this.dockPanel1_Container.Controls.Add(this.cmbTenSV);
            this.dockPanel1_Container.Controls.Add(this.cmbMaSV);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.btnThongKe);
            this.dockPanel1_Container.Controls.Add(this.cmbNamHoc);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(888, 161);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // spinHocKy
            // 
            this.spinHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHocKy.Location = new System.Drawing.Point(407, 29);
            this.spinHocKy.Name = "spinHocKy";
            this.spinHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinHocKy.Size = new System.Drawing.Size(180, 20);
            this.spinHocKy.TabIndex = 17;
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(683, 84);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(122, 23);
            this.btnResetText.TabIndex = 16;
            this.btnResetText.Text = "Reset";
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // cmbTenSV
            // 
            this.cmbTenSV.DataSource = this.sinhVienBindingSource;
            this.cmbTenSV.DisplayMember = "TenSV";
            this.cmbTenSV.FormattingEnabled = true;
            this.cmbTenSV.Location = new System.Drawing.Point(147, 56);
            this.cmbTenSV.Name = "cmbTenSV";
            this.cmbTenSV.Size = new System.Drawing.Size(178, 21);
            this.cmbTenSV.TabIndex = 14;
            this.cmbTenSV.ValueMember = "TenSV";
            this.cmbTenSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dockPanel1_KeyDown);
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sinhVienBindingSource;
            this.cmbMaSV.DisplayMember = "MaSV";
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(147, 29);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(178, 21);
            this.cmbMaSV.TabIndex = 15;
            this.cmbMaSV.ValueMember = "MaSV";
            this.cmbMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dockPanel1_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(74, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Tên sinh viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(353, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Năm học";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(74, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Mã sinh viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(353, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Học Kỳ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(683, 113);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 23);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DataSource = this.DanhSachMonHocBindingSource;
            this.cmbNamHoc.DisplayMember = "KhoaHoc";
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(407, 56);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(180, 21);
            this.cmbNamHoc.TabIndex = 8;
            this.cmbNamHoc.ValueMember = "KhoaHoc";
            this.cmbNamHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dockPanel1_KeyDown);
            // 
            // reportDiemTichLuy
            // 
            this.reportDiemTichLuy.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DanhSachMonHocBindingSource;
            this.reportDiemTichLuy.LocalReport.DataSources.Add(reportDataSource2);
            this.reportDiemTichLuy.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.DanhSachDiemTichLuy.rdlc";
            this.reportDiemTichLuy.Location = new System.Drawing.Point(0, 188);
            this.reportDiemTichLuy.Name = "reportDiemTichLuy";
            this.reportDiemTichLuy.Size = new System.Drawing.Size(896, 258);
            this.reportDiemTichLuy.TabIndex = 1;
            // 
            // DanhSachMonHocTableAdapter
            // 
            this.DanhSachMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachDiemTichLuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 446);
            this.Controls.Add(this.reportDiemTichLuy);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmDanhSachDiemTichLuy";
            this.Text = "Danh Sách Điểm Tích Lũy";
            this.Load += new System.EventHandler(this.frmDanhSachDiemTichLuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private Microsoft.Reporting.WinForms.ReportViewer reportDiemTichLuy;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.BindingSource DanhSachMonHocBindingSource;
        private DanhSachSinhVienDataSet DanhSachSinhVienDataSet;
        private DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter DanhSachMonHocTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnResetText;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.ComboBox cmbTenSV;
        private DevExpress.XtraEditors.SpinEdit spinHocKy;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
    }
}