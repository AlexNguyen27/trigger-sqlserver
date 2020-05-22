using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TRIGGER_NGUYENLENGOCTHANH
{
    public partial class formVatTu : DevExpress.XtraEditors.XtraForm
    {
        public formVatTu()
        {
            InitializeComponent();
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            this.vATTUTableAdapter.Fill(this.ds_QLVT.VATTU);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.vATTUTableAdapter.Fill(this.ds_QLVT.VATTU);
        }
        private Form checkIfExist(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void BtnPhieuNhap_Click(object sender, EventArgs e)
        {
            Form frm = this.checkIfExist(typeof(formPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuNhap f = new formPhieuNhap();
                f.Show();
            }
        }

        private void BtnPhieuXuat_Click(object sender, EventArgs e)
        {
            Form frm = this.checkIfExist(typeof(formPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuXuat f = new formPhieuXuat();
                f.Show();
            }
        }
    }
}