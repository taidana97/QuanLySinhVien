namespace QuanLySinhVien
{
    partial class frmDanhSachSinhVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DanhSachSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanhSachSinhVienDataSet = new QuanLySinhVien.DanhSachSinhVienDataSet();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockLocDSSV = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.btnResetText = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTenSV = new System.Windows.Forms.ComboBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.khoaNganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhSachSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lopSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDSSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DanhSachSinhVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.DanhSachSinhVienTableAdapter();
            this.khoaNganhTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.KhoaNganhTableAdapter();
            this.lopSinhVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.LopSinhVienTableAdapter();
            this.sinhVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockLocDSSV.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaNganhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopSinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachSinhVienBindingSource
            // 
            this.DanhSachSinhVienBindingSource.DataMember = "DanhSachSinhVien";
            this.DanhSachSinhVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
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
            this.dockLocDSSV});
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
            // dockLocDSSV
            // 
            this.dockLocDSSV.Controls.Add(this.dockPanel1_Container);
            this.dockLocDSSV.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockLocDSSV.ID = new System.Guid("c8e42396-46ba-4e6f-8c8f-7868e5563a73");
            this.dockLocDSSV.Location = new System.Drawing.Point(0, 0);
            this.dockLocDSSV.Name = "dockLocDSSV";
            this.dockLocDSSV.OriginalSize = new System.Drawing.Size(200, 157);
            this.dockLocDSSV.Size = new System.Drawing.Size(779, 157);
            this.dockLocDSSV.Text = "Thống kê";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.btnResetText);
            this.dockPanel1_Container.Controls.Add(this.cmbTenSV);
            this.dockPanel1_Container.Controls.Add(this.cmbMaSV);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.btnThongKe);
            this.dockPanel1_Container.Controls.Add(this.cmbKhoa);
            this.dockPanel1_Container.Controls.Add(this.cmbLop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(771, 130);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(613, 61);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(122, 23);
            this.btnResetText.TabIndex = 6;
            this.btnResetText.Text = "Reset";
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // cmbTenSV
            // 
            this.cmbTenSV.DataSource = this.sinhVienBindingSource;
            this.cmbTenSV.DisplayMember = "TenSV";
            this.cmbTenSV.FormattingEnabled = true;
            this.cmbTenSV.Location = new System.Drawing.Point(87, 41);
            this.cmbTenSV.Name = "cmbTenSV";
            this.cmbTenSV.Size = new System.Drawing.Size(178, 21);
            this.cmbTenSV.TabIndex = 4;
            this.cmbTenSV.ValueMember = "TenSV";
            this.cmbTenSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLop_KeyDown);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sinhVienBindingSource;
            this.cmbMaSV.DisplayMember = "MaSV";
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(87, 14);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(178, 21);
            this.cmbMaSV.TabIndex = 4;
            this.cmbMaSV.ValueMember = "MaSV";
            this.cmbMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLop_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tên sinh viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(293, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên khoa:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mã sinh viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(293, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên lớp:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(613, 90);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.khoaNganhBindingSource;
            this.cmbKhoa.DisplayMember = "TenKhoa";
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(347, 41);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(180, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.ValueMember = "TenKhoa";
            this.cmbKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLop_KeyDown);
            // 
            // khoaNganhBindingSource
            // 
            this.khoaNganhBindingSource.DataMember = "KhoaNganh";
            this.khoaNganhBindingSource.DataSource = this.danhSachSinhVienDataSetBindingSource;
            // 
            // danhSachSinhVienDataSetBindingSource
            // 
            this.danhSachSinhVienDataSetBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            this.danhSachSinhVienDataSetBindingSource.Position = 0;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lopSinhVienBindingSource;
            this.cmbLop.DisplayMember = "TenLop";
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(347, 14);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(178, 21);
            this.cmbLop.TabIndex = 0;
            this.cmbLop.ValueMember = "TenLop";
            this.cmbLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLop_KeyDown);
            // 
            // lopSinhVienBindingSource
            // 
            this.lopSinhVienBindingSource.DataMember = "LopSinhVien";
            this.lopSinhVienBindingSource.DataSource = this.danhSachSinhVienDataSetBindingSource;
            // 
            // reportDSSV
            // 
            this.reportDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DanhSachSinhVienBindingSource;
            this.reportDSSV.LocalReport.DataSources.Add(reportDataSource1);
            this.reportDSSV.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.DanhSachSinhVien.rdlc";
            this.reportDSSV.Location = new System.Drawing.Point(0, 157);
            this.reportDSSV.Name = "reportDSSV";
            this.reportDSSV.Size = new System.Drawing.Size(779, 176);
            this.reportDSSV.TabIndex = 1;
            // 
            // DanhSachSinhVienTableAdapter
            // 
            this.DanhSachSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // khoaNganhTableAdapter
            // 
            this.khoaNganhTableAdapter.ClearBeforeFill = true;
            // 
            // lopSinhVienTableAdapter
            // 
            this.lopSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 333);
            this.Controls.Add(this.reportDSSV);
            this.Controls.Add(this.dockLocDSSV);
            this.Name = "frmDanhSachSinhVien";
            this.Text = "Dánh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.frmDanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockLocDSSV.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaNganhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopSinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockLocDSSV;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private Microsoft.Reporting.WinForms.ReportViewer reportDSSV;
        private System.Windows.Forms.BindingSource DanhSachSinhVienBindingSource;
        private DanhSachSinhVienDataSet DanhSachSinhVienDataSet;
        private DanhSachSinhVienDataSetTableAdapters.DanhSachSinhVienTableAdapter DanhSachSinhVienTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.BindingSource danhSachSinhVienDataSetBindingSource;
        private System.Windows.Forms.BindingSource khoaNganhBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.KhoaNganhTableAdapter khoaNganhTableAdapter;
        private System.Windows.Forms.BindingSource lopSinhVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.LopSinhVienTableAdapter lopSinhVienTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenSV;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnResetText;
    }
}