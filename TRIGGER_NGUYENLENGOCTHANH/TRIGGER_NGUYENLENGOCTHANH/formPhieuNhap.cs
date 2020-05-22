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
    public partial class formPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public formPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;
            this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);
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
        private void BtnThem_Click(object sender, EventArgs e)
        {
            this.bdsCTPN.AddNew();
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
                    bdsCTPN.EndEdit();
                    bdsCTPN.ResetCurrentItem();
                    this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                    MessageBox.Show("Ghi thành công", "Thông báo ", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi. Bạn kiểm tra lại thông tin trứơc khi ghi" + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo ", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                try
                {
                    bdsCTPN.RemoveCurrent();
                    this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo ", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            bdsCTPN.CancelEdit();
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);
        }
    }
}