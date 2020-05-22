using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRIGGER_NGUYENLENGOCTHANH
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private Form checkIfExist(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void BtnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkIfExist(typeof(formPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuNhap f = new formPhieuNhap();
               // f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkIfExist(typeof(formPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuXuat f = new formPhieuXuat();
               // f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkIfExist(typeof(formVatTu));
            if (frm != null) frm.Activate();
            else
            {
                formVatTu f = new formVatTu();
               // f.MdiParent = this;
                f.Show();
            }
        }
    }
}
