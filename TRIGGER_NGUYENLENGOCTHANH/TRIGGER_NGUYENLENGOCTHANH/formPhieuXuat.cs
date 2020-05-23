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

        private Boolean isAddNew = false;

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;
            this.pHIEUXUATTableAdapter.Fill(this.ds_QLVT.PHIEUXUAT);
            this.cTPXTableAdapter.Fill(this.ds_QLVT.CTPX);
            txtMAVT.ReadOnly = true;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsBehavior.ReadOnly = true;
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
            if (isAddNew)
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand sqlcmd = new SqlCommand();
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                try
                {
                    conn.ConnectionString = @"Data Source=THANH;Initial Catalog=QLVT;User ID=sa;Password=1234";
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message, "", MessageBoxButtons.OK);
                }

                String str = "dbo.SP_CheckMaVTisExist";
                sqlcmd = conn.CreateCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = str;
                sqlcmd.Parameters.Add("@MAVT", SqlDbType.NChar).Value = txtMAVT.Text.Trim();
                sqlcmd.Parameters.Add("@LOAI", SqlDbType.NChar).Value = "PX";
                sqlcmd.Parameters.Add("@RET", SqlDbType.NChar).Direction = ParameterDirection.ReturnValue;
                sqlcmd.ExecuteNonQuery();
                String ret = sqlcmd.Parameters["@RET"].Value.ToString();
           
                if (ret == "1")
                {
                    txtMAVT.Focus();
                    MessageBox.Show("Mã vật tư không tồn tại, vui lòng nhập đúng", "Lỗi Ghi!", MessageBoxButtons.OK);
                    return;
                }
                if (ret == "3")
                {
                    txtMAVT.Focus();
                    MessageBox.Show("Mã vật tư đã tồn tại trong CTPX, vui lòng kiểm tra lại", "Lỗi Ghi!", MessageBoxButtons.OK);
                    return;
                }
            }

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
                    if (isAddNew)
                    {
                        txtMAVT.ReadOnly = true;
                        isAddNew = false;
                    }
                    MessageBox.Show("Ghi thành công", "Thông báo ", MessageBoxButtons.OK);
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn vui lòng kiểm tra lại thông tin trứơc khi ghi\n" + "Lỗi: *" + ex.Message, "Lỗi Ghi!", MessageBoxButtons.OK);
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
            txtMAVT.ReadOnly = false;
            isAddNew = true;
        }
    }
}