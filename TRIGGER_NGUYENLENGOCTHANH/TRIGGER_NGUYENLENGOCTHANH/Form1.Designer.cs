namespace TRIGGER_NGUYENLENGOCTHANH
{
    partial class Form1
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ds_QLVT = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVT();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.PHIEUNHAPTableAdapter();
            this.tableAdapterManager = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.TableAdapterManager();
            this.pHIEUNHAPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.CTPNTableAdapter();
            this.cTPNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sOLUONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            mAPNLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pHIEUNHAPDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 204);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cTPNDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(250, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 177);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(mAPNLabel);
            this.panel3.Controls.Add(this.mAPNTextEdit);
            this.panel3.Controls.Add(mAVTLabel);
            this.panel3.Controls.Add(this.mAVTTextEdit);
            this.panel3.Controls.Add(sOLUONGLabel);
            this.panel3.Controls.Add(this.sOLUONGSpinEdit);
            this.panel3.Controls.Add(dONGIALabel);
            this.panel3.Controls.Add(this.dONGIASpinEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 177);
            this.panel3.TabIndex = 2;
            // 
            // ds_QLVT
            // 
            this.ds_QLVT.DataSetName = "ds_QLVT";
            this.ds_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.ds_QLVT;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = this.pHIEUNHAPTableAdapter;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRIGGER_NGUYENLENGOCTHANH.ds_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // pHIEUNHAPDataGridView
            // 
            this.pHIEUNHAPDataGridView.AutoGenerateColumns = false;
            this.pHIEUNHAPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHIEUNHAPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pHIEUNHAPDataGridView.DataSource = this.pHIEUNHAPBindingSource;
            this.pHIEUNHAPDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHIEUNHAPDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pHIEUNHAPDataGridView.Name = "pHIEUNHAPDataGridView";
            this.pHIEUNHAPDataGridView.Size = new System.Drawing.Size(667, 204);
            this.pHIEUNHAPDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MASODDH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MASODDH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn4.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKHO";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAKHO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PHIEUNHAP";
            this.bdsCTPN.DataSource = this.pHIEUNHAPBindingSource;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNDataGridView
            // 
            this.cTPNDataGridView.AutoGenerateColumns = false;
            this.cTPNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTPNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cTPNDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.cTPNDataGridView.DataSource = this.bdsCTPN;
            this.cTPNDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cTPNDataGridView.Name = "cTPNDataGridView";
            this.cTPNDataGridView.Size = new System.Drawing.Size(417, 177);
            this.cTPNDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn6.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn7.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn8.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn9.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(36, 33);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // mAPNTextEdit
            // 
            this.mAPNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAPN", true));
            this.mAPNTextEdit.Location = new System.Drawing.Point(105, 30);
            this.mAPNTextEdit.Name = "mAPNTextEdit";
            this.mAPNTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAPNTextEdit.TabIndex = 1;
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(36, 59);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAVT", true));
            this.mAVTTextEdit.Location = new System.Drawing.Point(105, 56);
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAVTTextEdit.TabIndex = 3;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(36, 85);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // sOLUONGSpinEdit
            // 
            this.sOLUONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "SOLUONG", true));
            this.sOLUONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGSpinEdit.Location = new System.Drawing.Point(105, 82);
            this.sOLUONGSpinEdit.Name = "sOLUONGSpinEdit";
            this.sOLUONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sOLUONGSpinEdit.TabIndex = 5;
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(36, 111);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(105, 108);
            this.dONGIASpinEdit.Name = "dONGIASpinEdit";
            this.dONGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dONGIASpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dONGIASpinEdit.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // btnThem
            // 
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 22);
            this.btnThem.Text = "Them";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(180, 22);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 22);
            this.btnXoa.Text = "Xoa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ds_QLVT ds_QLVT;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private ds_QLVTTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private ds_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pHIEUNHAPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ds_QLVTTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private System.Windows.Forms.DataGridView cTPNDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DevExpress.XtraEditors.TextEdit mAPNTextEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGSpinEdit;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnGhi;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
    }
}