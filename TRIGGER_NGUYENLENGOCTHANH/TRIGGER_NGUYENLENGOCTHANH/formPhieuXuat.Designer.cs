﻿namespace TRIGGER_NGUYENLENGOCTHANH
{
    partial class formPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pHIEUXUATGridControl = new DevExpress.XtraGrid.GridControl();
            this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_QLVT = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVT();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThemPX = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiPX = new DevExpress.XtraEditors.SimpleButton();
            this.maVT = new System.Windows.Forms.ComboBox();
            this.fKCTPXPHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAPX = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pHIEUXUATTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.PHIEUXUATTableAdapter();
            this.tableAdapterManager = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.CTPXTableAdapter();
            this.vATTUTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.VATTUTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(42, 55);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(40, 13);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã PX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(42, 81);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(42, 107);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(56, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng: ";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(42, 133);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pHIEUXUATGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(645, 211);
            this.panelControl1.TabIndex = 0;
            // 
            // pHIEUXUATGridControl
            // 
            this.pHIEUXUATGridControl.DataSource = this.pHIEUXUATBindingSource;
            this.pHIEUXUATGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHIEUXUATGridControl.Location = new System.Drawing.Point(2, 2);
            this.pHIEUXUATGridControl.MainView = this.gridView1;
            this.pHIEUXUATGridControl.Name = "pHIEUXUATGridControl";
            this.pHIEUXUATGridControl.Size = new System.Drawing.Size(641, 207);
            this.pHIEUXUATGridControl.TabIndex = 0;
            this.pHIEUXUATGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pHIEUXUATBindingSource
            // 
            this.pHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
            this.pHIEUXUATBindingSource.DataSource = this.ds_QLVT;
            // 
            // ds_QLVT
            // 
            this.ds_QLVT.DataSetName = "ds_QLVT";
            this.ds_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colHOTENKH,
            this.colMANV});
            this.gridView1.GridControl = this.pHIEUXUATGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã PX";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên KH";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 1;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThemPX);
            this.panelControl2.Controls.Add(this.btnGhiPX);
            this.panelControl2.Controls.Add(this.maVT);
            this.panelControl2.Controls.Add(mAPXLabel);
            this.panelControl2.Controls.Add(this.txtMAPX);
            this.panelControl2.Controls.Add(mAVTLabel);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.txtSL);
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.txtDonGia);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 211);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(264, 192);
            this.panelControl2.TabIndex = 1;
            // 
            // btnThemPX
            // 
            this.btnThemPX.Location = new System.Drawing.Point(23, 6);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(75, 23);
            this.btnThemPX.TabIndex = 3;
            this.btnThemPX.Text = "Thêm PX";
            this.btnThemPX.Click += new System.EventHandler(this.BtnThemPX_Click);
            // 
            // btnGhiPX
            // 
            this.btnGhiPX.Location = new System.Drawing.Point(158, 6);
            this.btnGhiPX.Name = "btnGhiPX";
            this.btnGhiPX.Size = new System.Drawing.Size(75, 23);
            this.btnGhiPX.TabIndex = 9;
            this.btnGhiPX.Text = "Ghi PX";
            this.btnGhiPX.Click += new System.EventHandler(this.BtnGhiPX_Click);
            // 
            // maVT
            // 
            this.maVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCTPXPHIEUXUATBindingSource, "MAVT", true));
            this.maVT.DataSource = this.vATTUBindingSource;
            this.maVT.DisplayMember = "MAVT";
            this.maVT.FormattingEnabled = true;
            this.maVT.Location = new System.Drawing.Point(107, 77);
            this.maVT.Name = "maVT";
            this.maVT.Size = new System.Drawing.Size(100, 21);
            this.maVT.TabIndex = 8;
            this.maVT.ValueMember = "MAVT";
            // 
            // fKCTPXPHIEUXUATBindingSource
            // 
            this.fKCTPXPHIEUXUATBindingSource.DataMember = "FK_CTPX_PHIEUXUAT";
            this.fKCTPXPHIEUXUATBindingSource.DataSource = this.pHIEUXUATBindingSource;
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.ds_QLVT;
            // 
            // txtMAPX
            // 
            this.txtMAPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKCTPXPHIEUXUATBindingSource, "MAPX", true));
            this.txtMAPX.Location = new System.Drawing.Point(107, 52);
            this.txtMAPX.Name = "txtMAPX";
            this.txtMAPX.Properties.ReadOnly = true;
            this.txtMAPX.Size = new System.Drawing.Size(100, 20);
            this.txtMAPX.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKCTPXPHIEUXUATBindingSource, "SOLUONG", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(107, 104);
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKCTPXPHIEUXUATBindingSource, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(107, 130);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(264, 211);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(381, 192);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.fKCTPXPHIEUXUATBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(377, 188);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 92);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 22);
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(121, 22);
            this.btnGhi.Text = "GHI";
            this.btnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 22);
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 22);
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.ReadOnly = true;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // pHIEUXUATTableAdapter
            // 
            this.pHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = this.pHIEUXUATTableAdapter;
            this.tableAdapterManager.UpdateOrder = TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // formPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 403);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "formPhieuXuat";
            this.Text = "Phiếu Xuất";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private ds_QLVT ds_QLVT;
        private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
        private ds_QLVTTableAdapters.PHIEUXUATTableAdapter pHIEUXUATTableAdapter;
        private ds_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl pHIEUXUATGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private ds_QLVTTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource fKCTPXPHIEUXUATBindingSource;
        private DevExpress.XtraEditors.TextEdit txtMAPX;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnGhi;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox maVT;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_QLVTTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThemPX;
        private DevExpress.XtraEditors.SimpleButton btnGhiPX;
    }
}