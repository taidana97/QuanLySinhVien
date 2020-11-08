namespace QuanLySinhVien
{
    partial class frmDanhSachMonHoc
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.spinHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnResetText = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.reportDanhSachMonHoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DanhSachSinhVienDataSet = new QuanLySinhVien.DanhSachSinhVienDataSet();
            this.DanhSachMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanhSachMonHocTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.MonHocTableAdapter();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new QuanLySinhVien.DanhSachSinhVienDataSetTableAdapters.GiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dockPanel1.ID = new System.Guid("28b628f7-118e-4bdc-8bd4-5f3e21b2cf89");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(845, 200);
            this.dockPanel1.Text = "Thống kê";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.spinHocKy);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.btnResetText);
            this.dockPanel1_Container.Controls.Add(this.cmbNamHoc);
            this.dockPanel1_Container.Controls.Add(this.cmbTenGV);
            this.dockPanel1_Container.Controls.Add(this.btnThongKe);
            this.dockPanel1_Container.Controls.Add(this.cmbTenMH);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(837, 173);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // spinHocKy
            // 
            this.spinHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHocKy.Location = new System.Drawing.Point(356, 38);
            this.spinHocKy.Name = "spinHocKy";
            this.spinHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinHocKy.Size = new System.Drawing.Size(180, 20);
            this.spinHocKy.TabIndex = 27;
            this.spinHocKy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTenMH_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(302, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Học Kỳ";
            // 
            // btnResetText
            // 
            this.btnResetText.Location = new System.Drawing.Point(632, 93);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(122, 23);
            this.btnResetText.TabIndex = 26;
            this.btnResetText.Text = "Reset";
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DataSource = this.DanhSachMonHocBindingSource;
            this.cmbNamHoc.DisplayMember = "KhoaHoc";
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(356, 65);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(180, 21);
            this.cmbNamHoc.TabIndex = 18;
            this.cmbNamHoc.ValueMember = "KhoaHoc";
            this.cmbNamHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTenMH_KeyDown);
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.DataSource = this.giangVienBindingSource;
            this.cmbTenGV.DisplayMember = "TenGV";
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(96, 65);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(178, 21);
            this.cmbTenGV.TabIndex = 24;
            this.cmbTenGV.ValueMember = "TenGV";
            this.cmbTenGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTenMH_KeyDown);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(632, 122);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 23);
            this.btnThongKe.TabIndex = 19;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.monHocBindingSource;
            this.cmbTenMH.DisplayMember = "TenMH";
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(96, 38);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(178, 21);
            this.cmbTenMH.TabIndex = 25;
            this.cmbTenMH.ValueMember = "TenMH";
            this.cmbTenMH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTenMH_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Tên môn học";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Tên giảng viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(302, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Năm học";
            // 
            // reportDanhSachMonHoc
            // 
            this.reportDanhSachMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DanhSachMonHocBindingSource;
            this.reportDanhSachMonHoc.LocalReport.DataSources.Add(reportDataSource3);
            this.reportDanhSachMonHoc.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.DanhSachMonHoc.rdlc";
            this.reportDanhSachMonHoc.Location = new System.Drawing.Point(0, 200);
            this.reportDanhSachMonHoc.Name = "reportDanhSachMonHoc";
            this.reportDanhSachMonHoc.Size = new System.Drawing.Size(845, 265);
            this.reportDanhSachMonHoc.TabIndex = 1;
            // 
            // DanhSachSinhVienDataSet
            // 
            this.DanhSachSinhVienDataSet.DataSetName = "DanhSachSinhVienDataSet";
            this.DanhSachSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DanhSachMonHocBindingSource
            // 
            this.DanhSachMonHocBindingSource.DataMember = "DanhSachMonHoc";
            this.DanhSachMonHocBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // DanhSachMonHocTableAdapter
            // 
            this.DanhSachMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.DanhSachSinhVienDataSet;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 465);
            this.Controls.Add(this.reportDanhSachMonHoc);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmDanhSachMonHoc";
            this.Text = "Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.frmDanhSachMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private Microsoft.Reporting.WinForms.ReportViewer reportDanhSachMonHoc;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SpinEdit spinHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnResetText;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.ComboBox cmbTenGV;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource DanhSachMonHocBindingSource;
        private DanhSachSinhVienDataSet DanhSachSinhVienDataSet;
        private DanhSachSinhVienDataSetTableAdapters.DanhSachMonHocTableAdapter DanhSachMonHocTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private DanhSachSinhVienDataSetTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
    }
}