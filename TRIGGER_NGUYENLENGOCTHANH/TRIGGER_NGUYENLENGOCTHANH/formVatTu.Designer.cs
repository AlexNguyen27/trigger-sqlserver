namespace TRIGGER_NGUYENLENGOCTHANH
{
    partial class formVatTu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPhieuXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.vATTUGridControl = new DevExpress.XtraGrid.GridControl();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_QLVT = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVT();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vATTUTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.VATTUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPhieuXuat);
            this.panelControl1.Controls.Add(this.btnPhieuNhap);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(648, 66);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Location = new System.Drawing.Point(428, 22);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(75, 23);
            this.btnPhieuXuat.TabIndex = 2;
            this.btnPhieuXuat.Text = "Phiếu Xuất";
            this.btnPhieuXuat.Click += new System.EventHandler(this.BtnPhieuXuat_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Location = new System.Drawing.Point(296, 22);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnPhieuNhap.TabIndex = 1;
            this.btnPhieuNhap.Text = "Phiếu Nhập";
            this.btnPhieuNhap.Click += new System.EventHandler(this.BtnPhieuNhap_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(165, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.vATTUGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 66);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(648, 311);
            this.panelControl2.TabIndex = 1;
            // 
            // vATTUGridControl
            // 
            this.vATTUGridControl.DataSource = this.vATTUBindingSource;
            this.vATTUGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vATTUGridControl.Location = new System.Drawing.Point(2, 2);
            this.vATTUGridControl.MainView = this.gridView1;
            this.vATTUGridControl.Name = "vATTUGridControl";
            this.vATTUGridControl.Size = new System.Drawing.Size(644, 307);
            this.vATTUGridControl.TabIndex = 0;
            this.vATTUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.ds_QLVT;
            // 
            // ds_QLVT
            // 
            this.ds_QLVT.DataSetName = "ds_QLVT";
            this.ds_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.vATTUGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MAVT
            // 
            this.MAVT.Caption = "Mã VT";
            this.MAVT.FieldName = "MAVT";
            this.MAVT.Name = "MAVT";
            this.MAVT.Visible = true;
            this.MAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // formVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 377);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "formVatTu";
            this.Text = "Vật Tư";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vATTUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private ds_QLVT ds_QLVT;
        private DevExpress.XtraGrid.GridControl vATTUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnPhieuXuat;
        private DevExpress.XtraEditors.SimpleButton btnPhieuNhap;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_QLVTTableAdapters.VATTUTableAdapter vATTUTableAdapter;
    }
}