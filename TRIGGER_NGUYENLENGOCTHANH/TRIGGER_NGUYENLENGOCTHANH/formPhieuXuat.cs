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
    public partial class formPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public formPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;
            this.pHIEUXUATTableAdapter.Fill(this.ds_QLVT.PHIEUXUAT);
            this.cTPXTableAdapter.Fill(this.ds_QLVT.CTPX);
        }
        public Boolean validationInput()
        {
            if (txtMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã VT không được thiếu.\n", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return false;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được thiếu.\n", "", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }
            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được thiếu.\n", "", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }
            return true;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.pHIEUXUATTableAdapter.Fill(this.ds_QLVT.PHIEUXUAT);
            this.cTPXTableAdapter.Fill(this.ds_QLVT.CTPX);
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa nó không?", "Sửa CTPN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Boolean checkValidation = validationInput();
                if (!checkValidation)
                {
                    return;
                }
                try
                {
                    fKCTPXPHIEUXUATBindingSource.EndEdit();
                    fKCTPXPHIEUXUATBindingSource.ResetCurrentItem();
                    this.cTPXTableAdapter.Update(this.ds_QLVT.CTPX);
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin CTPX trứơc khi ghi" + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nó không?", "Xóa chi tiết phiếu xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    fKCTPXPHIEUXUATBindingSource.RemoveCurrent();
                    this.cTPXTableAdapter.Update(ds_QLVT.CTPX);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu xuát.\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            this.fKCTPXPHIEUXUATBindingSource.AddNew();
        }
    }
}