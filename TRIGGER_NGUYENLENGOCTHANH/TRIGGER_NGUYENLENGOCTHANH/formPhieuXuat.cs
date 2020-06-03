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
using System.Data.SqlClient;

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
            this.vATTUTableAdapter.Fill(this.ds_QLVT.VATTU);
            this.pHIEUXUATTableAdapter.Fill(this.ds_QLVT.PHIEUXUAT);
            this.cTPXTableAdapter.Fill(this.ds_QLVT.CTPX);

            //gridView1.OptionsBehavior.ReadOnly = false;
            //gridView2.OptionsBehavior.ReadOnly = false;
            maVT.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Boolean validationInput()
        {
            if (maVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã VT không được thiếu.\n", "", MessageBoxButtons.OK);
                maVT.Focus();
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
            if (MessageBox.Show("Bạn có chắc muốn ghi không?", "Ghi vào CTPN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("Ghi thành công", "Thông báo ", MessageBoxButtons.OK);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("CK_CTPX_SOLUONG"))
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0!");
                    }
                    else if (ex.Message.Contains("CK_CTPX_DONGIA"))
                    {
                        MessageBox.Show("Đơn giá phải lớn hơn hơn hoặc bằng 0!");
                    }
                    else if (ex.Message.Contains("duplicate"))
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại, vui lòng kiểm tra lại trước khi ghi!");
                    }
                    else
                    {
                        MessageBox.Show("Bạn vui lòng kiểm tra lại thông tin trứơc khi ghi \n" + "Lỗi: " + ex.Message, "Lỗi Ghi!", MessageBoxButtons.OK);
                    }
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
                    MessageBox.Show("Xóa thành công");
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

        private void BtnThemPX_Click(object sender, EventArgs e)
        {
            this.pHIEUXUATBindingSource.AddNew();
        }

        private void BtnGhiPX_Click(object sender, EventArgs e)
        {
            try
            {
                pHIEUXUATBindingSource.EndEdit();
                pHIEUXUATBindingSource.ResetCurrentItem();
                this.pHIEUXUATTableAdapter.Update(this.ds_QLVT.PHIEUXUAT);
                MessageBox.Show("Ghi thành công", "Thông báo ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại thông tin trứơc khi ghi \n" + "Lỗi: " + ex.Message, "Lỗi Ghi!", MessageBoxButtons.OK);
                return;
            }
        }
    }
}