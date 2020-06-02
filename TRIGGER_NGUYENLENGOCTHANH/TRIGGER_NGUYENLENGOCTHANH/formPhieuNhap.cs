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
    public partial class formPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public formPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;

            this.vATTUTableAdapter.Fill(this.ds_QLVT.VATTU);
            this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);

            gridView1.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsBehavior.ReadOnly = true;
            maVT.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Boolean validationInput()
        {
            if (maVT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã vật tư.\n", "", MessageBoxButtons.OK);
                maVT.Focus();
                return false;
            }
            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đúng Số lương.\n", "", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }
            if (txtDonGia.Text.Trim() == "") 
            {
                MessageBox.Show("Vui lòng nhập đúng Đơn giá.\n", "", MessageBoxButtons.OK);
                txtDonGia.Focus();
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
            if (MessageBox.Show("Bạn có chắc muốn ghi không?", "Ghi vào CTPN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("CK_CTPN_SOLUONG"))
                    {
                        MessageBox.Show("Số lượng phải lớn hơn hoặc bằng 0!");
                    }
                    else if (ex.Message.Contains("CK_CTPN_DONGIA"))
                    {
                        MessageBox.Show("Đơn giá phải lớn hơn hơn hoặc bằng 0!");
                    }
                 
                    else if(ex.Message.Contains("duplicate"))
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
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo ", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                try
                {
                    bdsCTPN.RemoveCurrent();
                    this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                    MessageBox.Show("Xóa thành công");
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("CK_SOLUONG"))
                    {
                        MessageBox.Show("Số lượng tồn trong Vật tư phải lớn hơn hoặc bằng 0!");
                        bdsCTPN.CancelEdit();
                        this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo ", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            bdsCTPN.CancelEdit();
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);
            this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
        }
    }
}